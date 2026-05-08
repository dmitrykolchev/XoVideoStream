// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Managed.FFMpeg.Native;
using static Managed.FFMpeg.Native.Methods;

namespace FFMpeg.Sample;

internal class Program
{
    private static unsafe void Main(string[] args)
    {
        NativeLibrary.SetDllImportResolver(typeof(AVStream).Assembly, GetNativeAssembly);
        var context = avformat_alloc_context();
        var filePath = @"D:\Users\dykolchev.DYKBITS\Videos\Масяня. Эпизод 162. Санкт-Мариубург_Trim.mp4";

        var count = Encoding.UTF8.GetByteCount(filePath);
        Span<byte> _filePath = stackalloc byte[count + 1];
        Encoding.UTF8.GetBytes(filePath, _filePath);
        fixed (byte* pFilePath = _filePath)
        {
            if (avformat_open_input(&context, (sbyte*)pFilePath, null, null) < 0)
            {
                throw new InvalidOperationException("Не удалось открыть файл");
            }
        }

        if (avformat_find_stream_info(context, null) < 0)
        {
            throw new InvalidOperationException("Не удалось найти информацию о потоках");
        }

        AVStream* videoStream = null;
        var videoStreamIndex = -1;

        for (var i = 0; i < context->nb_streams; i++)
        {
            if (context->streams[i]->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
            {
                videoStream = context->streams[i];
                videoStreamIndex = i;
                break;
            }
        }
        if (videoStream == null)
        {
            throw new InvalidOperationException("Видеопоток не найден");
        }

        // Инициализация Bitstream Filter для конвертации в Annex B
        AVBSFContext* bsfContext = null;
        var name = "h264_mp4toannexb"u8;
        AVBitStreamFilter* bsf;
        fixed (byte* pName = name)
        {
            bsf = av_bsf_get_by_name((sbyte*)pName);
        }
        av_bsf_alloc(bsf, &bsfContext);
        avcodec_parameters_copy(bsfContext->par_in, videoStream->codecpar);
        av_bsf_init(bsfContext);

        var packet = av_packet_alloc();
        long startPts = -1;
        var startTimeMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        long index = 0;
        while (av_read_frame(context, packet) >= 0)
        {
            if (packet->stream_index == videoStreamIndex)
            {
                // Пропускаем пакет через фильтр (получаем Annex B)
                av_bsf_send_packet(bsfContext, packet);
                while (av_bsf_receive_packet(bsfContext, packet) == 0)
                {
                    // Вычисляем PTS в микросекундах на основе time_base
                    var timeBase = (double)videoStream->time_base.num / videoStream->time_base.den;
                    var ptsMicrosec = (long)(packet->pts * timeBase * 1_000_000);

                    if (startPts == -1)
                    {
                        startPts = ptsMicrosec;
                    }

                    // Pacing: Задержка отправки для синхронизации со скоростью видео
                    var elapsedRealTimeMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - startTimeMs;
                    var videoTimeMs = (ptsMicrosec - startPts) / 1000;
                    if (videoTimeMs > elapsedRealTimeMs)
                    {
                        //await Task.Delay((int)(videoTimeMs - elapsedRealTimeMs));
                    }

                    var isKeyFrame = (packet->flags & AV_PKT_FLAG_KEY) != 0;
                    Console.WriteLine($"[{++index,5}]: packet size: {packet->size,6} ({TimeSpan.FromMicroseconds(ptsMicrosec):hh\\:mm\\:ss\\.fff})");

                    // Формирование бинарного пакета: 1b Type + 1b IsKey + 8b PTS + Payload
                    var buffer = new byte[1 + 1 + 8 + packet->size];
                    buffer[0] = 1; // Тип = Кадр
                    buffer[1] = (byte)(isKeyFrame ? 1 : 0);
                    BitConverter.TryWriteBytes(buffer.AsSpan(2, 8), ptsMicrosec); // Ожидаем Little Endian

                    // Копирование сырых данных NAL-юнита
                    Marshal.Copy((IntPtr)packet->data, buffer, 10, packet->size);

                    //await webSocket.SendAsync(buffer, WebSocketMessageType.Binary, true, cancellationToken);
                }
            }
        }
        av_packet_unref(packet);
        av_packet_free(&packet);
        av_bsf_free(&bsfContext);
        avformat_close_input(&context);
    }

    private static readonly Dictionary<string, string> _nativeLibraries = new()
    {
        ["win-x64:avcodec"] = "avcodec-62.dll",
        ["win-x64:avdevice"] = "avdevice-62.dll",
        ["win-x64:avfilter"] = "avfilter-11.dll",
        ["win-x64:avformat"] = "avformat-62.dll",
        ["win-x64:avutil"] = "avutil-60.dll",
        ["win-x64:swresample"] = "swresample-6.dll",
        ["win-x64:swscale"] = "swscale-9.dll",

        ["linux-x64:avcodec"] = "avcodec-62.so",
        ["linux-x64:avdevice"] = "avdevice-62.so",
        ["linux-x64:avfilter"] = "avfilter-11.so",
        ["linux-x64:avformat"] = "avformat-62.so",
        ["linux-x64:avutil"] = "avutil-60.so",
        ["linux-x64:swresample"] = "swresample-6.so",
        ["linux-x64:swscale"] = "swscale-9.so",
    };

    private static nint GetNativeAssembly(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        var rid = RuntimeInformation.RuntimeIdentifier;
        if (_nativeLibraries.TryGetValue(rid + ":" + libraryName, out var fileName))
        {
            return NativeLibrary.Load(Path.Combine(rid, fileName), assembly, searchPath);
        }
        return IntPtr.Zero;
    }
}

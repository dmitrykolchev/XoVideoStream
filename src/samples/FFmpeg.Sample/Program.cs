using Managed.FFMpeg.Native;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using static Managed.FFMpeg.Native.Methods;


namespace FFMpeg.Sample;

internal class Program
{
    private static unsafe void Main(string[] args)
    {
        NativeLibrary.SetDllImportResolver(typeof(AVStream).Assembly, GetNativeAssembly);
        AVFormatContext* context = avformat_alloc_context();
        string filePath = @"D:\Users\dykolchev.DYKBITS\Videos\Масяня. Эпизод 162. Санкт-Мариубург_Trim.mp4";

        int count = Encoding.UTF8.GetByteCount(filePath);
        Span<byte> _filePath = stackalloc byte[count + 1];
        _ = Encoding.UTF8.GetBytes(filePath, _filePath);
        fixed (byte* pFilePath = _filePath)
        {
            if (avformat_open_input(&context, (sbyte*)pFilePath, null, null) < 0)
            {
                throw new Exception("Не удалось открыть файл");
            }
        }

        if (avformat_find_stream_info(context, null) < 0)
        {
            throw new Exception("Не удалось найти информацию о потоках");
        }

        AVStream* videoStream = null;
        int videoStreamIndex = -1;

        for (int i = 0; i < context->nb_streams; i++)
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
            throw new Exception("Видеопоток не найден");
        }

        // Инициализация Bitstream Filter для конвертации в Annex B
        AVBSFContext* bsfContext = null;
        ReadOnlySpan<byte> name = "h264_mp4toannexb"u8;
        AVBitStreamFilter* bsf;
        fixed (byte* pName = name)
        {
            bsf = av_bsf_get_by_name((sbyte*)pName);
        }
        _ = av_bsf_alloc(bsf, &bsfContext);
        _ = avcodec_parameters_copy(bsfContext->par_in, videoStream->codecpar);
        _ = av_bsf_init(bsfContext);

        AVPacket* packet = av_packet_alloc();
        long startPts = -1;
        long startTimeMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        long index = 0;
        while (av_read_frame(context, packet) >= 0)
        {
            if (packet->stream_index == videoStreamIndex)
            {
                // Пропускаем пакет через фильтр (получаем Annex B)
                _ = av_bsf_send_packet(bsfContext, packet);
                while (av_bsf_receive_packet(bsfContext, packet) == 0)
                {
                    // Вычисляем PTS в микросекундах на основе time_base
                    double timeBase = (double)videoStream->time_base.num / videoStream->time_base.den;
                    long ptsMicrosec = (long)(packet->pts * timeBase * 1_000_000);

                    if (startPts == -1) startPts = ptsMicrosec;

                    // Pacing: Задержка отправки для синхронизации со скоростью видео
                    long elapsedRealTimeMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - startTimeMs;
                    long videoTimeMs = (ptsMicrosec - startPts) / 1000;
                    if (videoTimeMs > elapsedRealTimeMs)
                    {
                        //await Task.Delay((int)(videoTimeMs - elapsedRealTimeMs));
                    }

                    bool isKeyFrame = (packet->flags & AV_PKT_FLAG_KEY) != 0;
                    Console.WriteLine($"[{++index,5}]: packet size: {packet->size,6} ({TimeSpan.FromMicroseconds(ptsMicrosec):hh\\:mm\\:ss\\.fff})");

                    // Формирование бинарного пакета: 1b Type + 1b IsKey + 8b PTS + Payload
                    byte[] buffer = new byte[1 + 1 + 8 + packet->size];
                    buffer[0] = 1; // Тип = Кадр
                    buffer[1] = (byte)(isKeyFrame ? 1 : 0);
                    _ = BitConverter.TryWriteBytes(buffer.AsSpan(2, 8), ptsMicrosec); // Ожидаем Little Endian

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

    private static nint GetNativeAssembly(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (libraryName == "avcodec")
        {
            // Custom logic: load different filenames based on the OS
            string path = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? @"win-x64\avcodec-62.dll"
                : "avcodec-62.so";

            // Return a handle to the loaded library
            return NativeLibrary.Load(path, assembly, searchPath);
        }
        else if (libraryName == "avformat")
        {
            string path = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? @"win-x64\avformat-62.dll"
                : "avcodec-62.so";

            // Return a handle to the loaded library
            return NativeLibrary.Load(path, assembly, searchPath);
        }

        // Return Zero to let the default .NET resolver handle it
        return IntPtr.Zero;
    }
}

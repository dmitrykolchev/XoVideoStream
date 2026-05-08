using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.FFMpeg.Native;

[StructLayout(LayoutKind.Sequential)]
public struct AVContainerFifo { }

[StructLayout(LayoutKind.Sequential)]
public struct AVCodecInternal { }

[StructLayout(LayoutKind.Sequential)]
public struct AVBuffer { }

[StructLayout(LayoutKind.Sequential)]
public struct AVDictionary { }

[StructLayout(LayoutKind.Sequential)]
public struct AVBufferPool { }

[StructLayout(LayoutKind.Sequential)]
public struct AVAES { }

[StructLayout(LayoutKind.Sequential)]
public struct AVAESCTR { }

[StructLayout(LayoutKind.Sequential)]
public struct AVBPrint { }

[StructLayout(LayoutKind.Sequential)]
public struct SwrContext { }

[StructLayout(LayoutKind.Sequential)]
public struct AVFilterPad { }

[StructLayout(LayoutKind.Sequential)]
public struct AVFilterCommand { }

[StructLayout(LayoutKind.Sequential)]
public struct AVCodecTag { }

[StructLayout(LayoutKind.Sequential)]
public struct AVFilterFormats { }

[StructLayout(LayoutKind.Sequential)]
public struct AVFilterChannelLayouts { }

[StructLayout(LayoutKind.Sequential)]
public struct AVIAMFAudioElement { }

[StructLayout(LayoutKind.Sequential)]
public struct AVIAMFMixPresentation { }

[StructLayout(LayoutKind.Sequential)]
public struct AVIODirContext { }

[StructLayout(LayoutKind.Sequential)]
public struct AVBSFList { }

public unsafe partial struct AVStreamGroupTileGrid
{
    [NativeTypeName("const AVClass *")]
    public AVClass* av_class;

    [NativeTypeName("unsigned int")]
    public uint nb_tiles;

    public int coded_width;

    public int coded_height;

    [NativeTypeName("struct (anonymous struct at D:/LIBS/ffmpeg-8.1.1/include/libavformat/avformat.h:986:5) *")]
    public _Anonymous__Offsets__Struct* offsets;

    [NativeTypeName("uint8_t[4]")]
    public _background_e__FixedBuffer background;

    public int horizontal_offset;

    public int vertical_offset;

    public int width;

    public int height;

    public AVPacketSideData* coded_side_data;

    public int nb_coded_side_data;

    public partial struct _Anonymous__Offsets__Struct
    {
        [NativeTypeName("unsigned int")]
        public uint idx;

        public int horizontal;

        public int vertical;
    }

    [InlineArray(4)]
    public partial struct _background_e__FixedBuffer
    {
        public byte e0;
    }
}

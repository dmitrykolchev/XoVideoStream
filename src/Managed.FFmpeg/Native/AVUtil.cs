using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.FFMpeg.Native
{
    public enum AVMediaType
    {
        AVMEDIA_TYPE_UNKNOWN = -1,
        AVMEDIA_TYPE_VIDEO,
        AVMEDIA_TYPE_AUDIO,
        AVMEDIA_TYPE_DATA,
        AVMEDIA_TYPE_SUBTITLE,
        AVMEDIA_TYPE_ATTACHMENT,
        AVMEDIA_TYPE_NB,
    }

    public enum AVPictureType
    {
        AV_PICTURE_TYPE_NONE = 0,
        AV_PICTURE_TYPE_I,
        AV_PICTURE_TYPE_P,
        AV_PICTURE_TYPE_B,
        AV_PICTURE_TYPE_S,
        AV_PICTURE_TYPE_SI,
        AV_PICTURE_TYPE_SP,
        AV_PICTURE_TYPE_BI,
    }

    public enum AVSampleFormat
    {
        AV_SAMPLE_FMT_NONE = -1,
        AV_SAMPLE_FMT_U8,
        AV_SAMPLE_FMT_S16,
        AV_SAMPLE_FMT_S32,
        AV_SAMPLE_FMT_FLT,
        AV_SAMPLE_FMT_DBL,
        AV_SAMPLE_FMT_U8P,
        AV_SAMPLE_FMT_S16P,
        AV_SAMPLE_FMT_S32P,
        AV_SAMPLE_FMT_FLTP,
        AV_SAMPLE_FMT_DBLP,
        AV_SAMPLE_FMT_S64,
        AV_SAMPLE_FMT_S64P,
        AV_SAMPLE_FMT_NB,
    }

    public unsafe partial struct AVBufferRef
    {
        public AVBuffer* buffer;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        [NativeTypeName("size_t")]
        public nuint size;
    }

    public enum AVOptionType
    {
        AV_OPT_TYPE_FLAGS = 1,
        AV_OPT_TYPE_INT,
        AV_OPT_TYPE_INT64,
        AV_OPT_TYPE_DOUBLE,
        AV_OPT_TYPE_FLOAT,
        AV_OPT_TYPE_STRING,
        AV_OPT_TYPE_RATIONAL,
        AV_OPT_TYPE_BINARY,
        AV_OPT_TYPE_DICT,
        AV_OPT_TYPE_UINT64,
        AV_OPT_TYPE_CONST,
        AV_OPT_TYPE_IMAGE_SIZE,
        AV_OPT_TYPE_PIXEL_FMT,
        AV_OPT_TYPE_SAMPLE_FMT,
        AV_OPT_TYPE_VIDEO_RATE,
        AV_OPT_TYPE_DURATION,
        AV_OPT_TYPE_COLOR,
        AV_OPT_TYPE_BOOL,
        AV_OPT_TYPE_CHLAYOUT,
        AV_OPT_TYPE_UINT,
        AV_OPT_TYPE_FLAG_ARRAY = (1 << 16),
    }

    public unsafe partial struct AVOptionArrayDef
    {
        [NativeTypeName("const char *")]
        public sbyte* def;

        [NativeTypeName("unsigned int")]
        public uint size_min;

        [NativeTypeName("unsigned int")]
        public uint size_max;

        [NativeTypeName("char")]
        public sbyte sep;
    }

    public unsafe partial struct AVOption
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* help;

        public int offset;

        [NativeTypeName("enum AVOptionType")]
        public AVOptionType type;

        [NativeTypeName("__AnonymousRecord_opt_L451_C5")]
        public _default_val_e__Union default_val;

        public double min;

        public double max;

        public int flags;

        [NativeTypeName("const char *")]
        public sbyte* unit;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _default_val_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("int64_t")]
            public long i64;

            [FieldOffset(0)]
            public double dbl;

            [FieldOffset(0)]
            [NativeTypeName("const char *")]
            public sbyte* str;

            [FieldOffset(0)]
            public AVRational q;

            [FieldOffset(0)]
            [NativeTypeName("const AVOptionArrayDef *")]
            public AVOptionArrayDef* arr;
        }
    }

    public unsafe partial struct AVOptionRange
    {
        [NativeTypeName("const char *")]
        public sbyte* str;

        public double value_min;

        public double value_max;

        public double component_min;

        public double component_max;

        public int is_range;
    }

    public unsafe partial struct AVOptionRanges
    {
        public AVOptionRange** range;

        public int nb_ranges;

        public int nb_components;
    }

    public enum AV_OPT_FLAG
    {
        AV_OPT_FLAG_IMPLICIT_KEY = 1,
    }

    public enum AVChannel
    {
        AV_CHAN_NONE = -1,
        AV_CHAN_FRONT_LEFT,
        AV_CHAN_FRONT_RIGHT,
        AV_CHAN_FRONT_CENTER,
        AV_CHAN_LOW_FREQUENCY,
        AV_CHAN_BACK_LEFT,
        AV_CHAN_BACK_RIGHT,
        AV_CHAN_FRONT_LEFT_OF_CENTER,
        AV_CHAN_FRONT_RIGHT_OF_CENTER,
        AV_CHAN_BACK_CENTER,
        AV_CHAN_SIDE_LEFT,
        AV_CHAN_SIDE_RIGHT,
        AV_CHAN_TOP_CENTER,
        AV_CHAN_TOP_FRONT_LEFT,
        AV_CHAN_TOP_FRONT_CENTER,
        AV_CHAN_TOP_FRONT_RIGHT,
        AV_CHAN_TOP_BACK_LEFT,
        AV_CHAN_TOP_BACK_CENTER,
        AV_CHAN_TOP_BACK_RIGHT,
        AV_CHAN_STEREO_LEFT = 29,
        AV_CHAN_STEREO_RIGHT,
        AV_CHAN_WIDE_LEFT,
        AV_CHAN_WIDE_RIGHT,
        AV_CHAN_SURROUND_DIRECT_LEFT,
        AV_CHAN_SURROUND_DIRECT_RIGHT,
        AV_CHAN_LOW_FREQUENCY_2,
        AV_CHAN_TOP_SIDE_LEFT,
        AV_CHAN_TOP_SIDE_RIGHT,
        AV_CHAN_BOTTOM_FRONT_CENTER,
        AV_CHAN_BOTTOM_FRONT_LEFT,
        AV_CHAN_BOTTOM_FRONT_RIGHT,
        AV_CHAN_SIDE_SURROUND_LEFT,
        AV_CHAN_SIDE_SURROUND_RIGHT,
        AV_CHAN_TOP_SURROUND_LEFT,
        AV_CHAN_TOP_SURROUND_RIGHT,
        AV_CHAN_BINAURAL_LEFT = 61,
        AV_CHAN_BINAURAL_RIGHT,
        AV_CHAN_UNUSED = 0x200,
        AV_CHAN_UNKNOWN = 0x300,
        AV_CHAN_AMBISONIC_BASE = 0x400,
        AV_CHAN_AMBISONIC_END = 0x7ff,
    }

    public enum AVChannelOrder
    {
        AV_CHANNEL_ORDER_UNSPEC,
        AV_CHANNEL_ORDER_NATIVE,
        AV_CHANNEL_ORDER_CUSTOM,
        AV_CHANNEL_ORDER_AMBISONIC,
        FF_CHANNEL_ORDER_NB,
    }

    public enum AVMatrixEncoding
    {
        AV_MATRIX_ENCODING_NONE,
        AV_MATRIX_ENCODING_DOLBY,
        AV_MATRIX_ENCODING_DPLII,
        AV_MATRIX_ENCODING_DPLIIX,
        AV_MATRIX_ENCODING_DPLIIZ,
        AV_MATRIX_ENCODING_DOLBYEX,
        AV_MATRIX_ENCODING_DOLBYHEADPHONE,
        AV_MATRIX_ENCODING_NB,
    }

    public unsafe partial struct AVChannelCustom
    {
        [NativeTypeName("enum AVChannel")]
        public AVChannel id;

        [NativeTypeName("char[16]")]
        public _name_e__FixedBuffer name;

        public void* opaque;

        [InlineArray(16)]
        public partial struct _name_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct AVChannelLayout
    {
        [NativeTypeName("enum AVChannelOrder")]
        public AVChannelOrder order;

        public int nb_channels;

        [NativeTypeName("__AnonymousRecord_channel_layout_L336_C5")]
        public _u_e__Union u;

        public void* opaque;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("uint64_t")]
            public ulong mask;

            [FieldOffset(0)]
            public AVChannelCustom* map;
        }
    }

    public unsafe partial struct AVDictionaryEntry
    {
        [NativeTypeName("char *")]
        public sbyte* key;

        [NativeTypeName("char *")]
        public sbyte* value;
    }

    public enum AVFrameSideDataType
    {
        AV_FRAME_DATA_PANSCAN,
        AV_FRAME_DATA_A53_CC,
        AV_FRAME_DATA_STEREO3D,
        AV_FRAME_DATA_MATRIXENCODING,
        AV_FRAME_DATA_DOWNMIX_INFO,
        AV_FRAME_DATA_REPLAYGAIN,
        AV_FRAME_DATA_DISPLAYMATRIX,
        AV_FRAME_DATA_AFD,
        AV_FRAME_DATA_MOTION_VECTORS,
        AV_FRAME_DATA_SKIP_SAMPLES,
        AV_FRAME_DATA_AUDIO_SERVICE_TYPE,
        AV_FRAME_DATA_MASTERING_DISPLAY_METADATA,
        AV_FRAME_DATA_GOP_TIMECODE,
        AV_FRAME_DATA_SPHERICAL,
        AV_FRAME_DATA_CONTENT_LIGHT_LEVEL,
        AV_FRAME_DATA_ICC_PROFILE,
        AV_FRAME_DATA_S12M_TIMECODE,
        AV_FRAME_DATA_DYNAMIC_HDR_PLUS,
        AV_FRAME_DATA_REGIONS_OF_INTEREST,
        AV_FRAME_DATA_VIDEO_ENC_PARAMS,
        AV_FRAME_DATA_SEI_UNREGISTERED,
        AV_FRAME_DATA_FILM_GRAIN_PARAMS,
        AV_FRAME_DATA_DETECTION_BBOXES,
        AV_FRAME_DATA_DOVI_RPU_BUFFER,
        AV_FRAME_DATA_DOVI_METADATA,
        AV_FRAME_DATA_DYNAMIC_HDR_VIVID,
        AV_FRAME_DATA_AMBIENT_VIEWING_ENVIRONMENT,
        AV_FRAME_DATA_VIDEO_HINT,
        AV_FRAME_DATA_LCEVC,
        AV_FRAME_DATA_VIEW_ID,
        AV_FRAME_DATA_3D_REFERENCE_DISPLAYS,
        AV_FRAME_DATA_EXIF,
    }

    public enum AVActiveFormatDescription
    {
        AV_AFD_SAME = 8,
        AV_AFD_4_3 = 9,
        AV_AFD_16_9 = 10,
        AV_AFD_14_9 = 11,
        AV_AFD_4_3_SP_14_9 = 13,
        AV_AFD_16_9_SP_14_9 = 14,
        AV_AFD_SP_4_3 = 15,
    }

    public unsafe partial struct AVFrameSideData
    {
        [NativeTypeName("enum AVFrameSideDataType")]
        public AVFrameSideDataType type;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        [NativeTypeName("size_t")]
        public nuint size;

        public AVDictionary* metadata;

        public AVBufferRef* buf;
    }

    public enum AVSideDataProps
    {
        AV_SIDE_DATA_PROP_GLOBAL = (1 << 0),
        AV_SIDE_DATA_PROP_MULTI = (1 << 1),
        AV_SIDE_DATA_PROP_SIZE_DEPENDENT = (1 << 2),
        AV_SIDE_DATA_PROP_COLOR_DEPENDENT = (1 << 3),
        AV_SIDE_DATA_PROP_CHANNEL_DEPENDENT = (1 << 4),
    }

    public unsafe partial struct AVSideDataDescriptor
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("unsigned int")]
        public uint props;
    }

    public partial struct AVRegionOfInterest
    {
        [NativeTypeName("uint32_t")]
        public uint self_size;

        public int top;

        public int bottom;

        public int left;

        public int right;

        public AVRational qoffset;
    }

    public unsafe partial struct AVFrame
    {
        [NativeTypeName("uint8_t *[8]")]
        public _data_e__FixedBuffer data;

        [NativeTypeName("int[8]")]
        public _linesize_e__FixedBuffer linesize;

        [NativeTypeName("uint8_t **")]
        public byte** extended_data;

        public int width;

        public int height;

        public int nb_samples;

        public int format;

        [NativeTypeName("enum AVPictureType")]
        public AVPictureType pict_type;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        public long pkt_dts;

        public AVRational time_base;

        public int quality;

        public void* opaque;

        public int repeat_pict;

        public int sample_rate;

        [NativeTypeName("AVBufferRef *[8]")]
        public _buf_e__FixedBuffer buf;

        public AVBufferRef** extended_buf;

        public int nb_extended_buf;

        public AVFrameSideData** side_data;

        public int nb_side_data;

        public int flags;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace colorspace;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_location;

        [NativeTypeName("int64_t")]
        public long best_effort_timestamp;

        public AVDictionary* metadata;

        public int decode_error_flags;

        public AVBufferRef* hw_frames_ctx;

        public AVBufferRef* opaque_ref;

        [NativeTypeName("size_t")]
        public nuint crop_top;

        [NativeTypeName("size_t")]
        public nuint crop_bottom;

        [NativeTypeName("size_t")]
        public nuint crop_left;

        [NativeTypeName("size_t")]
        public nuint crop_right;

        public void* private_ref;

        public AVChannelLayout ch_layout;

        [NativeTypeName("int64_t")]
        public long duration;

        [NativeTypeName("enum AVAlphaMode")]
        public AVAlphaMode alpha_mode;

        public unsafe partial struct _data_e__FixedBuffer
        {
            public byte* e0;
            public byte* e1;
            public byte* e2;
            public byte* e3;
            public byte* e4;
            public byte* e5;
            public byte* e6;
            public byte* e7;

            public ref byte* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (byte** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        [InlineArray(8)]
        public partial struct _linesize_e__FixedBuffer
        {
            public int e0;
        }

        public unsafe partial struct _buf_e__FixedBuffer
        {
            public AVBufferRef* e0;
            public AVBufferRef* e1;
            public AVBufferRef* e2;
            public AVBufferRef* e3;
            public AVBufferRef* e4;
            public AVBufferRef* e5;
            public AVBufferRef* e6;
            public AVBufferRef* e7;

            public ref AVBufferRef* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (AVBufferRef** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public enum AV_FRAME_CROP
    {
        AV_FRAME_CROP_UNALIGNED = 1 << 0,
    }

    public enum AVClassCategory
    {
        AV_CLASS_CATEGORY_NA = 0,
        AV_CLASS_CATEGORY_INPUT,
        AV_CLASS_CATEGORY_OUTPUT,
        AV_CLASS_CATEGORY_MUXER,
        AV_CLASS_CATEGORY_DEMUXER,
        AV_CLASS_CATEGORY_ENCODER,
        AV_CLASS_CATEGORY_DECODER,
        AV_CLASS_CATEGORY_FILTER,
        AV_CLASS_CATEGORY_BITSTREAM_FILTER,
        AV_CLASS_CATEGORY_SWSCALER,
        AV_CLASS_CATEGORY_SWRESAMPLER,
        AV_CLASS_CATEGORY_HWDEVICE,
        AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT = 40,
        AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT,
        AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT,
        AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT,
        AV_CLASS_CATEGORY_DEVICE_OUTPUT,
        AV_CLASS_CATEGORY_DEVICE_INPUT,
        AV_CLASS_CATEGORY_NB,
    }

    public enum AVClassStateFlags
    {
        AV_CLASS_STATE_INITIALIZED = (1 << 0),
    }

    public unsafe partial struct AVClass
    {
        [NativeTypeName("const char *")]
        public sbyte* class_name;

        [NativeTypeName("const char *(*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, sbyte*> item_name;

        [NativeTypeName("const struct AVOption *")]
        public AVOption* option;

        public int version;

        public int log_level_offset_offset;

        public int parent_log_context_offset;

        public AVClassCategory category;

        [NativeTypeName("AVClassCategory (*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, AVClassCategory> get_category;

        [NativeTypeName("int (*)(struct AVOptionRanges **, void *, const char *, int)")]
        public delegate* unmanaged[Cdecl]<AVOptionRanges**, void*, sbyte*, int, int> query_ranges;

        [NativeTypeName("void *(*)(void *, void *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void*> child_next;

        [NativeTypeName("const struct AVClass *(*)(void **)")]
        public delegate* unmanaged[Cdecl]<void**, AVClass*> child_class_iterate;

        public int state_flags_offset;
    }

    public enum AVPixelFormat
    {
        AV_PIX_FMT_NONE = -1,
        AV_PIX_FMT_YUV420P,
        AV_PIX_FMT_YUYV422,
        AV_PIX_FMT_RGB24,
        AV_PIX_FMT_BGR24,
        AV_PIX_FMT_YUV422P,
        AV_PIX_FMT_YUV444P,
        AV_PIX_FMT_YUV410P,
        AV_PIX_FMT_YUV411P,
        AV_PIX_FMT_GRAY8,
        AV_PIX_FMT_MONOWHITE,
        AV_PIX_FMT_MONOBLACK,
        AV_PIX_FMT_PAL8,
        AV_PIX_FMT_YUVJ420P,
        AV_PIX_FMT_YUVJ422P,
        AV_PIX_FMT_YUVJ444P,
        AV_PIX_FMT_UYVY422,
        AV_PIX_FMT_UYYVYY411,
        AV_PIX_FMT_BGR8,
        AV_PIX_FMT_BGR4,
        AV_PIX_FMT_BGR4_BYTE,
        AV_PIX_FMT_RGB8,
        AV_PIX_FMT_RGB4,
        AV_PIX_FMT_RGB4_BYTE,
        AV_PIX_FMT_NV12,
        AV_PIX_FMT_NV21,
        AV_PIX_FMT_ARGB,
        AV_PIX_FMT_RGBA,
        AV_PIX_FMT_ABGR,
        AV_PIX_FMT_BGRA,
        AV_PIX_FMT_GRAY16BE,
        AV_PIX_FMT_GRAY16LE,
        AV_PIX_FMT_YUV440P,
        AV_PIX_FMT_YUVJ440P,
        AV_PIX_FMT_YUVA420P,
        AV_PIX_FMT_RGB48BE,
        AV_PIX_FMT_RGB48LE,
        AV_PIX_FMT_RGB565BE,
        AV_PIX_FMT_RGB565LE,
        AV_PIX_FMT_RGB555BE,
        AV_PIX_FMT_RGB555LE,
        AV_PIX_FMT_BGR565BE,
        AV_PIX_FMT_BGR565LE,
        AV_PIX_FMT_BGR555BE,
        AV_PIX_FMT_BGR555LE,
        AV_PIX_FMT_VAAPI,
        AV_PIX_FMT_YUV420P16LE,
        AV_PIX_FMT_YUV420P16BE,
        AV_PIX_FMT_YUV422P16LE,
        AV_PIX_FMT_YUV422P16BE,
        AV_PIX_FMT_YUV444P16LE,
        AV_PIX_FMT_YUV444P16BE,
        AV_PIX_FMT_DXVA2_VLD,
        AV_PIX_FMT_RGB444LE,
        AV_PIX_FMT_RGB444BE,
        AV_PIX_FMT_BGR444LE,
        AV_PIX_FMT_BGR444BE,
        AV_PIX_FMT_YA8,
        AV_PIX_FMT_Y400A = AV_PIX_FMT_YA8,
        AV_PIX_FMT_GRAY8A = AV_PIX_FMT_YA8,
        AV_PIX_FMT_BGR48BE,
        AV_PIX_FMT_BGR48LE,
        AV_PIX_FMT_YUV420P9BE,
        AV_PIX_FMT_YUV420P9LE,
        AV_PIX_FMT_YUV420P10BE,
        AV_PIX_FMT_YUV420P10LE,
        AV_PIX_FMT_YUV422P10BE,
        AV_PIX_FMT_YUV422P10LE,
        AV_PIX_FMT_YUV444P9BE,
        AV_PIX_FMT_YUV444P9LE,
        AV_PIX_FMT_YUV444P10BE,
        AV_PIX_FMT_YUV444P10LE,
        AV_PIX_FMT_YUV422P9BE,
        AV_PIX_FMT_YUV422P9LE,
        AV_PIX_FMT_GBRP,
        AV_PIX_FMT_GBR24P = AV_PIX_FMT_GBRP,
        AV_PIX_FMT_GBRP9BE,
        AV_PIX_FMT_GBRP9LE,
        AV_PIX_FMT_GBRP10BE,
        AV_PIX_FMT_GBRP10LE,
        AV_PIX_FMT_GBRP16BE,
        AV_PIX_FMT_GBRP16LE,
        AV_PIX_FMT_YUVA422P,
        AV_PIX_FMT_YUVA444P,
        AV_PIX_FMT_YUVA420P9BE,
        AV_PIX_FMT_YUVA420P9LE,
        AV_PIX_FMT_YUVA422P9BE,
        AV_PIX_FMT_YUVA422P9LE,
        AV_PIX_FMT_YUVA444P9BE,
        AV_PIX_FMT_YUVA444P9LE,
        AV_PIX_FMT_YUVA420P10BE,
        AV_PIX_FMT_YUVA420P10LE,
        AV_PIX_FMT_YUVA422P10BE,
        AV_PIX_FMT_YUVA422P10LE,
        AV_PIX_FMT_YUVA444P10BE,
        AV_PIX_FMT_YUVA444P10LE,
        AV_PIX_FMT_YUVA420P16BE,
        AV_PIX_FMT_YUVA420P16LE,
        AV_PIX_FMT_YUVA422P16BE,
        AV_PIX_FMT_YUVA422P16LE,
        AV_PIX_FMT_YUVA444P16BE,
        AV_PIX_FMT_YUVA444P16LE,
        AV_PIX_FMT_VDPAU,
        AV_PIX_FMT_XYZ12LE,
        AV_PIX_FMT_XYZ12BE,
        AV_PIX_FMT_NV16,
        AV_PIX_FMT_NV20LE,
        AV_PIX_FMT_NV20BE,
        AV_PIX_FMT_RGBA64BE,
        AV_PIX_FMT_RGBA64LE,
        AV_PIX_FMT_BGRA64BE,
        AV_PIX_FMT_BGRA64LE,
        AV_PIX_FMT_YVYU422,
        AV_PIX_FMT_YA16BE,
        AV_PIX_FMT_YA16LE,
        AV_PIX_FMT_GBRAP,
        AV_PIX_FMT_GBRAP16BE,
        AV_PIX_FMT_GBRAP16LE,
        AV_PIX_FMT_QSV,
        AV_PIX_FMT_MMAL,
        AV_PIX_FMT_D3D11VA_VLD,
        AV_PIX_FMT_CUDA,
        AV_PIX_FMT_0RGB,
        AV_PIX_FMT_RGB0,
        AV_PIX_FMT_0BGR,
        AV_PIX_FMT_BGR0,
        AV_PIX_FMT_YUV420P12BE,
        AV_PIX_FMT_YUV420P12LE,
        AV_PIX_FMT_YUV420P14BE,
        AV_PIX_FMT_YUV420P14LE,
        AV_PIX_FMT_YUV422P12BE,
        AV_PIX_FMT_YUV422P12LE,
        AV_PIX_FMT_YUV422P14BE,
        AV_PIX_FMT_YUV422P14LE,
        AV_PIX_FMT_YUV444P12BE,
        AV_PIX_FMT_YUV444P12LE,
        AV_PIX_FMT_YUV444P14BE,
        AV_PIX_FMT_YUV444P14LE,
        AV_PIX_FMT_GBRP12BE,
        AV_PIX_FMT_GBRP12LE,
        AV_PIX_FMT_GBRP14BE,
        AV_PIX_FMT_GBRP14LE,
        AV_PIX_FMT_YUVJ411P,
        AV_PIX_FMT_BAYER_BGGR8,
        AV_PIX_FMT_BAYER_RGGB8,
        AV_PIX_FMT_BAYER_GBRG8,
        AV_PIX_FMT_BAYER_GRBG8,
        AV_PIX_FMT_BAYER_BGGR16LE,
        AV_PIX_FMT_BAYER_BGGR16BE,
        AV_PIX_FMT_BAYER_RGGB16LE,
        AV_PIX_FMT_BAYER_RGGB16BE,
        AV_PIX_FMT_BAYER_GBRG16LE,
        AV_PIX_FMT_BAYER_GBRG16BE,
        AV_PIX_FMT_BAYER_GRBG16LE,
        AV_PIX_FMT_BAYER_GRBG16BE,
        AV_PIX_FMT_YUV440P10LE,
        AV_PIX_FMT_YUV440P10BE,
        AV_PIX_FMT_YUV440P12LE,
        AV_PIX_FMT_YUV440P12BE,
        AV_PIX_FMT_AYUV64LE,
        AV_PIX_FMT_AYUV64BE,
        AV_PIX_FMT_VIDEOTOOLBOX,
        AV_PIX_FMT_P010LE,
        AV_PIX_FMT_P010BE,
        AV_PIX_FMT_GBRAP12BE,
        AV_PIX_FMT_GBRAP12LE,
        AV_PIX_FMT_GBRAP10BE,
        AV_PIX_FMT_GBRAP10LE,
        AV_PIX_FMT_MEDIACODEC,
        AV_PIX_FMT_GRAY12BE,
        AV_PIX_FMT_GRAY12LE,
        AV_PIX_FMT_GRAY10BE,
        AV_PIX_FMT_GRAY10LE,
        AV_PIX_FMT_P016LE,
        AV_PIX_FMT_P016BE,
        AV_PIX_FMT_D3D11,
        AV_PIX_FMT_GRAY9BE,
        AV_PIX_FMT_GRAY9LE,
        AV_PIX_FMT_GBRPF32BE,
        AV_PIX_FMT_GBRPF32LE,
        AV_PIX_FMT_GBRAPF32BE,
        AV_PIX_FMT_GBRAPF32LE,
        AV_PIX_FMT_DRM_PRIME,
        AV_PIX_FMT_OPENCL,
        AV_PIX_FMT_GRAY14BE,
        AV_PIX_FMT_GRAY14LE,
        AV_PIX_FMT_GRAYF32BE,
        AV_PIX_FMT_GRAYF32LE,
        AV_PIX_FMT_YUVA422P12BE,
        AV_PIX_FMT_YUVA422P12LE,
        AV_PIX_FMT_YUVA444P12BE,
        AV_PIX_FMT_YUVA444P12LE,
        AV_PIX_FMT_NV24,
        AV_PIX_FMT_NV42,
        AV_PIX_FMT_VULKAN,
        AV_PIX_FMT_Y210BE,
        AV_PIX_FMT_Y210LE,
        AV_PIX_FMT_X2RGB10LE,
        AV_PIX_FMT_X2RGB10BE,
        AV_PIX_FMT_X2BGR10LE,
        AV_PIX_FMT_X2BGR10BE,
        AV_PIX_FMT_P210BE,
        AV_PIX_FMT_P210LE,
        AV_PIX_FMT_P410BE,
        AV_PIX_FMT_P410LE,
        AV_PIX_FMT_P216BE,
        AV_PIX_FMT_P216LE,
        AV_PIX_FMT_P416BE,
        AV_PIX_FMT_P416LE,
        AV_PIX_FMT_VUYA,
        AV_PIX_FMT_RGBAF16BE,
        AV_PIX_FMT_RGBAF16LE,
        AV_PIX_FMT_VUYX,
        AV_PIX_FMT_P012LE,
        AV_PIX_FMT_P012BE,
        AV_PIX_FMT_Y212BE,
        AV_PIX_FMT_Y212LE,
        AV_PIX_FMT_XV30BE,
        AV_PIX_FMT_XV30LE,
        AV_PIX_FMT_XV36BE,
        AV_PIX_FMT_XV36LE,
        AV_PIX_FMT_RGBF32BE,
        AV_PIX_FMT_RGBF32LE,
        AV_PIX_FMT_RGBAF32BE,
        AV_PIX_FMT_RGBAF32LE,
        AV_PIX_FMT_P212BE,
        AV_PIX_FMT_P212LE,
        AV_PIX_FMT_P412BE,
        AV_PIX_FMT_P412LE,
        AV_PIX_FMT_GBRAP14BE,
        AV_PIX_FMT_GBRAP14LE,
        AV_PIX_FMT_D3D12,
        AV_PIX_FMT_AYUV,
        AV_PIX_FMT_UYVA,
        AV_PIX_FMT_VYU444,
        AV_PIX_FMT_V30XBE,
        AV_PIX_FMT_V30XLE,
        AV_PIX_FMT_RGBF16BE,
        AV_PIX_FMT_RGBF16LE,
        AV_PIX_FMT_RGBA128BE,
        AV_PIX_FMT_RGBA128LE,
        AV_PIX_FMT_RGB96BE,
        AV_PIX_FMT_RGB96LE,
        AV_PIX_FMT_Y216BE,
        AV_PIX_FMT_Y216LE,
        AV_PIX_FMT_XV48BE,
        AV_PIX_FMT_XV48LE,
        AV_PIX_FMT_GBRPF16BE,
        AV_PIX_FMT_GBRPF16LE,
        AV_PIX_FMT_GBRAPF16BE,
        AV_PIX_FMT_GBRAPF16LE,
        AV_PIX_FMT_GRAYF16BE,
        AV_PIX_FMT_GRAYF16LE,
        AV_PIX_FMT_AMF_SURFACE,
        AV_PIX_FMT_GRAY32BE,
        AV_PIX_FMT_GRAY32LE,
        AV_PIX_FMT_YAF32BE,
        AV_PIX_FMT_YAF32LE,
        AV_PIX_FMT_YAF16BE,
        AV_PIX_FMT_YAF16LE,
        AV_PIX_FMT_GBRAP32BE,
        AV_PIX_FMT_GBRAP32LE,
        AV_PIX_FMT_YUV444P10MSBBE,
        AV_PIX_FMT_YUV444P10MSBLE,
        AV_PIX_FMT_YUV444P12MSBBE,
        AV_PIX_FMT_YUV444P12MSBLE,
        AV_PIX_FMT_GBRP10MSBBE,
        AV_PIX_FMT_GBRP10MSBLE,
        AV_PIX_FMT_GBRP12MSBBE,
        AV_PIX_FMT_GBRP12MSBLE,
        AV_PIX_FMT_OHCODEC,
        AV_PIX_FMT_NB,
    }

    public enum AVColorPrimaries
    {
        AVCOL_PRI_RESERVED0 = 0,
        AVCOL_PRI_BT709 = 1,
        AVCOL_PRI_UNSPECIFIED = 2,
        AVCOL_PRI_RESERVED = 3,
        AVCOL_PRI_BT470M = 4,
        AVCOL_PRI_BT470BG = 5,
        AVCOL_PRI_SMPTE170M = 6,
        AVCOL_PRI_SMPTE240M = 7,
        AVCOL_PRI_FILM = 8,
        AVCOL_PRI_BT2020 = 9,
        AVCOL_PRI_SMPTE428 = 10,
        AVCOL_PRI_SMPTEST428_1 = AVCOL_PRI_SMPTE428,
        AVCOL_PRI_SMPTE431 = 11,
        AVCOL_PRI_SMPTE432 = 12,
        AVCOL_PRI_EBU3213 = 22,
        AVCOL_PRI_JEDEC_P22 = AVCOL_PRI_EBU3213,
        AVCOL_PRI_NB,
        AVCOL_PRI_EXT_BASE = 256,
        AVCOL_PRI_V_GAMUT = AVCOL_PRI_EXT_BASE,
        AVCOL_PRI_EXT_NB,
    }

    public enum AVColorTransferCharacteristic
    {
        AVCOL_TRC_RESERVED0 = 0,
        AVCOL_TRC_BT709 = 1,
        AVCOL_TRC_UNSPECIFIED = 2,
        AVCOL_TRC_RESERVED = 3,
        AVCOL_TRC_GAMMA22 = 4,
        AVCOL_TRC_GAMMA28 = 5,
        AVCOL_TRC_SMPTE170M = 6,
        AVCOL_TRC_SMPTE240M = 7,
        AVCOL_TRC_LINEAR = 8,
        AVCOL_TRC_LOG = 9,
        AVCOL_TRC_LOG_SQRT = 10,
        AVCOL_TRC_IEC61966_2_4 = 11,
        AVCOL_TRC_BT1361_ECG = 12,
        AVCOL_TRC_IEC61966_2_1 = 13,
        AVCOL_TRC_BT2020_10 = 14,
        AVCOL_TRC_BT2020_12 = 15,
        AVCOL_TRC_SMPTE2084 = 16,
        AVCOL_TRC_SMPTEST2084 = AVCOL_TRC_SMPTE2084,
        AVCOL_TRC_SMPTE428 = 17,
        AVCOL_TRC_SMPTEST428_1 = AVCOL_TRC_SMPTE428,
        AVCOL_TRC_ARIB_STD_B67 = 18,
        AVCOL_TRC_NB,
        AVCOL_TRC_EXT_BASE = 256,
        AVCOL_TRC_V_LOG = AVCOL_TRC_EXT_BASE,
        AVCOL_TRC_EXT_NB,
    }

    public enum AVColorSpace
    {
        AVCOL_SPC_RGB = 0,
        AVCOL_SPC_BT709 = 1,
        AVCOL_SPC_UNSPECIFIED = 2,
        AVCOL_SPC_RESERVED = 3,
        AVCOL_SPC_FCC = 4,
        AVCOL_SPC_BT470BG = 5,
        AVCOL_SPC_SMPTE170M = 6,
        AVCOL_SPC_SMPTE240M = 7,
        AVCOL_SPC_YCGCO = 8,
        AVCOL_SPC_YCOCG = AVCOL_SPC_YCGCO,
        AVCOL_SPC_BT2020_NCL = 9,
        AVCOL_SPC_BT2020_CL = 10,
        AVCOL_SPC_SMPTE2085 = 11,
        AVCOL_SPC_CHROMA_DERIVED_NCL = 12,
        AVCOL_SPC_CHROMA_DERIVED_CL = 13,
        AVCOL_SPC_ICTCP = 14,
        AVCOL_SPC_IPT_C2 = 15,
        AVCOL_SPC_YCGCO_RE = 16,
        AVCOL_SPC_YCGCO_RO = 17,
        AVCOL_SPC_NB,
    }

    public enum AVColorRange
    {
        AVCOL_RANGE_UNSPECIFIED = 0,
        AVCOL_RANGE_MPEG = 1,
        AVCOL_RANGE_JPEG = 2,
        AVCOL_RANGE_NB,
    }

    public enum AVChromaLocation
    {
        AVCHROMA_LOC_UNSPECIFIED = 0,
        AVCHROMA_LOC_LEFT = 1,
        AVCHROMA_LOC_CENTER = 2,
        AVCHROMA_LOC_TOPLEFT = 3,
        AVCHROMA_LOC_TOP = 4,
        AVCHROMA_LOC_BOTTOMLEFT = 5,
        AVCHROMA_LOC_BOTTOM = 6,
        AVCHROMA_LOC_NB,
    }

    public enum AVAlphaMode
    {
        AVALPHA_MODE_UNSPECIFIED = 0,
        AVALPHA_MODE_PREMULTIPLIED = 1,
        AVALPHA_MODE_STRAIGHT = 2,
        AVALPHA_MODE_NB,
    }

    public partial struct AVRational
    {
        public int num;

        public int den;
    }

    public enum AVHWDeviceType
    {
        AV_HWDEVICE_TYPE_NONE,
        AV_HWDEVICE_TYPE_VDPAU,
        AV_HWDEVICE_TYPE_CUDA,
        AV_HWDEVICE_TYPE_VAAPI,
        AV_HWDEVICE_TYPE_DXVA2,
        AV_HWDEVICE_TYPE_QSV,
        AV_HWDEVICE_TYPE_VIDEOTOOLBOX,
        AV_HWDEVICE_TYPE_D3D11VA,
        AV_HWDEVICE_TYPE_DRM,
        AV_HWDEVICE_TYPE_OPENCL,
        AV_HWDEVICE_TYPE_MEDIACODEC,
        AV_HWDEVICE_TYPE_VULKAN,
        AV_HWDEVICE_TYPE_D3D12VA,
        AV_HWDEVICE_TYPE_AMF,
        AV_HWDEVICE_TYPE_OHCODEC,
    }

    public unsafe partial struct AVHWDeviceContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("enum AVHWDeviceType")]
        public AVHWDeviceType type;

        public void* hwctx;

        [NativeTypeName("void (*)(struct AVHWDeviceContext *)")]
        public delegate* unmanaged[Cdecl]<AVHWDeviceContext*, void> free;

        public void* user_opaque;
    }

    public unsafe partial struct AVHWFramesContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public AVBufferRef* device_ref;

        public AVHWDeviceContext* device_ctx;

        public void* hwctx;

        [NativeTypeName("void (*)(struct AVHWFramesContext *)")]
        public delegate* unmanaged[Cdecl]<AVHWFramesContext*, void> free;

        public void* user_opaque;

        public AVBufferPool* pool;

        public int initial_pool_size;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat format;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat sw_format;

        public int width;

        public int height;
    }

    public enum AVHWFrameTransferDirection
    {
        AV_HWFRAME_TRANSFER_DIRECTION_FROM,
        AV_HWFRAME_TRANSFER_DIRECTION_TO,
    }

    public unsafe partial struct AVHWFramesConstraints
    {
        [NativeTypeName("enum AVPixelFormat *")]
        public AVPixelFormat* valid_hw_formats;

        [NativeTypeName("enum AVPixelFormat *")]
        public AVPixelFormat* valid_sw_formats;

        public int min_width;

        public int min_height;

        public int max_width;

        public int max_height;
    }

    public enum AV_HWFRAME_MAP
    {
        AV_HWFRAME_MAP_READ = 1 << 0,
        AV_HWFRAME_MAP_WRITE = 1 << 1,
        AV_HWFRAME_MAP_OVERWRITE = 1 << 2,
        AV_HWFRAME_MAP_DIRECT = 1 << 3,
    }

    public partial struct AVComponentDescriptor
    {
        public int plane;

        public int step;

        public int offset;

        public int shift;

        public int depth;
    }

    public unsafe partial struct AVPixFmtDescriptor
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("uint8_t")]
        public byte nb_components;

        [NativeTypeName("uint8_t")]
        public byte log2_chroma_w;

        [NativeTypeName("uint8_t")]
        public byte log2_chroma_h;

        [NativeTypeName("uint64_t")]
        public ulong flags;

        [NativeTypeName("AVComponentDescriptor[4]")]
        public _comp_e__FixedBuffer comp;

        [NativeTypeName("const char *")]
        public sbyte* alias;

        [InlineArray(4)]
        public partial struct _comp_e__FixedBuffer
        {
            public AVComponentDescriptor e0;
        }
    }

    public static unsafe partial class Methods
    {
        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct AVAES *")]
        public static extern AVAES* av_aes_alloc();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_aes_init([NativeTypeName("struct AVAES *")] AVAES* a, [NativeTypeName("const uint8_t *")] byte* key, int key_bits, int decrypt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_aes_crypt([NativeTypeName("struct AVAES *")] AVAES* a, [NativeTypeName("uint8_t *")] byte* dst, [NativeTypeName("const uint8_t *")] byte* src, int count, [NativeTypeName("uint8_t *")] byte* iv, int decrypt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct AVAESCTR *")]
        public static extern AVAESCTR* av_aes_ctr_alloc();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_aes_ctr_init([NativeTypeName("struct AVAESCTR *")] AVAESCTR* a, [NativeTypeName("const uint8_t *")] byte* key);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_aes_ctr_free([NativeTypeName("struct AVAESCTR *")] AVAESCTR* a);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_aes_ctr_crypt([NativeTypeName("struct AVAESCTR *")] AVAESCTR* a, [NativeTypeName("uint8_t *")] byte* dst, [NativeTypeName("const uint8_t *")] byte* src, int size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const uint8_t *")]
        public static extern byte* av_aes_ctr_get_iv([NativeTypeName("struct AVAESCTR *")] AVAESCTR* a);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_aes_ctr_set_random_iv([NativeTypeName("struct AVAESCTR *")] AVAESCTR* a);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_aes_ctr_set_iv([NativeTypeName("struct AVAESCTR *")] AVAESCTR* a, [NativeTypeName("const uint8_t *")] byte* iv);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_aes_ctr_set_full_iv([NativeTypeName("struct AVAESCTR *")] AVAESCTR* a, [NativeTypeName("const uint8_t *")] byte* iv);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_aes_ctr_increment_iv([NativeTypeName("struct AVAESCTR *")] AVAESCTR* a);

        [NativeTypeName("#define AES_CTR_KEY_SIZE (16)")]
        public const int AES_CTR_KEY_SIZE = (16);

        [NativeTypeName("#define AES_CTR_IV_SIZE (8)")]
        public const int AES_CTR_IV_SIZE = (8);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avutil_version();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_version_info();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avutil_configuration();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avutil_license();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_get_media_type_string([NativeTypeName("enum AVMediaType")] AVMediaType media_type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char")]
        public static extern sbyte av_get_picture_type_char([NativeTypeName("enum AVPictureType")] AVPictureType pict_type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_get_time_base_q();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* av_fourcc_make_string([NativeTypeName("char *")] sbyte* buf, [NativeTypeName("uint32_t")] uint fourcc);

        [NativeTypeName("#define FF_LAMBDA_SHIFT 7")]
        public const int FF_LAMBDA_SHIFT = 7;

        [NativeTypeName("#define FF_LAMBDA_SCALE (1<<FF_LAMBDA_SHIFT)")]
        public const int FF_LAMBDA_SCALE = (1 << 7);

        [NativeTypeName("#define FF_QP2LAMBDA 118")]
        public const int FF_QP2LAMBDA = 118;

        [NativeTypeName("#define FF_LAMBDA_MAX (256*128-1)")]
        public const int FF_LAMBDA_MAX = (256 * 128 - 1);

        [NativeTypeName("#define FF_QUALITY_SCALE FF_LAMBDA_SCALE")]
        public const int FF_QUALITY_SCALE = (1 << 7);

        [NativeTypeName("#define AV_NOPTS_VALUE ((int64_t)UINT64_C(0x8000000000000000))")]
        public const long AV_NOPTS_VALUE = unchecked((long)(0x8000000000000000UL));

        [NativeTypeName("#define AV_TIME_BASE 1000000")]
        public const int AV_TIME_BASE = 1000000;

        [NativeTypeName("#define AV_FOURCC_MAX_STRING_SIZE 32")]
        public const int AV_FOURCC_MAX_STRING_SIZE = 32;

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_get_sample_fmt_name([NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVSampleFormat")]
        public static extern AVSampleFormat av_get_sample_fmt([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVSampleFormat")]
        public static extern AVSampleFormat av_get_alt_sample_fmt([NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt, int planar);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVSampleFormat")]
        public static extern AVSampleFormat av_get_packed_sample_fmt([NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVSampleFormat")]
        public static extern AVSampleFormat av_get_planar_sample_fmt([NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* av_get_sample_fmt_string([NativeTypeName("char *")] sbyte* buf, int buf_size, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_bytes_per_sample([NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_sample_fmt_is_planar([NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_samples_get_buffer_size(int* linesize, int nb_channels, int nb_samples, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_samples_fill_arrays([NativeTypeName("uint8_t **")] byte** audio_data, int* linesize, [NativeTypeName("const uint8_t *")] byte* buf, int nb_channels, int nb_samples, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_samples_alloc([NativeTypeName("uint8_t **")] byte** audio_data, int* linesize, int nb_channels, int nb_samples, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_samples_alloc_array_and_samples([NativeTypeName("uint8_t ***")] byte*** audio_data, int* linesize, int nb_channels, int nb_samples, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_samples_copy([NativeTypeName("uint8_t *const *")] byte** dst, [NativeTypeName("uint8_t *const *")] byte** src, int dst_offset, int src_offset, int nb_samples, int nb_channels, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_samples_set_silence([NativeTypeName("uint8_t *const *")] byte** audio_data, int offset, int nb_samples, int nb_channels, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_alloc([NativeTypeName("size_t")] nuint size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_allocz([NativeTypeName("size_t")] nuint size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_create([NativeTypeName("uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size, [NativeTypeName("void (*)(void *, uint8_t *)")] delegate* unmanaged[Cdecl]<void*, byte*, void> free, void* opaque, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_buffer_default_free(void* opaque, [NativeTypeName("uint8_t *")] byte* data);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_ref([NativeTypeName("const AVBufferRef *")] AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_buffer_unref(AVBufferRef** buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_is_writable([NativeTypeName("const AVBufferRef *")] AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* av_buffer_get_opaque([NativeTypeName("const AVBufferRef *")] AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_get_ref_count([NativeTypeName("const AVBufferRef *")] AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_make_writable(AVBufferRef** buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_realloc(AVBufferRef** buf, [NativeTypeName("size_t")] nuint size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_replace(AVBufferRef** dst, [NativeTypeName("const AVBufferRef *")] AVBufferRef* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferPool* av_buffer_pool_init([NativeTypeName("size_t")] nuint size, [NativeTypeName("AVBufferRef *(*)(size_t)")] delegate* unmanaged[Cdecl]<nuint, AVBufferRef*> alloc);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferPool* av_buffer_pool_init2([NativeTypeName("size_t")] nuint size, void* opaque, [NativeTypeName("AVBufferRef *(*)(void *, size_t)")] delegate* unmanaged[Cdecl]<void*, nuint, AVBufferRef*> alloc, [NativeTypeName("void (*)(void *)")] delegate* unmanaged[Cdecl]<void*, void> pool_free);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_buffer_pool_uninit(AVBufferPool** pool);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_pool_get(AVBufferPool* pool);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* av_buffer_pool_buffer_get_opaque([NativeTypeName("const AVBufferRef *")] AVBufferRef* @ref);

        [NativeTypeName("#define AV_BUFFER_FLAG_READONLY (1 << 0)")]
        public const int AV_BUFFER_FLAG_READONLY = (1 << 0);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_opt_set_defaults(void* s);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_opt_set_defaults2(void* s, int mask, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_opt_free(void* obj);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVOption *")]
        public static extern AVOption* av_opt_next([NativeTypeName("const void *")] void* obj, [NativeTypeName("const AVOption *")] AVOption* prev);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* av_opt_child_next(void* obj, void* prev);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* av_opt_child_class_iterate([NativeTypeName("const AVClass *")] AVClass* parent, void** iter);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVOption *")]
        public static extern AVOption* av_opt_find(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* unit, int opt_flags, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVOption *")]
        public static extern AVOption* av_opt_find2(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* unit, int opt_flags, int search_flags, void** target_obj);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_show2(void* obj, void* av_log_obj, int req_flags, int rej_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_key_value([NativeTypeName("const char **")] sbyte** ropts, [NativeTypeName("const char *")] sbyte* key_val_sep, [NativeTypeName("const char *")] sbyte* pairs_sep, [NativeTypeName("unsigned int")] uint flags, [NativeTypeName("char **")] sbyte** rkey, [NativeTypeName("char **")] sbyte** rval);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_set_options_string(void* ctx, [NativeTypeName("const char *")] sbyte* opts, [NativeTypeName("const char *")] sbyte* key_val_sep, [NativeTypeName("const char *")] sbyte* pairs_sep);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_from_string(void* ctx, [NativeTypeName("const char *")] sbyte* opts, [NativeTypeName("const char *const *")] sbyte** shorthand, [NativeTypeName("const char *")] sbyte* key_val_sep, [NativeTypeName("const char *")] sbyte* pairs_sep);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_dict(void* obj, [NativeTypeName("struct AVDictionary **")] AVDictionary** options);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_dict2(void* obj, [NativeTypeName("struct AVDictionary **")] AVDictionary** options, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_copy(void* dest, [NativeTypeName("const void *")] void* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* val, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_int(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("int64_t")] long val, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_double(void* obj, [NativeTypeName("const char *")] sbyte* name, double val, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_q(void* obj, [NativeTypeName("const char *")] sbyte* name, AVRational val, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_bin(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const uint8_t *")] byte* val, int size, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_image_size(void* obj, [NativeTypeName("const char *")] sbyte* name, int w, int h, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_pixel_fmt(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat fmt, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_sample_fmt(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat fmt, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_video_rate(void* obj, [NativeTypeName("const char *")] sbyte* name, AVRational val, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_chlayout(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const AVChannelLayout *")] AVChannelLayout* layout, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_dict_val(void* obj, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const AVDictionary *")] AVDictionary* val, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_set_array(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, [NativeTypeName("unsigned int")] uint start_elem, [NativeTypeName("unsigned int")] uint nb_elems, [NativeTypeName("enum AVOptionType")] AVOptionType val_type, [NativeTypeName("const void *")] void* val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, [NativeTypeName("uint8_t **")] byte** out_val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_int(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, [NativeTypeName("int64_t *")] long* out_val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_double(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, double* out_val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_q(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, AVRational* out_val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_image_size(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, int* w_out, int* h_out);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_pixel_fmt(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, [NativeTypeName("enum AVPixelFormat *")] AVPixelFormat* out_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_sample_fmt(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, [NativeTypeName("enum AVSampleFormat *")] AVSampleFormat* out_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_video_rate(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, AVRational* out_val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_chlayout(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, AVChannelLayout* layout);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_dict_val(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, AVDictionary** out_val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_array_size(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, [NativeTypeName("unsigned int *")] uint* out_val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_get_array(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags, [NativeTypeName("unsigned int")] uint start_elem, [NativeTypeName("unsigned int")] uint nb_elems, [NativeTypeName("enum AVOptionType")] AVOptionType out_type, void* out_val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_eval_flags(void* obj, [NativeTypeName("const AVOption *")] AVOption* o, [NativeTypeName("const char *")] sbyte* val, int* flags_out);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_eval_int(void* obj, [NativeTypeName("const AVOption *")] AVOption* o, [NativeTypeName("const char *")] sbyte* val, int* int_out);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_eval_uint(void* obj, [NativeTypeName("const AVOption *")] AVOption* o, [NativeTypeName("const char *")] sbyte* val, [NativeTypeName("unsigned int *")] uint* uint_out);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_eval_int64(void* obj, [NativeTypeName("const AVOption *")] AVOption* o, [NativeTypeName("const char *")] sbyte* val, [NativeTypeName("int64_t *")] long* int64_out);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_eval_float(void* obj, [NativeTypeName("const AVOption *")] AVOption* o, [NativeTypeName("const char *")] sbyte* val, float* float_out);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_eval_double(void* obj, [NativeTypeName("const AVOption *")] AVOption* o, [NativeTypeName("const char *")] sbyte* val, double* double_out);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_eval_q(void* obj, [NativeTypeName("const AVOption *")] AVOption* o, [NativeTypeName("const char *")] sbyte* val, AVRational* q_out);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void* av_opt_ptr([NativeTypeName("const AVClass *")] AVClass* avclass, void* obj, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_is_set_to_default(void* obj, [NativeTypeName("const AVOption *")] AVOption* o);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_is_set_to_default_by_name(void* obj, [NativeTypeName("const char *")] sbyte* name, int search_flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_flag_is_set(void* obj, [NativeTypeName("const char *")] sbyte* field_name, [NativeTypeName("const char *")] sbyte* flag_name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_serialize(void* obj, int opt_flags, int flags, [NativeTypeName("char **")] sbyte** buffer, [NativeTypeName("const char")] sbyte key_val_sep, [NativeTypeName("const char")] sbyte pairs_sep);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_opt_freep_ranges(AVOptionRanges** ranges);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_query_ranges(AVOptionRanges** param0, void* obj, [NativeTypeName("const char *")] sbyte* key, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_opt_query_ranges_default(AVOptionRanges** param0, void* obj, [NativeTypeName("const char *")] sbyte* key, int flags);

        [NativeTypeName("#define AV_OPT_FLAG_ENCODING_PARAM (1 << 0)")]
        public const int AV_OPT_FLAG_ENCODING_PARAM = (1 << 0);

        [NativeTypeName("#define AV_OPT_FLAG_DECODING_PARAM (1 << 1)")]
        public const int AV_OPT_FLAG_DECODING_PARAM = (1 << 1);

        [NativeTypeName("#define AV_OPT_FLAG_AUDIO_PARAM (1 << 3)")]
        public const int AV_OPT_FLAG_AUDIO_PARAM = (1 << 3);

        [NativeTypeName("#define AV_OPT_FLAG_VIDEO_PARAM (1 << 4)")]
        public const int AV_OPT_FLAG_VIDEO_PARAM = (1 << 4);

        [NativeTypeName("#define AV_OPT_FLAG_SUBTITLE_PARAM (1 << 5)")]
        public const int AV_OPT_FLAG_SUBTITLE_PARAM = (1 << 5);

        [NativeTypeName("#define AV_OPT_FLAG_EXPORT (1 << 6)")]
        public const int AV_OPT_FLAG_EXPORT = (1 << 6);

        [NativeTypeName("#define AV_OPT_FLAG_READONLY (1 << 7)")]
        public const int AV_OPT_FLAG_READONLY = (1 << 7);

        [NativeTypeName("#define AV_OPT_FLAG_BSF_PARAM (1 << 8)")]
        public const int AV_OPT_FLAG_BSF_PARAM = (1 << 8);

        [NativeTypeName("#define AV_OPT_FLAG_RUNTIME_PARAM (1 << 15)")]
        public const int AV_OPT_FLAG_RUNTIME_PARAM = (1 << 15);

        [NativeTypeName("#define AV_OPT_FLAG_FILTERING_PARAM (1 << 16)")]
        public const int AV_OPT_FLAG_FILTERING_PARAM = (1 << 16);

        [NativeTypeName("#define AV_OPT_FLAG_DEPRECATED (1 << 17)")]
        public const int AV_OPT_FLAG_DEPRECATED = (1 << 17);

        [NativeTypeName("#define AV_OPT_FLAG_CHILD_CONSTS (1 << 18)")]
        public const int AV_OPT_FLAG_CHILD_CONSTS = (1 << 18);

        [NativeTypeName("#define AV_OPT_SEARCH_CHILDREN (1 << 0)")]
        public const int AV_OPT_SEARCH_CHILDREN = (1 << 0);

        [NativeTypeName("#define AV_OPT_SEARCH_FAKE_OBJ (1 << 1)")]
        public const int AV_OPT_SEARCH_FAKE_OBJ = (1 << 1);

        [NativeTypeName("#define AV_OPT_ALLOW_NULL (1 << 2)")]
        public const int AV_OPT_ALLOW_NULL = (1 << 2);

        [NativeTypeName("#define AV_OPT_ARRAY_REPLACE (1 << 3)")]
        public const int AV_OPT_ARRAY_REPLACE = (1 << 3);

        [NativeTypeName("#define AV_OPT_MULTI_COMPONENT_RANGE (1 << 12)")]
        public const int AV_OPT_MULTI_COMPONENT_RANGE = (1 << 12);

        [NativeTypeName("#define AV_OPT_SERIALIZE_SKIP_DEFAULTS 0x00000001")]
        public const int AV_OPT_SERIALIZE_SKIP_DEFAULTS = 0x00000001;

        [NativeTypeName("#define AV_OPT_SERIALIZE_OPT_FLAGS_EXACT 0x00000002")]
        public const int AV_OPT_SERIALIZE_OPT_FLAGS_EXACT = 0x00000002;

        [NativeTypeName("#define AV_OPT_SERIALIZE_SEARCH_CHILDREN 0x00000004")]
        public const int AV_OPT_SERIALIZE_SEARCH_CHILDREN = 0x00000004;

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_name([NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("enum AVChannel")] AVChannel channel);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_channel_name_bprint([NativeTypeName("struct AVBPrint *")] AVBPrint* bp, [NativeTypeName("enum AVChannel")] AVChannel channel_id);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_description([NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("enum AVChannel")] AVChannel channel);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_channel_description_bprint([NativeTypeName("struct AVBPrint *")] AVBPrint* bp, [NativeTypeName("enum AVChannel")] AVChannel channel_id);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVChannel")]
        public static extern AVChannel av_channel_from_string([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_custom_init(AVChannelLayout* channel_layout, int nb_channels);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_from_mask(AVChannelLayout* channel_layout, [NativeTypeName("uint64_t")] ulong mask);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_from_string(AVChannelLayout* channel_layout, [NativeTypeName("const char *")] sbyte* str);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_channel_layout_default(AVChannelLayout* ch_layout, int nb_channels);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVChannelLayout *")]
        public static extern AVChannelLayout* av_channel_layout_standard(void** opaque);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_channel_layout_uninit(AVChannelLayout* channel_layout);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_copy(AVChannelLayout* dst, [NativeTypeName("const AVChannelLayout *")] AVChannelLayout* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_describe([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("size_t")] nuint buf_size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_describe_bprint([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout, [NativeTypeName("struct AVBPrint *")] AVBPrint* bp);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVChannel")]
        public static extern AVChannel av_channel_layout_channel_from_index([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout, [NativeTypeName("unsigned int")] uint idx);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_index_from_channel([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout, [NativeTypeName("enum AVChannel")] AVChannel channel);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_index_from_string([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVChannel")]
        public static extern AVChannel av_channel_layout_channel_from_string([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong av_channel_layout_subset([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout, [NativeTypeName("uint64_t")] ulong mask);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_check([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_compare([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* chl, [NativeTypeName("const AVChannelLayout *")] AVChannelLayout* chl1);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_ambisonic_order([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* channel_layout);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_channel_layout_retype(AVChannelLayout* channel_layout, [NativeTypeName("enum AVChannelOrder")] AVChannelOrder order, int flags);

        [NativeTypeName("#define AV_CHANNEL_LAYOUT_RETYPE_FLAG_LOSSLESS (1 << 0)")]
        public const int AV_CHANNEL_LAYOUT_RETYPE_FLAG_LOSSLESS = (1 << 0);

        [NativeTypeName("#define AV_CHANNEL_LAYOUT_RETYPE_FLAG_CANONICAL (1 << 1)")]
        public const int AV_CHANNEL_LAYOUT_RETYPE_FLAG_CANONICAL = (1 << 1);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVDictionaryEntry* av_dict_get([NativeTypeName("const AVDictionary *")] AVDictionary* m, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const AVDictionaryEntry *")] AVDictionaryEntry* prev, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVDictionaryEntry *")]
        public static extern AVDictionaryEntry* av_dict_iterate([NativeTypeName("const AVDictionary *")] AVDictionary* m, [NativeTypeName("const AVDictionaryEntry *")] AVDictionaryEntry* prev);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_count([NativeTypeName("const AVDictionary *")] AVDictionary* m);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_set(AVDictionary** pm, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_set_int(AVDictionary** pm, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("int64_t")] long value, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_parse_string(AVDictionary** pm, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* key_val_sep, [NativeTypeName("const char *")] sbyte* pairs_sep, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_copy(AVDictionary** dst, [NativeTypeName("const AVDictionary *")] AVDictionary* src, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_dict_free(AVDictionary** m);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_get_string([NativeTypeName("const AVDictionary *")] AVDictionary* m, [NativeTypeName("char **")] sbyte** buffer, [NativeTypeName("const char")] sbyte key_val_sep, [NativeTypeName("const char")] sbyte pairs_sep);

        [NativeTypeName("#define AV_DICT_MATCH_CASE 1")]
        public const int AV_DICT_MATCH_CASE = 1;

        [NativeTypeName("#define AV_DICT_IGNORE_SUFFIX 2")]
        public const int AV_DICT_IGNORE_SUFFIX = 2;

        [NativeTypeName("#define AV_DICT_DONT_STRDUP_KEY 4")]
        public const int AV_DICT_DONT_STRDUP_KEY = 4;

        [NativeTypeName("#define AV_DICT_DONT_STRDUP_VAL 8")]
        public const int AV_DICT_DONT_STRDUP_VAL = 8;

        [NativeTypeName("#define AV_DICT_DONT_OVERWRITE 16")]
        public const int AV_DICT_DONT_OVERWRITE = 16;

        [NativeTypeName("#define AV_DICT_APPEND 32")]
        public const int AV_DICT_APPEND = 32;

        [NativeTypeName("#define AV_DICT_MULTIKEY 64")]
        public const int AV_DICT_MULTIKEY = 64;

        [NativeTypeName("#define AV_DICT_DEDUP 128")]
        public const int AV_DICT_DEDUP = 128;

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrame* av_frame_alloc();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_free(AVFrame** frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_ref(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_replace(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrame* av_frame_clone([NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_unref(AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_move_ref(AVFrame* dst, AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_get_buffer(AVFrame* frame, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_is_writable(AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_make_writable(AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_copy(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_copy_props(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_frame_get_plane_buffer([NativeTypeName("const AVFrame *")] AVFrame* frame, int plane);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrameSideData* av_frame_new_side_data(AVFrame* frame, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type, [NativeTypeName("size_t")] nuint size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrameSideData* av_frame_new_side_data_from_buf(AVFrame* frame, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type, AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrameSideData* av_frame_get_side_data([NativeTypeName("const AVFrame *")] AVFrame* frame, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_remove_side_data(AVFrame* frame, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_apply_cropping(AVFrame* frame, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_frame_side_data_name([NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVSideDataDescriptor *")]
        public static extern AVSideDataDescriptor* av_frame_side_data_desc([NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_side_data_free(AVFrameSideData*** sd, int* nb_sd);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrameSideData* av_frame_side_data_new(AVFrameSideData*** sd, int* nb_sd, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type, [NativeTypeName("size_t")] nuint size, [NativeTypeName("unsigned int")] uint flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrameSideData* av_frame_side_data_add(AVFrameSideData*** sd, int* nb_sd, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type, AVBufferRef** buf, [NativeTypeName("unsigned int")] uint flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_side_data_clone(AVFrameSideData*** sd, int* nb_sd, [NativeTypeName("const AVFrameSideData *")] AVFrameSideData* src, [NativeTypeName("unsigned int")] uint flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVFrameSideData *")]
        public static extern AVFrameSideData* av_frame_side_data_get_c([NativeTypeName("const AVFrameSideData *const *")] AVFrameSideData** sd, [NativeTypeName("const int")] int nb_sd, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_side_data_remove(AVFrameSideData*** sd, int* nb_sd, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_side_data_remove_by_props(AVFrameSideData*** sd, int* nb_sd, int props);

        [NativeTypeName("#define AV_NUM_DATA_POINTERS 8")]
        public const int AV_NUM_DATA_POINTERS = 8;

        [NativeTypeName("#define AV_FRAME_FLAG_CORRUPT (1 << 0)")]
        public const int AV_FRAME_FLAG_CORRUPT = (1 << 0);

        [NativeTypeName("#define AV_FRAME_FLAG_KEY (1 << 1)")]
        public const int AV_FRAME_FLAG_KEY = (1 << 1);

        [NativeTypeName("#define AV_FRAME_FLAG_DISCARD (1 << 2)")]
        public const int AV_FRAME_FLAG_DISCARD = (1 << 2);

        [NativeTypeName("#define AV_FRAME_FLAG_INTERLACED (1 << 3)")]
        public const int AV_FRAME_FLAG_INTERLACED = (1 << 3);

        [NativeTypeName("#define AV_FRAME_FLAG_TOP_FIELD_FIRST (1 << 4)")]
        public const int AV_FRAME_FLAG_TOP_FIELD_FIRST = (1 << 4);

        [NativeTypeName("#define AV_FRAME_FLAG_LOSSLESS (1 << 5)")]
        public const int AV_FRAME_FLAG_LOSSLESS = (1 << 5);

        [NativeTypeName("#define FF_DECODE_ERROR_INVALID_BITSTREAM 1")]
        public const int FF_DECODE_ERROR_INVALID_BITSTREAM = 1;

        [NativeTypeName("#define FF_DECODE_ERROR_MISSING_REFERENCE 2")]
        public const int FF_DECODE_ERROR_MISSING_REFERENCE = 2;

        [NativeTypeName("#define FF_DECODE_ERROR_CONCEALMENT_ACTIVE 4")]
        public const int FF_DECODE_ERROR_CONCEALMENT_ACTIVE = 4;

        [NativeTypeName("#define FF_DECODE_ERROR_DECODE_SLICES 8")]
        public const int FF_DECODE_ERROR_DECODE_SLICES = 8;

        [NativeTypeName("#define AV_FRAME_SIDE_DATA_FLAG_UNIQUE (1 << 0)")]
        public const int AV_FRAME_SIDE_DATA_FLAG_UNIQUE = (1 << 0);

        [NativeTypeName("#define AV_FRAME_SIDE_DATA_FLAG_REPLACE (1 << 1)")]
        public const int AV_FRAME_SIDE_DATA_FLAG_REPLACE = (1 << 1);

        [NativeTypeName("#define AV_FRAME_SIDE_DATA_FLAG_NEW_REF (1 << 2)")]
        public const int AV_FRAME_SIDE_DATA_FLAG_NEW_REF = (1 << 2);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_vlog(void* avcl, int level, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* vl);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_log_get_level();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_log_set_level(int level);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_log_set_callback([NativeTypeName("void (*)(void *, int, const char *, va_list)")] delegate* unmanaged[Cdecl]<void*, int, sbyte*, sbyte*, void> callback);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_log_default_callback(void* avcl, int level, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* vl);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_default_item_name(void* ctx);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVClassCategory av_default_get_category(void* ptr);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_log_format_line(void* ptr, int level, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* vl, [NativeTypeName("char *")] sbyte* line, int line_size, int* print_prefix);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_log_format_line2(void* ptr, int level, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* vl, [NativeTypeName("char *")] sbyte* line, int line_size, int* print_prefix);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_log_set_flags(int arg);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_log_get_flags();

        [NativeTypeName("#define AV_LOG_QUIET -8")]
        public const int AV_LOG_QUIET = -8;

        [NativeTypeName("#define AV_LOG_PANIC 0")]
        public const int AV_LOG_PANIC = 0;

        [NativeTypeName("#define AV_LOG_FATAL 8")]
        public const int AV_LOG_FATAL = 8;

        [NativeTypeName("#define AV_LOG_ERROR 16")]
        public const int AV_LOG_ERROR = 16;

        [NativeTypeName("#define AV_LOG_WARNING 24")]
        public const int AV_LOG_WARNING = 24;

        [NativeTypeName("#define AV_LOG_INFO 32")]
        public const int AV_LOG_INFO = 32;

        [NativeTypeName("#define AV_LOG_VERBOSE 40")]
        public const int AV_LOG_VERBOSE = 40;

        [NativeTypeName("#define AV_LOG_DEBUG 48")]
        public const int AV_LOG_DEBUG = 48;

        [NativeTypeName("#define AV_LOG_TRACE 56")]
        public const int AV_LOG_TRACE = 56;

        [NativeTypeName("#define AV_LOG_MAX_OFFSET (AV_LOG_TRACE - AV_LOG_QUIET)")]
        public const int AV_LOG_MAX_OFFSET = unchecked(56 - -8);

        [NativeTypeName("#define AV_LOG_SKIP_REPEATED 1")]
        public const int AV_LOG_SKIP_REPEATED = 1;

        [NativeTypeName("#define AV_LOG_PRINT_LEVEL 2")]
        public const int AV_LOG_PRINT_LEVEL = 2;

        [NativeTypeName("#define AV_LOG_PRINT_TIME 4")]
        public const int AV_LOG_PRINT_TIME = 4;

        [NativeTypeName("#define AV_LOG_PRINT_DATETIME 8")]
        public const int AV_LOG_PRINT_DATETIME = 8;

        [NativeTypeName("#define AVPALETTE_SIZE 1024")]
        public const int AVPALETTE_SIZE = 1024;

        [NativeTypeName("#define AVPALETTE_COUNT 256")]
        public const int AVPALETTE_COUNT = 256;

        [NativeTypeName("#define AV_VIDEO_MAX_PLANES 4")]
        public const int AV_VIDEO_MAX_PLANES = 4;

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_reduce(int* dst_num, int* dst_den, [NativeTypeName("int64_t")] long num, [NativeTypeName("int64_t")] long den, [NativeTypeName("int64_t")] long max);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_mul_q(AVRational b, AVRational c);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_div_q(AVRational b, AVRational c);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_add_q(AVRational b, AVRational c);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_sub_q(AVRational b, AVRational c);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_d2q(double d, int max);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_nearer_q(AVRational q, AVRational q1, AVRational q2);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_find_nearest_q_idx(AVRational q, [NativeTypeName("const AVRational *")] AVRational* q_list);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint av_q2intfloat(AVRational q);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_gcd_q(AVRational a, AVRational b, int max_den, AVRational def);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_image_fill_max_pixsteps([NativeTypeName("int[4]")] int* max_pixsteps, [NativeTypeName("int[4]")] int* max_pixstep_comps, [NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* pixdesc);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_get_linesize([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int plane);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_fill_linesizes([NativeTypeName("int[4]")] int* linesizes, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_fill_plane_sizes([NativeTypeName("size_t[4]")] nuint* size, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int height, [NativeTypeName("const ptrdiff_t[4]")] nint* linesizes);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_fill_pointers([NativeTypeName("uint8_t *[4]")] byte** data, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int height, [NativeTypeName("uint8_t *")] byte* ptr, [NativeTypeName("const int[4]")] int* linesizes);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_alloc([NativeTypeName("uint8_t *[4]")] byte** pointers, [NativeTypeName("int[4]")] int* linesizes, int w, int h, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_image_copy_plane([NativeTypeName("uint8_t *")] byte* dst, int dst_linesize, [NativeTypeName("const uint8_t *")] byte* src, int src_linesize, int bytewidth, int height);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_image_copy_plane_uc_from([NativeTypeName("uint8_t *")] byte* dst, [NativeTypeName("ptrdiff_t")] nint dst_linesize, [NativeTypeName("const uint8_t *")] byte* src, [NativeTypeName("ptrdiff_t")] nint src_linesize, [NativeTypeName("ptrdiff_t")] nint bytewidth, int height);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_image_copy([NativeTypeName("uint8_t *const[4]")] byte** dst_data, [NativeTypeName("const int[4]")] int* dst_linesizes, [NativeTypeName("const uint8_t *const[4]")] byte** src_data, [NativeTypeName("const int[4]")] int* src_linesizes, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_image_copy_uc_from([NativeTypeName("uint8_t *const[4]")] byte** dst_data, [NativeTypeName("const ptrdiff_t[4]")] nint* dst_linesizes, [NativeTypeName("const uint8_t *const[4]")] byte** src_data, [NativeTypeName("const ptrdiff_t[4]")] nint* src_linesizes, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_fill_arrays([NativeTypeName("uint8_t *[4]")] byte** dst_data, [NativeTypeName("int[4]")] int* dst_linesize, [NativeTypeName("const uint8_t *")] byte* src, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_get_buffer_size([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_copy_to_buffer([NativeTypeName("uint8_t *")] byte* dst, int dst_size, [NativeTypeName("const uint8_t *const[4]")] byte** src_data, [NativeTypeName("const int[4]")] int* src_linesize, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_check_size([NativeTypeName("unsigned int")] uint w, [NativeTypeName("unsigned int")] uint h, int log_offset, void* log_ctx);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_check_size2([NativeTypeName("unsigned int")] uint w, [NativeTypeName("unsigned int")] uint h, [NativeTypeName("int64_t")] long max_pixels, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int log_offset, void* log_ctx);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_check_sar([NativeTypeName("unsigned int")] uint w, [NativeTypeName("unsigned int")] uint h, AVRational sar);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_fill_black([NativeTypeName("uint8_t *const[4]")] byte** dst_data, [NativeTypeName("const ptrdiff_t[4]")] nint* dst_linesize, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, [NativeTypeName("enum AVColorRange")] AVColorRange range, int width, int height);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_image_fill_color([NativeTypeName("uint8_t *const[4]")] byte** dst_data, [NativeTypeName("const ptrdiff_t[4]")] nint* dst_linesize, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, [NativeTypeName("const uint32_t[4]")] uint* color, int width, int height, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVHWDeviceType")]
        public static extern AVHWDeviceType av_hwdevice_find_type_by_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_hwdevice_get_type_name([NativeTypeName("enum AVHWDeviceType")] AVHWDeviceType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVHWDeviceType")]
        public static extern AVHWDeviceType av_hwdevice_iterate_types([NativeTypeName("enum AVHWDeviceType")] AVHWDeviceType prev);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_hwdevice_ctx_alloc([NativeTypeName("enum AVHWDeviceType")] AVHWDeviceType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwdevice_ctx_init(AVBufferRef* @ref);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwdevice_ctx_create(AVBufferRef** device_ctx, [NativeTypeName("enum AVHWDeviceType")] AVHWDeviceType type, [NativeTypeName("const char *")] sbyte* device, AVDictionary* opts, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwdevice_ctx_create_derived(AVBufferRef** dst_ctx, [NativeTypeName("enum AVHWDeviceType")] AVHWDeviceType type, AVBufferRef* src_ctx, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwdevice_ctx_create_derived_opts(AVBufferRef** dst_ctx, [NativeTypeName("enum AVHWDeviceType")] AVHWDeviceType type, AVBufferRef* src_ctx, AVDictionary* options, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_hwframe_ctx_alloc(AVBufferRef* device_ctx);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwframe_ctx_init(AVBufferRef* @ref);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwframe_get_buffer(AVBufferRef* hwframe_ctx, AVFrame* frame, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwframe_transfer_data(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwframe_transfer_get_formats(AVBufferRef* hwframe_ctx, [NativeTypeName("enum AVHWFrameTransferDirection")] AVHWFrameTransferDirection dir, [NativeTypeName("enum AVPixelFormat **")] AVPixelFormat** formats, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* av_hwdevice_hwconfig_alloc(AVBufferRef* device_ctx);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints(AVBufferRef* @ref, [NativeTypeName("const void *")] void* hwconfig);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_hwframe_constraints_free(AVHWFramesConstraints** constraints);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwframe_map(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_hwframe_ctx_create_derived(AVBufferRef** derived_frame_ctx, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat format, AVBufferRef* derived_device_ctx, AVBufferRef* source_frame_ctx, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_bits_per_pixel([NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* pixdesc);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_padded_bits_per_pixel([NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* pixdesc);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVPixFmtDescriptor *")]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_get([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVPixFmtDescriptor *")]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_next([NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* prev);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat av_pix_fmt_desc_get_id([NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* desc);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_pix_fmt_get_chroma_sub_sample([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int* h_shift, int* v_shift);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_pix_fmt_count_planes([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_color_range_name([NativeTypeName("enum AVColorRange")] AVColorRange range);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_color_range_from_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_color_primaries_name([NativeTypeName("enum AVColorPrimaries")] AVColorPrimaries primaries);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_color_primaries_from_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_color_transfer_name([NativeTypeName("enum AVColorTransferCharacteristic")] AVColorTransferCharacteristic transfer);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_color_transfer_from_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_color_space_name([NativeTypeName("enum AVColorSpace")] AVColorSpace space);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_color_space_from_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_chroma_location_name([NativeTypeName("enum AVChromaLocation")] AVChromaLocation location);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_chroma_location_from_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_chroma_location_enum_to_pos(int* xpos, int* ypos, [NativeTypeName("enum AVChromaLocation")] AVChromaLocation pos);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVChromaLocation")]
        public static extern AVChromaLocation av_chroma_location_pos_to_enum(int xpos, int ypos);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_alpha_mode_name([NativeTypeName("enum AVAlphaMode")] AVAlphaMode mode);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVAlphaMode")]
        public static extern AVAlphaMode av_alpha_mode_from_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat av_get_pix_fmt([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_get_pix_fmt_name([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* av_get_pix_fmt_string([NativeTypeName("char *")] sbyte* buf, int buf_size, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_read_image_line2(void* dst, [NativeTypeName("const uint8_t *[4]")] byte** data, [NativeTypeName("const int[4]")] int* linesize, [NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* desc, int x, int y, int c, int w, int read_pal_component, int dst_element_size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_read_image_line([NativeTypeName("uint16_t *")] ushort* dst, [NativeTypeName("const uint8_t *[4]")] byte** data, [NativeTypeName("const int[4]")] int* linesize, [NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* desc, int x, int y, int c, int w, int read_pal_component);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_write_image_line2([NativeTypeName("const void *")] void* src, [NativeTypeName("uint8_t *[4]")] byte** data, [NativeTypeName("const int[4]")] int* linesize, [NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* desc, int x, int y, int c, int w, int src_element_size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_write_image_line([NativeTypeName("const uint16_t *")] ushort* src, [NativeTypeName("uint8_t *[4]")] byte** data, [NativeTypeName("const int[4]")] int* linesize, [NativeTypeName("const AVPixFmtDescriptor *")] AVPixFmtDescriptor* desc, int x, int y, int c, int w);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat av_pix_fmt_swap_endianness([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_pix_fmt_loss([NativeTypeName("enum AVPixelFormat")] AVPixelFormat dst_pix_fmt, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat src_pix_fmt, int has_alpha);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat av_find_best_pix_fmt_of_2([NativeTypeName("enum AVPixelFormat")] AVPixelFormat dst_pix_fmt1, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat dst_pix_fmt2, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_BE (1 << 0)")]
        public const int AV_PIX_FMT_FLAG_BE = (1 << 0);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_PAL (1 << 1)")]
        public const int AV_PIX_FMT_FLAG_PAL = (1 << 1);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_BITSTREAM (1 << 2)")]
        public const int AV_PIX_FMT_FLAG_BITSTREAM = (1 << 2);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_HWACCEL (1 << 3)")]
        public const int AV_PIX_FMT_FLAG_HWACCEL = (1 << 3);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_PLANAR (1 << 4)")]
        public const int AV_PIX_FMT_FLAG_PLANAR = (1 << 4);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_RGB (1 << 5)")]
        public const int AV_PIX_FMT_FLAG_RGB = (1 << 5);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_ALPHA (1 << 7)")]
        public const int AV_PIX_FMT_FLAG_ALPHA = (1 << 7);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_BAYER (1 << 8)")]
        public const int AV_PIX_FMT_FLAG_BAYER = (1 << 8);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_FLOAT (1 << 9)")]
        public const int AV_PIX_FMT_FLAG_FLOAT = (1 << 9);

        [NativeTypeName("#define AV_PIX_FMT_FLAG_XYZ (1 << 10)")]
        public const int AV_PIX_FMT_FLAG_XYZ = (1 << 10);

        [NativeTypeName("#define FF_LOSS_RESOLUTION 0x0001")]
        public const int FF_LOSS_RESOLUTION = 0x0001;

        [NativeTypeName("#define FF_LOSS_DEPTH 0x0002")]
        public const int FF_LOSS_DEPTH = 0x0002;

        [NativeTypeName("#define FF_LOSS_COLORSPACE 0x0004")]
        public const int FF_LOSS_COLORSPACE = 0x0004;

        [NativeTypeName("#define FF_LOSS_ALPHA 0x0008")]
        public const int FF_LOSS_ALPHA = 0x0008;

        [NativeTypeName("#define FF_LOSS_COLORQUANT 0x0010")]
        public const int FF_LOSS_COLORQUANT = 0x0010;

        [NativeTypeName("#define FF_LOSS_CHROMA 0x0020")]
        public const int FF_LOSS_CHROMA = 0x0020;

        [NativeTypeName("#define FF_LOSS_EXCESS_RESOLUTION 0x0040")]
        public const int FF_LOSS_EXCESS_RESOLUTION = 0x0040;

        [NativeTypeName("#define FF_LOSS_EXCESS_DEPTH 0x0080")]
        public const int FF_LOSS_EXCESS_DEPTH = 0x0080;

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_strerror(int errnum, [NativeTypeName("char *")] sbyte* errbuf, [NativeTypeName("size_t")] nuint errbuf_size);

        [NativeTypeName("#define AVERROR_BSF_NOT_FOUND FFERRTAG(0xF8,'B','S','F')")]
        public const int AVERROR_BSF_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('B')) << 8) | (((sbyte)('S')) << 16) | ((uint)('F') << 24)));

        [NativeTypeName("#define AVERROR_BUG FFERRTAG( 'B','U','G','!')")]
        public const int AVERROR_BUG = unchecked(-(int)(((sbyte)('B')) | (((sbyte)('U')) << 8) | (((sbyte)('G')) << 16) | ((uint)('!') << 24)));

        [NativeTypeName("#define AVERROR_BUFFER_TOO_SMALL FFERRTAG( 'B','U','F','S')")]
        public const int AVERROR_BUFFER_TOO_SMALL = unchecked(-(int)(((sbyte)('B')) | (((sbyte)('U')) << 8) | (((sbyte)('F')) << 16) | ((uint)('S') << 24)));

        [NativeTypeName("#define AVERROR_DECODER_NOT_FOUND FFERRTAG(0xF8,'D','E','C')")]
        public const int AVERROR_DECODER_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('D')) << 8) | (((sbyte)('E')) << 16) | ((uint)('C') << 24)));

        [NativeTypeName("#define AVERROR_DEMUXER_NOT_FOUND FFERRTAG(0xF8,'D','E','M')")]
        public const int AVERROR_DEMUXER_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('D')) << 8) | (((sbyte)('E')) << 16) | ((uint)('M') << 24)));

        [NativeTypeName("#define AVERROR_ENCODER_NOT_FOUND FFERRTAG(0xF8,'E','N','C')")]
        public const int AVERROR_ENCODER_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('E')) << 8) | (((sbyte)('N')) << 16) | ((uint)('C') << 24)));

        [NativeTypeName("#define AVERROR_EOF FFERRTAG( 'E','O','F',' ')")]
        public const int AVERROR_EOF = unchecked(-(int)(((sbyte)('E')) | (((sbyte)('O')) << 8) | (((sbyte)('F')) << 16) | ((uint)(' ') << 24)));

        [NativeTypeName("#define AVERROR_EXIT FFERRTAG( 'E','X','I','T')")]
        public const int AVERROR_EXIT = unchecked(-(int)(((sbyte)('E')) | (((sbyte)('X')) << 8) | (((sbyte)('I')) << 16) | ((uint)('T') << 24)));

        [NativeTypeName("#define AVERROR_EXTERNAL FFERRTAG( 'E','X','T',' ')")]
        public const int AVERROR_EXTERNAL = unchecked(-(int)(((sbyte)('E')) | (((sbyte)('X')) << 8) | (((sbyte)('T')) << 16) | ((uint)(' ') << 24)));

        [NativeTypeName("#define AVERROR_FILTER_NOT_FOUND FFERRTAG(0xF8,'F','I','L')")]
        public const int AVERROR_FILTER_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('F')) << 8) | (((sbyte)('I')) << 16) | ((uint)('L') << 24)));

        [NativeTypeName("#define AVERROR_INVALIDDATA FFERRTAG( 'I','N','D','A')")]
        public const int AVERROR_INVALIDDATA = unchecked(-(int)(((sbyte)('I')) | (((sbyte)('N')) << 8) | (((sbyte)('D')) << 16) | ((uint)('A') << 24)));

        [NativeTypeName("#define AVERROR_MUXER_NOT_FOUND FFERRTAG(0xF8,'M','U','X')")]
        public const int AVERROR_MUXER_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('M')) << 8) | (((sbyte)('U')) << 16) | ((uint)('X') << 24)));

        [NativeTypeName("#define AVERROR_OPTION_NOT_FOUND FFERRTAG(0xF8,'O','P','T')")]
        public const int AVERROR_OPTION_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('O')) << 8) | (((sbyte)('P')) << 16) | ((uint)('T') << 24)));

        [NativeTypeName("#define AVERROR_PATCHWELCOME FFERRTAG( 'P','A','W','E')")]
        public const int AVERROR_PATCHWELCOME = unchecked(-(int)(((sbyte)('P')) | (((sbyte)('A')) << 8) | (((sbyte)('W')) << 16) | ((uint)('E') << 24)));

        [NativeTypeName("#define AVERROR_PROTOCOL_NOT_FOUND FFERRTAG(0xF8,'P','R','O')")]
        public const int AVERROR_PROTOCOL_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('P')) << 8) | (((sbyte)('R')) << 16) | ((uint)('O') << 24)));

        [NativeTypeName("#define AVERROR_STREAM_NOT_FOUND FFERRTAG(0xF8,'S','T','R')")]
        public const int AVERROR_STREAM_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('S')) << 8) | (((sbyte)('T')) << 16) | ((uint)('R') << 24)));

        [NativeTypeName("#define AVERROR_BUG2 FFERRTAG( 'B','U','G',' ')")]
        public const int AVERROR_BUG2 = unchecked(-(int)(((sbyte)('B')) | (((sbyte)('U')) << 8) | (((sbyte)('G')) << 16) | ((uint)(' ') << 24)));

        [NativeTypeName("#define AVERROR_UNKNOWN FFERRTAG( 'U','N','K','N')")]
        public const int AVERROR_UNKNOWN = unchecked(-(int)(((sbyte)('U')) | (((sbyte)('N')) << 8) | (((sbyte)('K')) << 16) | ((uint)('N') << 24)));

        [NativeTypeName("#define AVERROR_EXPERIMENTAL (-0x2bb2afa8)")]
        public const int AVERROR_EXPERIMENTAL = (-0x2bb2afa8);

        [NativeTypeName("#define AVERROR_INPUT_CHANGED (-0x636e6701)")]
        public const int AVERROR_INPUT_CHANGED = (-0x636e6701);

        [NativeTypeName("#define AVERROR_OUTPUT_CHANGED (-0x636e6702)")]
        public const int AVERROR_OUTPUT_CHANGED = (-0x636e6702);

        [NativeTypeName("#define AVERROR_HTTP_BAD_REQUEST FFERRTAG(0xF8,'4','0','0')")]
        public const int AVERROR_HTTP_BAD_REQUEST = unchecked(-(int)((0xF8) | (((sbyte)('4')) << 8) | (((sbyte)('0')) << 16) | ((uint)('0') << 24)));

        [NativeTypeName("#define AVERROR_HTTP_UNAUTHORIZED FFERRTAG(0xF8,'4','0','1')")]
        public const int AVERROR_HTTP_UNAUTHORIZED = unchecked(-(int)((0xF8) | (((sbyte)('4')) << 8) | (((sbyte)('0')) << 16) | ((uint)('1') << 24)));

        [NativeTypeName("#define AVERROR_HTTP_FORBIDDEN FFERRTAG(0xF8,'4','0','3')")]
        public const int AVERROR_HTTP_FORBIDDEN = unchecked(-(int)((0xF8) | (((sbyte)('4')) << 8) | (((sbyte)('0')) << 16) | ((uint)('3') << 24)));

        [NativeTypeName("#define AVERROR_HTTP_NOT_FOUND FFERRTAG(0xF8,'4','0','4')")]
        public const int AVERROR_HTTP_NOT_FOUND = unchecked(-(int)((0xF8) | (((sbyte)('4')) << 8) | (((sbyte)('0')) << 16) | ((uint)('4') << 24)));

        [NativeTypeName("#define AVERROR_HTTP_TOO_MANY_REQUESTS FFERRTAG(0xF8,'4','2','9')")]
        public const int AVERROR_HTTP_TOO_MANY_REQUESTS = unchecked(-(int)((0xF8) | (((sbyte)('4')) << 8) | (((sbyte)('2')) << 16) | ((uint)('9') << 24)));

        [NativeTypeName("#define AVERROR_HTTP_OTHER_4XX FFERRTAG(0xF8,'4','X','X')")]
        public const int AVERROR_HTTP_OTHER_4XX = unchecked(-(int)((0xF8) | (((sbyte)('4')) << 8) | (((sbyte)('X')) << 16) | ((uint)('X') << 24)));

        [NativeTypeName("#define AVERROR_HTTP_SERVER_ERROR FFERRTAG(0xF8,'5','X','X')")]
        public const int AVERROR_HTTP_SERVER_ERROR = unchecked(-(int)((0xF8) | (((sbyte)('5')) << 8) | (((sbyte)('X')) << 16) | ((uint)('X') << 24)));

        [NativeTypeName("#define AV_ERROR_MAX_STRING_SIZE 64")]
        public const int AV_ERROR_MAX_STRING_SIZE = 64;
    }
}

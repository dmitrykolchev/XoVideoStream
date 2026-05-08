using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.FFMpeg.Native
{
    public partial struct RcOverride
    {
        public int start_frame;

        public int end_frame;

        public int qscale;

        public float quality_factor;
    }

    public unsafe partial struct AVCodecContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public int log_level_offset;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType codec_type;

        [NativeTypeName("const struct AVCodec *")]
        public AVCodec* codec;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID codec_id;

        [NativeTypeName("unsigned int")]
        public uint codec_tag;

        public void* priv_data;

        [NativeTypeName("struct AVCodecInternal *")]
        public AVCodecInternal* @internal;

        public void* opaque;

        [NativeTypeName("int64_t")]
        public long bit_rate;

        public int flags;

        public int flags2;

        [NativeTypeName("uint8_t *")]
        public byte* extradata;

        public int extradata_size;

        public AVRational time_base;

        public AVRational pkt_timebase;

        public AVRational framerate;

        public int delay;

        public int width;

        public int height;

        public int coded_width;

        public int coded_height;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat sw_pix_fmt;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace colorspace;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_sample_location;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        public int refs;

        public int has_b_frames;

        public int slice_flags;

        [NativeTypeName("void (*)(struct AVCodecContext *, const AVFrame *, int *, int, int, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int, int, int, int, void> draw_horiz_band;

        [NativeTypeName("enum AVPixelFormat (*)(struct AVCodecContext *, const enum AVPixelFormat *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPixelFormat*, AVPixelFormat> get_format;

        public int max_b_frames;

        public float b_quant_factor;

        public float b_quant_offset;

        public float i_quant_factor;

        public float i_quant_offset;

        public float lumi_masking;

        public float temporal_cplx_masking;

        public float spatial_cplx_masking;

        public float p_masking;

        public float dark_masking;

        public int nsse_weight;

        public int me_cmp;

        public int me_sub_cmp;

        public int mb_cmp;

        public int ildct_cmp;

        public int dia_size;

        public int last_predictor_count;

        public int me_pre_cmp;

        public int pre_dia_size;

        public int me_subpel_quality;

        public int me_range;

        public int mb_decision;

        [NativeTypeName("uint16_t *")]
        public ushort* intra_matrix;

        [NativeTypeName("uint16_t *")]
        public ushort* inter_matrix;

        [NativeTypeName("uint16_t *")]
        public ushort* chroma_intra_matrix;

        [Obsolete]
        public int intra_dc_precision;

        public int mb_lmin;

        public int mb_lmax;

        public int bidir_refine;

        public int keyint_min;

        public int gop_size;

        public int mv0_threshold;

        public int slices;

        public int sample_rate;

        [NativeTypeName("enum AVSampleFormat")]
        public AVSampleFormat sample_fmt;

        public AVChannelLayout ch_layout;

        public int frame_size;

        public int block_align;

        public int cutoff;

        [NativeTypeName("enum AVAudioServiceType")]
        public AVAudioServiceType audio_service_type;

        [NativeTypeName("enum AVSampleFormat")]
        public AVSampleFormat request_sample_fmt;

        public int initial_padding;

        public int trailing_padding;

        public int seek_preroll;

        [NativeTypeName("int (*)(struct AVCodecContext *, AVFrame *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int, int> get_buffer2;

        public int bit_rate_tolerance;

        public int global_quality;

        public int compression_level;

        public float qcompress;

        public float qblur;

        public int qmin;

        public int qmax;

        public int max_qdiff;

        public int rc_buffer_size;

        public int rc_override_count;

        public RcOverride* rc_override;

        [NativeTypeName("int64_t")]
        public long rc_max_rate;

        [NativeTypeName("int64_t")]
        public long rc_min_rate;

        public float rc_max_available_vbv_use;

        public float rc_min_vbv_overflow_use;

        public int rc_initial_buffer_occupancy;

        public int trellis;

        [NativeTypeName("char *")]
        public sbyte* stats_out;

        [NativeTypeName("char *")]
        public sbyte* stats_in;

        public int workaround_bugs;

        public int strict_std_compliance;

        public int error_concealment;

        public int debug;

        public int err_recognition;

        [NativeTypeName("const struct AVHWAccel *")]
        public AVHWAccel* hwaccel;

        public void* hwaccel_context;

        public AVBufferRef* hw_frames_ctx;

        public AVBufferRef* hw_device_ctx;

        public int hwaccel_flags;

        public int extra_hw_frames;

        [NativeTypeName("uint64_t[8]")]
        public _error_e__FixedBuffer error;

        public int dct_algo;

        public int idct_algo;

        public int bits_per_coded_sample;

        public int bits_per_raw_sample;

        public int thread_count;

        public int thread_type;

        public int active_thread_type;

        [NativeTypeName("int (*)(struct AVCodecContext *, int (*)(struct AVCodecContext *, void *), void *, int *, int, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int>, void*, int*, int, int, int> execute;

        [NativeTypeName("int (*)(struct AVCodecContext *, int (*)(struct AVCodecContext *, void *, int, int), void *, int *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int, int, int>, void*, int*, int, int> execute2;

        public int profile;

        public int level;

        [NativeTypeName("unsigned int")]
        [Obsolete]
        public uint properties;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_loop_filter;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_idct;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_frame;

        public int skip_alpha;

        public int skip_top;

        public int skip_bottom;

        public int lowres;

        [NativeTypeName("const struct AVCodecDescriptor *")]
        public AVCodecDescriptor* codec_descriptor;

        [NativeTypeName("char *")]
        public sbyte* sub_charenc;

        public int sub_charenc_mode;

        public int subtitle_header_size;

        [NativeTypeName("uint8_t *")]
        public byte* subtitle_header;

        [NativeTypeName("uint8_t *")]
        public byte* dump_separator;

        [NativeTypeName("char *")]
        public sbyte* codec_whitelist;

        public AVPacketSideData* coded_side_data;

        public int nb_coded_side_data;

        public int export_side_data;

        [NativeTypeName("int64_t")]
        public long max_pixels;

        public int apply_cropping;

        public int discard_damaged_percentage;

        [NativeTypeName("int64_t")]
        public long max_samples;

        [NativeTypeName("int (*)(struct AVCodecContext *, AVPacket *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int, int> get_encode_buffer;

        [NativeTypeName("int64_t")]
        public long frame_num;

        public int* side_data_prefer_packet;

        [NativeTypeName("unsigned int")]
        public uint nb_side_data_prefer_packet;

        public AVFrameSideData** decoded_side_data;

        public int nb_decoded_side_data;

        [NativeTypeName("enum AVAlphaMode")]
        public AVAlphaMode alpha_mode;

        [InlineArray(8)]
        public partial struct _error_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public unsafe partial struct AVHWAccel
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        public int capabilities;
    }

    public enum AVSubtitleType
    {
        SUBTITLE_NONE,
        SUBTITLE_BITMAP,
        SUBTITLE_TEXT,
        SUBTITLE_ASS,
    }

    public unsafe partial struct AVSubtitleRect
    {
        public int x;

        public int y;

        public int w;

        public int h;

        public int nb_colors;

        [NativeTypeName("uint8_t *[4]")]
        public _data_e__FixedBuffer data;

        [NativeTypeName("int[4]")]
        public _linesize_e__FixedBuffer linesize;

        public int flags;

        [NativeTypeName("enum AVSubtitleType")]
        public AVSubtitleType type;

        [NativeTypeName("char *")]
        public sbyte* text;

        [NativeTypeName("char *")]
        public sbyte* ass;

        public unsafe partial struct _data_e__FixedBuffer
        {
            public byte* e0;
            public byte* e1;
            public byte* e2;
            public byte* e3;

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

        [InlineArray(4)]
        public partial struct _linesize_e__FixedBuffer
        {
            public int e0;
        }
    }

    public unsafe partial struct AVSubtitle
    {
        [NativeTypeName("uint16_t")]
        public ushort format;

        [NativeTypeName("uint32_t")]
        public uint start_display_time;

        [NativeTypeName("uint32_t")]
        public uint end_display_time;

        [NativeTypeName("unsigned int")]
        public uint num_rects;

        public AVSubtitleRect** rects;

        [NativeTypeName("int64_t")]
        public long pts;
    }

    public enum AVCodecConfig
    {
        AV_CODEC_CONFIG_PIX_FORMAT,
        AV_CODEC_CONFIG_FRAME_RATE,
        AV_CODEC_CONFIG_SAMPLE_RATE,
        AV_CODEC_CONFIG_SAMPLE_FORMAT,
        AV_CODEC_CONFIG_CHANNEL_LAYOUT,
        AV_CODEC_CONFIG_COLOR_RANGE,
        AV_CODEC_CONFIG_COLOR_SPACE,
        AV_CODEC_CONFIG_ALPHA_MODE,
    }

    public enum AVPictureStructure
    {
        AV_PICTURE_STRUCTURE_UNKNOWN,
        AV_PICTURE_STRUCTURE_TOP_FIELD,
        AV_PICTURE_STRUCTURE_BOTTOM_FIELD,
        AV_PICTURE_STRUCTURE_FRAME,
    }

    public unsafe partial struct AVCodecParserContext
    {
        public void* priv_data;

        [NativeTypeName("const struct AVCodecParser *")]
        public AVCodecParser* parser;

        [NativeTypeName("int64_t")]
        public long frame_offset;

        [NativeTypeName("int64_t")]
        public long cur_offset;

        [NativeTypeName("int64_t")]
        public long next_frame_offset;

        public int pict_type;

        public int repeat_pict;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        public long dts;

        [NativeTypeName("int64_t")]
        public long last_pts;

        [NativeTypeName("int64_t")]
        public long last_dts;

        public int fetch_timestamp;

        public int cur_frame_start_index;

        [NativeTypeName("int64_t[4]")]
        public _cur_frame_offset_e__FixedBuffer cur_frame_offset;

        [NativeTypeName("int64_t[4]")]
        public _cur_frame_pts_e__FixedBuffer cur_frame_pts;

        [NativeTypeName("int64_t[4]")]
        public _cur_frame_dts_e__FixedBuffer cur_frame_dts;

        public int flags;

        [NativeTypeName("int64_t")]
        public long offset;

        [NativeTypeName("int64_t[4]")]
        public _cur_frame_end_e__FixedBuffer cur_frame_end;

        public int key_frame;

        public int dts_sync_point;

        public int dts_ref_dts_delta;

        public int pts_dts_delta;

        [NativeTypeName("int64_t[4]")]
        public _cur_frame_pos_e__FixedBuffer cur_frame_pos;

        [NativeTypeName("int64_t")]
        public long pos;

        [NativeTypeName("int64_t")]
        public long last_pos;

        public int duration;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        [NativeTypeName("enum AVPictureStructure")]
        public AVPictureStructure picture_structure;

        public int output_picture_number;

        public int width;

        public int height;

        public int coded_width;

        public int coded_height;

        public int format;

        [InlineArray(4)]
        public partial struct _cur_frame_offset_e__FixedBuffer
        {
            public long e0;
        }

        [InlineArray(4)]
        public partial struct _cur_frame_pts_e__FixedBuffer
        {
            public long e0;
        }

        [InlineArray(4)]
        public partial struct _cur_frame_dts_e__FixedBuffer
        {
            public long e0;
        }

        [InlineArray(4)]
        public partial struct _cur_frame_end_e__FixedBuffer
        {
            public long e0;
        }

        [InlineArray(4)]
        public partial struct _cur_frame_pos_e__FixedBuffer
        {
            public long e0;
        }
    }

    public unsafe partial struct AVCodecParser
    {
        [NativeTypeName("int[7]")]
        public _codec_ids_e__FixedBuffer codec_ids;

        [Obsolete]
        public int priv_data_size;

        [NativeTypeName("int (*)(AVCodecParserContext *)")]
        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, int> parser_init;

        [NativeTypeName("int (*)(AVCodecParserContext *, AVCodecContext *, const uint8_t **, int *, const uint8_t *, int)")]
        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, int> parser_parse;

        [NativeTypeName("void (*)(AVCodecParserContext *)")]
        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, void> parser_close;

        [NativeTypeName("int (*)(AVCodecContext *, const uint8_t *, int)")]
        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, int, int> split;

        [InlineArray(7)]
        public partial struct _codec_ids_e__FixedBuffer
        {
            public int e0;
        }
    }

    public unsafe partial struct AVProfile
    {
        public int profile;

        [NativeTypeName("const char *")]
        public sbyte* name;
    }

    public unsafe partial struct AVCodec
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        public int capabilities;

        [NativeTypeName("uint8_t")]
        public byte max_lowres;

        [NativeTypeName("const AVRational *")]
        [Obsolete]
        public AVRational* supported_framerates;

        [NativeTypeName("const enum AVPixelFormat *")]
        [Obsolete]
        public AVPixelFormat* pix_fmts;

        [NativeTypeName("const int *")]
        [Obsolete]
        public int* supported_samplerates;

        [NativeTypeName("const enum AVSampleFormat *")]
        [Obsolete]
        public AVSampleFormat* sample_fmts;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        [NativeTypeName("const AVProfile *")]
        public AVProfile* profiles;

        [NativeTypeName("const char *")]
        public sbyte* wrapper_name;

        [NativeTypeName("const AVChannelLayout *")]
        [Obsolete]
        public AVChannelLayout* ch_layouts;
    }

    public partial struct AVCodecHWConfig
    {
        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        public int methods;

        [NativeTypeName("enum AVHWDeviceType")]
        public AVHWDeviceType device_type;
    }

    public enum AVCodecID
    {
        AV_CODEC_ID_NONE,
        AV_CODEC_ID_MPEG1VIDEO,
        AV_CODEC_ID_MPEG2VIDEO,
        AV_CODEC_ID_H261,
        AV_CODEC_ID_H263,
        AV_CODEC_ID_RV10,
        AV_CODEC_ID_RV20,
        AV_CODEC_ID_MJPEG,
        AV_CODEC_ID_MJPEGB,
        AV_CODEC_ID_LJPEG,
        AV_CODEC_ID_SP5X,
        AV_CODEC_ID_JPEGLS,
        AV_CODEC_ID_MPEG4,
        AV_CODEC_ID_RAWVIDEO,
        AV_CODEC_ID_MSMPEG4V1,
        AV_CODEC_ID_MSMPEG4V2,
        AV_CODEC_ID_MSMPEG4V3,
        AV_CODEC_ID_WMV1,
        AV_CODEC_ID_WMV2,
        AV_CODEC_ID_H263P,
        AV_CODEC_ID_H263I,
        AV_CODEC_ID_FLV1,
        AV_CODEC_ID_SVQ1,
        AV_CODEC_ID_SVQ3,
        AV_CODEC_ID_DVVIDEO,
        AV_CODEC_ID_HUFFYUV,
        AV_CODEC_ID_CYUV,
        AV_CODEC_ID_H264,
        AV_CODEC_ID_INDEO3,
        AV_CODEC_ID_VP3,
        AV_CODEC_ID_THEORA,
        AV_CODEC_ID_ASV1,
        AV_CODEC_ID_ASV2,
        AV_CODEC_ID_FFV1,
        AV_CODEC_ID_4XM,
        AV_CODEC_ID_VCR1,
        AV_CODEC_ID_CLJR,
        AV_CODEC_ID_MDEC,
        AV_CODEC_ID_ROQ,
        AV_CODEC_ID_INTERPLAY_VIDEO,
        AV_CODEC_ID_XAN_WC3,
        AV_CODEC_ID_XAN_WC4,
        AV_CODEC_ID_RPZA,
        AV_CODEC_ID_CINEPAK,
        AV_CODEC_ID_WS_VQA,
        AV_CODEC_ID_MSRLE,
        AV_CODEC_ID_MSVIDEO1,
        AV_CODEC_ID_IDCIN,
        AV_CODEC_ID_8BPS,
        AV_CODEC_ID_SMC,
        AV_CODEC_ID_FLIC,
        AV_CODEC_ID_TRUEMOTION1,
        AV_CODEC_ID_VMDVIDEO,
        AV_CODEC_ID_MSZH,
        AV_CODEC_ID_ZLIB,
        AV_CODEC_ID_QTRLE,
        AV_CODEC_ID_TSCC,
        AV_CODEC_ID_ULTI,
        AV_CODEC_ID_QDRAW,
        AV_CODEC_ID_VIXL,
        AV_CODEC_ID_QPEG,
        AV_CODEC_ID_PNG,
        AV_CODEC_ID_PPM,
        AV_CODEC_ID_PBM,
        AV_CODEC_ID_PGM,
        AV_CODEC_ID_PGMYUV,
        AV_CODEC_ID_PAM,
        AV_CODEC_ID_FFVHUFF,
        AV_CODEC_ID_RV30,
        AV_CODEC_ID_RV40,
        AV_CODEC_ID_VC1,
        AV_CODEC_ID_WMV3,
        AV_CODEC_ID_LOCO,
        AV_CODEC_ID_WNV1,
        AV_CODEC_ID_AASC,
        AV_CODEC_ID_INDEO2,
        AV_CODEC_ID_FRAPS,
        AV_CODEC_ID_TRUEMOTION2,
        AV_CODEC_ID_BMP,
        AV_CODEC_ID_CSCD,
        AV_CODEC_ID_MMVIDEO,
        AV_CODEC_ID_ZMBV,
        AV_CODEC_ID_AVS,
        AV_CODEC_ID_SMACKVIDEO,
        AV_CODEC_ID_NUV,
        AV_CODEC_ID_KMVC,
        AV_CODEC_ID_FLASHSV,
        AV_CODEC_ID_CAVS,
        AV_CODEC_ID_JPEG2000,
        AV_CODEC_ID_VMNC,
        AV_CODEC_ID_VP5,
        AV_CODEC_ID_VP6,
        AV_CODEC_ID_VP6F,
        AV_CODEC_ID_TARGA,
        AV_CODEC_ID_DSICINVIDEO,
        AV_CODEC_ID_TIERTEXSEQVIDEO,
        AV_CODEC_ID_TIFF,
        AV_CODEC_ID_GIF,
        AV_CODEC_ID_DXA,
        AV_CODEC_ID_DNXHD,
        AV_CODEC_ID_THP,
        AV_CODEC_ID_SGI,
        AV_CODEC_ID_C93,
        AV_CODEC_ID_BETHSOFTVID,
        AV_CODEC_ID_PTX,
        AV_CODEC_ID_TXD,
        AV_CODEC_ID_VP6A,
        AV_CODEC_ID_AMV,
        AV_CODEC_ID_VB,
        AV_CODEC_ID_PCX,
        AV_CODEC_ID_SUNRAST,
        AV_CODEC_ID_INDEO4,
        AV_CODEC_ID_INDEO5,
        AV_CODEC_ID_MIMIC,
        AV_CODEC_ID_RL2,
        AV_CODEC_ID_ESCAPE124,
        AV_CODEC_ID_DIRAC,
        AV_CODEC_ID_BFI,
        AV_CODEC_ID_CMV,
        AV_CODEC_ID_MOTIONPIXELS,
        AV_CODEC_ID_TGV,
        AV_CODEC_ID_TGQ,
        AV_CODEC_ID_TQI,
        AV_CODEC_ID_AURA,
        AV_CODEC_ID_AURA2,
        AV_CODEC_ID_V210X,
        AV_CODEC_ID_TMV,
        AV_CODEC_ID_V210,
        AV_CODEC_ID_DPX,
        AV_CODEC_ID_MAD,
        AV_CODEC_ID_FRWU,
        AV_CODEC_ID_FLASHSV2,
        AV_CODEC_ID_CDGRAPHICS,
        AV_CODEC_ID_R210,
        AV_CODEC_ID_ANM,
        AV_CODEC_ID_BINKVIDEO,
        AV_CODEC_ID_IFF_ILBM,
        AV_CODEC_ID_KGV1,
        AV_CODEC_ID_YOP,
        AV_CODEC_ID_VP8,
        AV_CODEC_ID_PICTOR,
        AV_CODEC_ID_ANSI,
        AV_CODEC_ID_A64_MULTI,
        AV_CODEC_ID_A64_MULTI5,
        AV_CODEC_ID_R10K,
        AV_CODEC_ID_MXPEG,
        AV_CODEC_ID_LAGARITH,
        AV_CODEC_ID_PRORES,
        AV_CODEC_ID_JV,
        AV_CODEC_ID_DFA,
        AV_CODEC_ID_WMV3IMAGE,
        AV_CODEC_ID_VC1IMAGE,
        AV_CODEC_ID_UTVIDEO,
        AV_CODEC_ID_BMV_VIDEO,
        AV_CODEC_ID_VBLE,
        AV_CODEC_ID_DXTORY,
        AV_CODEC_ID_V410,
        AV_CODEC_ID_XWD,
        AV_CODEC_ID_CDXL,
        AV_CODEC_ID_XBM,
        AV_CODEC_ID_ZEROCODEC,
        AV_CODEC_ID_MSS1,
        AV_CODEC_ID_MSA1,
        AV_CODEC_ID_TSCC2,
        AV_CODEC_ID_MTS2,
        AV_CODEC_ID_CLLC,
        AV_CODEC_ID_MSS2,
        AV_CODEC_ID_VP9,
        AV_CODEC_ID_AIC,
        AV_CODEC_ID_ESCAPE130,
        AV_CODEC_ID_G2M,
        AV_CODEC_ID_WEBP,
        AV_CODEC_ID_HNM4_VIDEO,
        AV_CODEC_ID_HEVC,
        AV_CODEC_ID_FIC,
        AV_CODEC_ID_ALIAS_PIX,
        AV_CODEC_ID_BRENDER_PIX,
        AV_CODEC_ID_PAF_VIDEO,
        AV_CODEC_ID_EXR,
        AV_CODEC_ID_VP7,
        AV_CODEC_ID_SANM,
        AV_CODEC_ID_SGIRLE,
        AV_CODEC_ID_MVC1,
        AV_CODEC_ID_MVC2,
        AV_CODEC_ID_HQX,
        AV_CODEC_ID_TDSC,
        AV_CODEC_ID_HQ_HQA,
        AV_CODEC_ID_HAP,
        AV_CODEC_ID_DDS,
        AV_CODEC_ID_DXV,
        AV_CODEC_ID_SCREENPRESSO,
        AV_CODEC_ID_RSCC,
        AV_CODEC_ID_AVS2,
        AV_CODEC_ID_PGX,
        AV_CODEC_ID_AVS3,
        AV_CODEC_ID_MSP2,
        AV_CODEC_ID_VVC,
        AV_CODEC_ID_Y41P,
        AV_CODEC_ID_AVRP,
        AV_CODEC_ID_012V,
        AV_CODEC_ID_AVUI,
        AV_CODEC_ID_TARGA_Y216,
        AV_CODEC_ID_V308,
        AV_CODEC_ID_V408,
        AV_CODEC_ID_YUV4,
        AV_CODEC_ID_AVRN,
        AV_CODEC_ID_CPIA,
        AV_CODEC_ID_XFACE,
        AV_CODEC_ID_SNOW,
        AV_CODEC_ID_SMVJPEG,
        AV_CODEC_ID_APNG,
        AV_CODEC_ID_DAALA,
        AV_CODEC_ID_CFHD,
        AV_CODEC_ID_TRUEMOTION2RT,
        AV_CODEC_ID_M101,
        AV_CODEC_ID_MAGICYUV,
        AV_CODEC_ID_SHEERVIDEO,
        AV_CODEC_ID_YLC,
        AV_CODEC_ID_PSD,
        AV_CODEC_ID_PIXLET,
        AV_CODEC_ID_SPEEDHQ,
        AV_CODEC_ID_FMVC,
        AV_CODEC_ID_SCPR,
        AV_CODEC_ID_CLEARVIDEO,
        AV_CODEC_ID_XPM,
        AV_CODEC_ID_AV1,
        AV_CODEC_ID_BITPACKED,
        AV_CODEC_ID_MSCC,
        AV_CODEC_ID_SRGC,
        AV_CODEC_ID_SVG,
        AV_CODEC_ID_GDV,
        AV_CODEC_ID_FITS,
        AV_CODEC_ID_IMM4,
        AV_CODEC_ID_PROSUMER,
        AV_CODEC_ID_MWSC,
        AV_CODEC_ID_WCMV,
        AV_CODEC_ID_RASC,
        AV_CODEC_ID_HYMT,
        AV_CODEC_ID_ARBC,
        AV_CODEC_ID_AGM,
        AV_CODEC_ID_LSCR,
        AV_CODEC_ID_VP4,
        AV_CODEC_ID_IMM5,
        AV_CODEC_ID_MVDV,
        AV_CODEC_ID_MVHA,
        AV_CODEC_ID_CDTOONS,
        AV_CODEC_ID_MV30,
        AV_CODEC_ID_NOTCHLC,
        AV_CODEC_ID_PFM,
        AV_CODEC_ID_MOBICLIP,
        AV_CODEC_ID_PHOTOCD,
        AV_CODEC_ID_IPU,
        AV_CODEC_ID_ARGO,
        AV_CODEC_ID_CRI,
        AV_CODEC_ID_SIMBIOSIS_IMX,
        AV_CODEC_ID_SGA_VIDEO,
        AV_CODEC_ID_GEM,
        AV_CODEC_ID_VBN,
        AV_CODEC_ID_JPEGXL,
        AV_CODEC_ID_QOI,
        AV_CODEC_ID_PHM,
        AV_CODEC_ID_RADIANCE_HDR,
        AV_CODEC_ID_WBMP,
        AV_CODEC_ID_MEDIA100,
        AV_CODEC_ID_VQC,
        AV_CODEC_ID_PDV,
        AV_CODEC_ID_EVC,
        AV_CODEC_ID_RTV1,
        AV_CODEC_ID_VMIX,
        AV_CODEC_ID_LEAD,
        AV_CODEC_ID_DNXUC,
        AV_CODEC_ID_RV60,
        AV_CODEC_ID_JPEGXL_ANIM,
        AV_CODEC_ID_APV,
        AV_CODEC_ID_PRORES_RAW,
        AV_CODEC_ID_JPEGXS,
        AV_CODEC_ID_FIRST_AUDIO = 0x10000,
        AV_CODEC_ID_PCM_S16LE = 0x10000,
        AV_CODEC_ID_PCM_S16BE,
        AV_CODEC_ID_PCM_U16LE,
        AV_CODEC_ID_PCM_U16BE,
        AV_CODEC_ID_PCM_S8,
        AV_CODEC_ID_PCM_U8,
        AV_CODEC_ID_PCM_MULAW,
        AV_CODEC_ID_PCM_ALAW,
        AV_CODEC_ID_PCM_S32LE,
        AV_CODEC_ID_PCM_S32BE,
        AV_CODEC_ID_PCM_U32LE,
        AV_CODEC_ID_PCM_U32BE,
        AV_CODEC_ID_PCM_S24LE,
        AV_CODEC_ID_PCM_S24BE,
        AV_CODEC_ID_PCM_U24LE,
        AV_CODEC_ID_PCM_U24BE,
        AV_CODEC_ID_PCM_S24DAUD,
        AV_CODEC_ID_PCM_ZORK,
        AV_CODEC_ID_PCM_S16LE_PLANAR,
        AV_CODEC_ID_PCM_DVD,
        AV_CODEC_ID_PCM_F32BE,
        AV_CODEC_ID_PCM_F32LE,
        AV_CODEC_ID_PCM_F64BE,
        AV_CODEC_ID_PCM_F64LE,
        AV_CODEC_ID_PCM_BLURAY,
        AV_CODEC_ID_PCM_LXF,
        AV_CODEC_ID_S302M,
        AV_CODEC_ID_PCM_S8_PLANAR,
        AV_CODEC_ID_PCM_S24LE_PLANAR,
        AV_CODEC_ID_PCM_S32LE_PLANAR,
        AV_CODEC_ID_PCM_S16BE_PLANAR,
        AV_CODEC_ID_PCM_S64LE,
        AV_CODEC_ID_PCM_S64BE,
        AV_CODEC_ID_PCM_F16LE,
        AV_CODEC_ID_PCM_F24LE,
        AV_CODEC_ID_PCM_VIDC,
        AV_CODEC_ID_PCM_SGA,
        AV_CODEC_ID_ADPCM_IMA_QT = 0x11000,
        AV_CODEC_ID_ADPCM_IMA_WAV,
        AV_CODEC_ID_ADPCM_IMA_DK3,
        AV_CODEC_ID_ADPCM_IMA_DK4,
        AV_CODEC_ID_ADPCM_IMA_WS,
        AV_CODEC_ID_ADPCM_IMA_SMJPEG,
        AV_CODEC_ID_ADPCM_MS,
        AV_CODEC_ID_ADPCM_4XM,
        AV_CODEC_ID_ADPCM_XA,
        AV_CODEC_ID_ADPCM_ADX,
        AV_CODEC_ID_ADPCM_EA,
        AV_CODEC_ID_ADPCM_G726,
        AV_CODEC_ID_ADPCM_CT,
        AV_CODEC_ID_ADPCM_SWF,
        AV_CODEC_ID_ADPCM_YAMAHA,
        AV_CODEC_ID_ADPCM_SBPRO_4,
        AV_CODEC_ID_ADPCM_SBPRO_3,
        AV_CODEC_ID_ADPCM_SBPRO_2,
        AV_CODEC_ID_ADPCM_THP,
        AV_CODEC_ID_ADPCM_IMA_AMV,
        AV_CODEC_ID_ADPCM_EA_R1,
        AV_CODEC_ID_ADPCM_EA_R3,
        AV_CODEC_ID_ADPCM_EA_R2,
        AV_CODEC_ID_ADPCM_IMA_EA_SEAD,
        AV_CODEC_ID_ADPCM_IMA_EA_EACS,
        AV_CODEC_ID_ADPCM_EA_XAS,
        AV_CODEC_ID_ADPCM_EA_MAXIS_XA,
        AV_CODEC_ID_ADPCM_IMA_ISS,
        AV_CODEC_ID_ADPCM_G722,
        AV_CODEC_ID_ADPCM_IMA_APC,
        AV_CODEC_ID_ADPCM_VIMA,
        AV_CODEC_ID_ADPCM_AFC,
        AV_CODEC_ID_ADPCM_IMA_OKI,
        AV_CODEC_ID_ADPCM_DTK,
        AV_CODEC_ID_ADPCM_IMA_RAD,
        AV_CODEC_ID_ADPCM_G726LE,
        AV_CODEC_ID_ADPCM_THP_LE,
        AV_CODEC_ID_ADPCM_PSX,
        AV_CODEC_ID_ADPCM_AICA,
        AV_CODEC_ID_ADPCM_IMA_DAT4,
        AV_CODEC_ID_ADPCM_MTAF,
        AV_CODEC_ID_ADPCM_AGM,
        AV_CODEC_ID_ADPCM_ARGO,
        AV_CODEC_ID_ADPCM_IMA_SSI,
        AV_CODEC_ID_ADPCM_ZORK,
        AV_CODEC_ID_ADPCM_IMA_APM,
        AV_CODEC_ID_ADPCM_IMA_ALP,
        AV_CODEC_ID_ADPCM_IMA_MTF,
        AV_CODEC_ID_ADPCM_IMA_CUNNING,
        AV_CODEC_ID_ADPCM_IMA_MOFLEX,
        AV_CODEC_ID_ADPCM_IMA_ACORN,
        AV_CODEC_ID_ADPCM_XMD,
        AV_CODEC_ID_ADPCM_IMA_XBOX,
        AV_CODEC_ID_ADPCM_SANYO,
        AV_CODEC_ID_ADPCM_IMA_HVQM4,
        AV_CODEC_ID_ADPCM_IMA_PDA,
        AV_CODEC_ID_ADPCM_N64,
        AV_CODEC_ID_ADPCM_IMA_HVQM2,
        AV_CODEC_ID_ADPCM_IMA_MAGIX,
        AV_CODEC_ID_ADPCM_PSXC,
        AV_CODEC_ID_ADPCM_CIRCUS,
        AV_CODEC_ID_ADPCM_IMA_ESCAPE,
        AV_CODEC_ID_AMR_NB = 0x12000,
        AV_CODEC_ID_AMR_WB,
        AV_CODEC_ID_RA_144 = 0x13000,
        AV_CODEC_ID_RA_288,
        AV_CODEC_ID_ROQ_DPCM = 0x14000,
        AV_CODEC_ID_INTERPLAY_DPCM,
        AV_CODEC_ID_XAN_DPCM,
        AV_CODEC_ID_SOL_DPCM,
        AV_CODEC_ID_SDX2_DPCM,
        AV_CODEC_ID_GREMLIN_DPCM,
        AV_CODEC_ID_DERF_DPCM,
        AV_CODEC_ID_WADY_DPCM,
        AV_CODEC_ID_CBD2_DPCM,
        AV_CODEC_ID_MP2 = 0x15000,
        AV_CODEC_ID_MP3,
        AV_CODEC_ID_AAC,
        AV_CODEC_ID_AC3,
        AV_CODEC_ID_DTS,
        AV_CODEC_ID_VORBIS,
        AV_CODEC_ID_DVAUDIO,
        AV_CODEC_ID_WMAV1,
        AV_CODEC_ID_WMAV2,
        AV_CODEC_ID_MACE3,
        AV_CODEC_ID_MACE6,
        AV_CODEC_ID_VMDAUDIO,
        AV_CODEC_ID_FLAC,
        AV_CODEC_ID_MP3ADU,
        AV_CODEC_ID_MP3ON4,
        AV_CODEC_ID_SHORTEN,
        AV_CODEC_ID_ALAC,
        AV_CODEC_ID_WESTWOOD_SND1,
        AV_CODEC_ID_GSM,
        AV_CODEC_ID_QDM2,
        AV_CODEC_ID_COOK,
        AV_CODEC_ID_TRUESPEECH,
        AV_CODEC_ID_TTA,
        AV_CODEC_ID_SMACKAUDIO,
        AV_CODEC_ID_QCELP,
        AV_CODEC_ID_WAVPACK,
        AV_CODEC_ID_DSICINAUDIO,
        AV_CODEC_ID_IMC,
        AV_CODEC_ID_MUSEPACK7,
        AV_CODEC_ID_MLP,
        AV_CODEC_ID_GSM_MS,
        AV_CODEC_ID_ATRAC3,
        AV_CODEC_ID_APE,
        AV_CODEC_ID_NELLYMOSER,
        AV_CODEC_ID_MUSEPACK8,
        AV_CODEC_ID_SPEEX,
        AV_CODEC_ID_WMAVOICE,
        AV_CODEC_ID_WMAPRO,
        AV_CODEC_ID_WMALOSSLESS,
        AV_CODEC_ID_ATRAC3P,
        AV_CODEC_ID_EAC3,
        AV_CODEC_ID_SIPR,
        AV_CODEC_ID_MP1,
        AV_CODEC_ID_TWINVQ,
        AV_CODEC_ID_TRUEHD,
        AV_CODEC_ID_MP4ALS,
        AV_CODEC_ID_ATRAC1,
        AV_CODEC_ID_BINKAUDIO_RDFT,
        AV_CODEC_ID_BINKAUDIO_DCT,
        AV_CODEC_ID_AAC_LATM,
        AV_CODEC_ID_QDMC,
        AV_CODEC_ID_CELT,
        AV_CODEC_ID_G723_1,
        AV_CODEC_ID_G729,
        AV_CODEC_ID_8SVX_EXP,
        AV_CODEC_ID_8SVX_FIB,
        AV_CODEC_ID_BMV_AUDIO,
        AV_CODEC_ID_RALF,
        AV_CODEC_ID_IAC,
        AV_CODEC_ID_ILBC,
        AV_CODEC_ID_OPUS,
        AV_CODEC_ID_COMFORT_NOISE,
        AV_CODEC_ID_TAK,
        AV_CODEC_ID_METASOUND,
        AV_CODEC_ID_PAF_AUDIO,
        AV_CODEC_ID_ON2AVC,
        AV_CODEC_ID_DSS_SP,
        AV_CODEC_ID_CODEC2,
        AV_CODEC_ID_FFWAVESYNTH,
        AV_CODEC_ID_SONIC,
        AV_CODEC_ID_SONIC_LS,
        AV_CODEC_ID_EVRC,
        AV_CODEC_ID_SMV,
        AV_CODEC_ID_DSD_LSBF,
        AV_CODEC_ID_DSD_MSBF,
        AV_CODEC_ID_DSD_LSBF_PLANAR,
        AV_CODEC_ID_DSD_MSBF_PLANAR,
        AV_CODEC_ID_4GV,
        AV_CODEC_ID_INTERPLAY_ACM,
        AV_CODEC_ID_XMA1,
        AV_CODEC_ID_XMA2,
        AV_CODEC_ID_DST,
        AV_CODEC_ID_ATRAC3AL,
        AV_CODEC_ID_ATRAC3PAL,
        AV_CODEC_ID_DOLBY_E,
        AV_CODEC_ID_APTX,
        AV_CODEC_ID_APTX_HD,
        AV_CODEC_ID_SBC,
        AV_CODEC_ID_ATRAC9,
        AV_CODEC_ID_HCOM,
        AV_CODEC_ID_ACELP_KELVIN,
        AV_CODEC_ID_MPEGH_3D_AUDIO,
        AV_CODEC_ID_SIREN,
        AV_CODEC_ID_HCA,
        AV_CODEC_ID_FASTAUDIO,
        AV_CODEC_ID_MSNSIREN,
        AV_CODEC_ID_DFPWM,
        AV_CODEC_ID_BONK,
        AV_CODEC_ID_MISC4,
        AV_CODEC_ID_APAC,
        AV_CODEC_ID_FTR,
        AV_CODEC_ID_WAVARC,
        AV_CODEC_ID_RKA,
        AV_CODEC_ID_AC4,
        AV_CODEC_ID_OSQ,
        AV_CODEC_ID_QOA,
        AV_CODEC_ID_LC3,
        AV_CODEC_ID_G728,
        AV_CODEC_ID_AHX,
        AV_CODEC_ID_FIRST_SUBTITLE = 0x17000,
        AV_CODEC_ID_DVD_SUBTITLE = 0x17000,
        AV_CODEC_ID_DVB_SUBTITLE,
        AV_CODEC_ID_TEXT,
        AV_CODEC_ID_XSUB,
        AV_CODEC_ID_SSA,
        AV_CODEC_ID_MOV_TEXT,
        AV_CODEC_ID_HDMV_PGS_SUBTITLE,
        AV_CODEC_ID_DVB_TELETEXT,
        AV_CODEC_ID_SRT,
        AV_CODEC_ID_MICRODVD,
        AV_CODEC_ID_EIA_608,
        AV_CODEC_ID_JACOSUB,
        AV_CODEC_ID_SAMI,
        AV_CODEC_ID_REALTEXT,
        AV_CODEC_ID_STL,
        AV_CODEC_ID_SUBVIEWER1,
        AV_CODEC_ID_SUBVIEWER,
        AV_CODEC_ID_SUBRIP,
        AV_CODEC_ID_WEBVTT,
        AV_CODEC_ID_MPL2,
        AV_CODEC_ID_VPLAYER,
        AV_CODEC_ID_PJS,
        AV_CODEC_ID_ASS,
        AV_CODEC_ID_HDMV_TEXT_SUBTITLE,
        AV_CODEC_ID_TTML,
        AV_CODEC_ID_ARIB_CAPTION,
        AV_CODEC_ID_IVTV_VBI,
        AV_CODEC_ID_FIRST_UNKNOWN = 0x18000,
        AV_CODEC_ID_TTF = 0x18000,
        AV_CODEC_ID_SCTE_35,
        AV_CODEC_ID_EPG,
        AV_CODEC_ID_BINTEXT,
        AV_CODEC_ID_XBIN,
        AV_CODEC_ID_IDF,
        AV_CODEC_ID_OTF,
        AV_CODEC_ID_SMPTE_KLV,
        AV_CODEC_ID_DVD_NAV,
        AV_CODEC_ID_TIMED_ID3,
        AV_CODEC_ID_BIN_DATA,
        AV_CODEC_ID_SMPTE_2038,
        AV_CODEC_ID_LCEVC,
        AV_CODEC_ID_SMPTE_436M_ANC,
        AV_CODEC_ID_PROBE = 0x19000,
        AV_CODEC_ID_MPEG2TS = 0x20000,
        AV_CODEC_ID_MPEG4SYSTEMS = 0x20001,
        AV_CODEC_ID_FFMETADATA = 0x21000,
        AV_CODEC_ID_WRAPPED_AVFRAME = 0x21001,
        AV_CODEC_ID_VNULL,
        AV_CODEC_ID_ANULL,
    }

    public enum AVFieldOrder
    {
        AV_FIELD_UNKNOWN,
        AV_FIELD_PROGRESSIVE,
        AV_FIELD_TT,
        AV_FIELD_BB,
        AV_FIELD_TB,
        AV_FIELD_BT,
    }

    public enum AVDiscard
    {
        AVDISCARD_NONE = -16,
        AVDISCARD_DEFAULT = 0,
        AVDISCARD_NONREF = 8,
        AVDISCARD_BIDIR = 16,
        AVDISCARD_NONINTRA = 24,
        AVDISCARD_NONKEY = 32,
        AVDISCARD_ALL = 48,
    }

    public enum AVAudioServiceType
    {
        AV_AUDIO_SERVICE_TYPE_MAIN = 0,
        AV_AUDIO_SERVICE_TYPE_EFFECTS = 1,
        AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED = 2,
        AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED = 3,
        AV_AUDIO_SERVICE_TYPE_DIALOGUE = 4,
        AV_AUDIO_SERVICE_TYPE_COMMENTARY = 5,
        AV_AUDIO_SERVICE_TYPE_EMERGENCY = 6,
        AV_AUDIO_SERVICE_TYPE_VOICE_OVER = 7,
        AV_AUDIO_SERVICE_TYPE_KARAOKE = 8,
        AV_AUDIO_SERVICE_TYPE_NB,
    }

    public partial struct AVPanScan
    {
        public int id;

        public int width;

        public int height;

        [NativeTypeName("int16_t[3][2]")]
        public _position_e__FixedBuffer position;

        [InlineArray(3 * 2)]
        public partial struct _position_e__FixedBuffer
        {
            public short e0_0;
        }
    }

    public partial struct AVCPBProperties
    {
        [NativeTypeName("int64_t")]
        public long max_bitrate;

        [NativeTypeName("int64_t")]
        public long min_bitrate;

        [NativeTypeName("int64_t")]
        public long avg_bitrate;

        [NativeTypeName("int64_t")]
        public long buffer_size;

        [NativeTypeName("uint64_t")]
        public ulong vbv_delay;
    }

    public partial struct AVProducerReferenceTime
    {
        [NativeTypeName("int64_t")]
        public long wallclock;

        public int flags;
    }

    public partial struct AVRTCPSenderReport
    {
        [NativeTypeName("uint32_t")]
        public uint ssrc;

        [NativeTypeName("uint64_t")]
        public ulong ntp_timestamp;

        [NativeTypeName("uint32_t")]
        public uint rtp_timestamp;

        [NativeTypeName("uint32_t")]
        public uint sender_nb_packets;

        [NativeTypeName("uint32_t")]
        public uint sender_nb_bytes;
    }

    public unsafe partial struct AVCodecDescriptor
    {
        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        public int props;

        [NativeTypeName("const char *const *")]
        public sbyte** mime_types;

        [NativeTypeName("const struct AVProfile *")]
        public AVProfile* profiles;
    }

    public enum AVPacketSideDataType
    {
        AV_PKT_DATA_PALETTE,
        AV_PKT_DATA_NEW_EXTRADATA,
        AV_PKT_DATA_PARAM_CHANGE,
        AV_PKT_DATA_H263_MB_INFO,
        AV_PKT_DATA_REPLAYGAIN,
        AV_PKT_DATA_DISPLAYMATRIX,
        AV_PKT_DATA_STEREO3D,
        AV_PKT_DATA_AUDIO_SERVICE_TYPE,
        AV_PKT_DATA_QUALITY_STATS,
        AV_PKT_DATA_FALLBACK_TRACK,
        AV_PKT_DATA_CPB_PROPERTIES,
        AV_PKT_DATA_SKIP_SAMPLES,
        AV_PKT_DATA_JP_DUALMONO,
        AV_PKT_DATA_STRINGS_METADATA,
        AV_PKT_DATA_SUBTITLE_POSITION,
        AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL,
        AV_PKT_DATA_WEBVTT_IDENTIFIER,
        AV_PKT_DATA_WEBVTT_SETTINGS,
        AV_PKT_DATA_METADATA_UPDATE,
        AV_PKT_DATA_MPEGTS_STREAM_ID,
        AV_PKT_DATA_MASTERING_DISPLAY_METADATA,
        AV_PKT_DATA_SPHERICAL,
        AV_PKT_DATA_CONTENT_LIGHT_LEVEL,
        AV_PKT_DATA_A53_CC,
        AV_PKT_DATA_ENCRYPTION_INIT_INFO,
        AV_PKT_DATA_ENCRYPTION_INFO,
        AV_PKT_DATA_AFD,
        AV_PKT_DATA_PRFT,
        AV_PKT_DATA_ICC_PROFILE,
        AV_PKT_DATA_DOVI_CONF,
        AV_PKT_DATA_S12M_TIMECODE,
        AV_PKT_DATA_DYNAMIC_HDR10_PLUS,
        AV_PKT_DATA_IAMF_MIX_GAIN_PARAM,
        AV_PKT_DATA_IAMF_DEMIXING_INFO_PARAM,
        AV_PKT_DATA_IAMF_RECON_GAIN_INFO_PARAM,
        AV_PKT_DATA_AMBIENT_VIEWING_ENVIRONMENT,
        AV_PKT_DATA_FRAME_CROPPING,
        AV_PKT_DATA_LCEVC,
        AV_PKT_DATA_3D_REFERENCE_DISPLAYS,
        AV_PKT_DATA_RTCP_SR,
        AV_PKT_DATA_EXIF,
        AV_PKT_DATA_NB,
    }

    public unsafe partial struct AVPacketSideData
    {
        [NativeTypeName("uint8_t *")]
        public byte* data;

        [NativeTypeName("size_t")]
        public nuint size;

        [NativeTypeName("enum AVPacketSideDataType")]
        public AVPacketSideDataType type;
    }

    public unsafe partial struct AVPacket
    {
        public AVBufferRef* buf;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        public long dts;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        public int size;

        public int stream_index;

        public int flags;

        public AVPacketSideData* side_data;

        public int side_data_elems;

        [NativeTypeName("int64_t")]
        public long duration;

        [NativeTypeName("int64_t")]
        public long pos;

        public void* opaque;

        public AVBufferRef* opaque_ref;

        public AVRational time_base;
    }

    public unsafe partial struct AVPacketList
    {
        public AVPacket pkt;

        [NativeTypeName("struct AVPacketList *")]
        public AVPacketList* next;
    }

    public enum AVSideDataParamChangeFlags
    {
        AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 0x0004,
        AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 0x0008,
    }

    public unsafe partial struct AVCodecParameters
    {
        [NativeTypeName("enum AVMediaType")]
        public AVMediaType codec_type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID codec_id;

        [NativeTypeName("uint32_t")]
        public uint codec_tag;

        [NativeTypeName("uint8_t *")]
        public byte* extradata;

        public int extradata_size;

        public AVPacketSideData* coded_side_data;

        public int nb_coded_side_data;

        public int format;

        [NativeTypeName("int64_t")]
        public long bit_rate;

        public int bits_per_coded_sample;

        public int bits_per_raw_sample;

        public int profile;

        public int level;

        public int width;

        public int height;

        public AVRational sample_aspect_ratio;

        public AVRational framerate;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace color_space;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_location;

        public int video_delay;

        public AVChannelLayout ch_layout;

        public int sample_rate;

        public int block_align;

        public int frame_size;

        public int initial_padding;

        public int trailing_padding;

        public int seek_preroll;

        [NativeTypeName("enum AVAlphaMode")]
        public AVAlphaMode alpha_mode;
    }

    public unsafe partial struct AVBSFContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("const struct AVBitStreamFilter *")]
        public AVBitStreamFilter* filter;

        public void* priv_data;

        public AVCodecParameters* par_in;

        public AVCodecParameters* par_out;

        public AVRational time_base_in;

        public AVRational time_base_out;
    }

    public unsafe partial struct AVBitStreamFilter
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const enum AVCodecID *")]
        public AVCodecID* codec_ids;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;
    }

    public static unsafe partial class Methods
    {
        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avcodec_version();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avcodec_configuration();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avcodec_license();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodecContext* avcodec_alloc_context3([NativeTypeName("const AVCodec *")] AVCodec* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_free_context(AVCodecContext** avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avcodec_get_class();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avcodec_get_subtitle_rect_class();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_parameters_from_context([NativeTypeName("struct AVCodecParameters *")] AVCodecParameters* par, [NativeTypeName("const AVCodecContext *")] AVCodecContext* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_parameters_to_context(AVCodecContext* codec, [NativeTypeName("const struct AVCodecParameters *")] AVCodecParameters* par);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_open2(AVCodecContext* avctx, [NativeTypeName("const AVCodec *")] AVCodec* codec, AVDictionary** options);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avsubtitle_free(AVSubtitle* sub);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_default_get_buffer2(AVCodecContext* s, AVFrame* frame, int flags);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_default_get_encode_buffer(AVCodecContext* s, AVPacket* pkt, int flags);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_align_dimensions(AVCodecContext* s, int* width, int* height);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_align_dimensions2(AVCodecContext* s, int* width, int* height, [NativeTypeName("int[8]")] int* linesize_align);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_decode_subtitle2(AVCodecContext* avctx, AVSubtitle* sub, int* got_sub_ptr, [NativeTypeName("const AVPacket *")] AVPacket* avpkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_send_packet(AVCodecContext* avctx, [NativeTypeName("const AVPacket *")] AVPacket* avpkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_receive_frame_flags(AVCodecContext* avctx, AVFrame* frame, [NativeTypeName("unsigned int")] uint flags);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_receive_frame(AVCodecContext* avctx, AVFrame* frame);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_send_frame(AVCodecContext* avctx, [NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_receive_packet(AVCodecContext* avctx, AVPacket* avpkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_get_hw_frames_parameters(AVCodecContext* avctx, AVBufferRef* device_ref, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat hw_pix_fmt, AVBufferRef** out_frames_ref);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_get_supported_config([NativeTypeName("const AVCodecContext *")] AVCodecContext* avctx, [NativeTypeName("const AVCodec *")] AVCodec* codec, [NativeTypeName("enum AVCodecConfig")] AVCodecConfig config, [NativeTypeName("unsigned int")] uint flags, [NativeTypeName("const void **")] void** out_configs, int* out_num_configs);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecParser *")]
        public static extern AVCodecParser* av_parser_iterate(void** opaque);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodecParserContext* av_parser_init(int codec_id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_parser_parse2(AVCodecParserContext* s, AVCodecContext* avctx, [NativeTypeName("uint8_t **")] byte** poutbuf, int* poutbuf_size, [NativeTypeName("const uint8_t *")] byte* buf, int buf_size, [NativeTypeName("int64_t")] long pts, [NativeTypeName("int64_t")] long dts, [NativeTypeName("int64_t")] long pos);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_parser_close(AVCodecParserContext* s);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_encode_subtitle(AVCodecContext* avctx, [NativeTypeName("uint8_t *")] byte* buf, int buf_size, [NativeTypeName("const AVSubtitle *")] AVSubtitle* sub);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avcodec_pix_fmt_to_codec_tag([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_list([NativeTypeName("const enum AVPixelFormat *")] AVPixelFormat* pix_fmt_list, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat avcodec_default_get_format([NativeTypeName("struct AVCodecContext *")] AVCodecContext* s, [NativeTypeName("const enum AVPixelFormat *")] AVPixelFormat* fmt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_string([NativeTypeName("char *")] sbyte* buf, int buf_size, AVCodecContext* enc, int encode);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_default_execute(AVCodecContext* c, [NativeTypeName("int (*)(AVCodecContext *, void *)")] delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int> func, void* arg, int* ret, int count, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_default_execute2(AVCodecContext* c, [NativeTypeName("int (*)(AVCodecContext *, void *, int, int)")] delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int, int, int> func, void* arg, int* ret, int count);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_fill_audio_frame(AVFrame* frame, int nb_channels, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt, [NativeTypeName("const uint8_t *")] byte* buf, int buf_size, int align);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_flush_buffers(AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_audio_frame_duration(AVCodecContext* avctx, int frame_bytes);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_fast_padded_malloc(void* ptr, [NativeTypeName("unsigned int *")] uint* size, [NativeTypeName("size_t")] nuint min_size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_fast_padded_mallocz(void* ptr, [NativeTypeName("unsigned int *")] uint* size, [NativeTypeName("size_t")] nuint min_size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_is_open(AVCodecContext* s);

        [NativeTypeName("#define AV_CODEC_FLAG_UNALIGNED (1 <<  0)")]
        public const int AV_CODEC_FLAG_UNALIGNED = (1 << 0);

        [NativeTypeName("#define AV_CODEC_FLAG_QSCALE (1 <<  1)")]
        public const int AV_CODEC_FLAG_QSCALE = (1 << 1);

        [NativeTypeName("#define AV_CODEC_FLAG_4MV (1 <<  2)")]
        public const int AV_CODEC_FLAG_4MV = (1 << 2);

        [NativeTypeName("#define AV_CODEC_FLAG_OUTPUT_CORRUPT (1 <<  3)")]
        public const int AV_CODEC_FLAG_OUTPUT_CORRUPT = (1 << 3);

        [NativeTypeName("#define AV_CODEC_FLAG_QPEL (1 <<  4)")]
        public const int AV_CODEC_FLAG_QPEL = (1 << 4);

        [NativeTypeName("#define AV_CODEC_FLAG_RECON_FRAME (1 <<  6)")]
        public const int AV_CODEC_FLAG_RECON_FRAME = (1 << 6);

        [NativeTypeName("#define AV_CODEC_FLAG_COPY_OPAQUE (1 <<  7)")]
        public const int AV_CODEC_FLAG_COPY_OPAQUE = (1 << 7);

        [NativeTypeName("#define AV_CODEC_FLAG_FRAME_DURATION (1 <<  8)")]
        public const int AV_CODEC_FLAG_FRAME_DURATION = (1 << 8);

        [NativeTypeName("#define AV_CODEC_FLAG_PASS1 (1 <<  9)")]
        public const int AV_CODEC_FLAG_PASS1 = (1 << 9);

        [NativeTypeName("#define AV_CODEC_FLAG_PASS2 (1 << 10)")]
        public const int AV_CODEC_FLAG_PASS2 = (1 << 10);

        [NativeTypeName("#define AV_CODEC_FLAG_LOOP_FILTER (1 << 11)")]
        public const int AV_CODEC_FLAG_LOOP_FILTER = (1 << 11);

        [NativeTypeName("#define AV_CODEC_FLAG_GRAY (1 << 13)")]
        public const int AV_CODEC_FLAG_GRAY = (1 << 13);

        [NativeTypeName("#define AV_CODEC_FLAG_PSNR (1 << 15)")]
        public const int AV_CODEC_FLAG_PSNR = (1 << 15);

        [NativeTypeName("#define AV_CODEC_FLAG_INTERLACED_DCT (1 << 18)")]
        public const int AV_CODEC_FLAG_INTERLACED_DCT = (1 << 18);

        [NativeTypeName("#define AV_CODEC_FLAG_LOW_DELAY (1 << 19)")]
        public const int AV_CODEC_FLAG_LOW_DELAY = (1 << 19);

        [NativeTypeName("#define AV_CODEC_FLAG_GLOBAL_HEADER (1 << 22)")]
        public const int AV_CODEC_FLAG_GLOBAL_HEADER = (1 << 22);

        [NativeTypeName("#define AV_CODEC_FLAG_BITEXACT (1 << 23)")]
        public const int AV_CODEC_FLAG_BITEXACT = (1 << 23);

        [NativeTypeName("#define AV_CODEC_FLAG_AC_PRED (1 << 24)")]
        public const int AV_CODEC_FLAG_AC_PRED = (1 << 24);

        [NativeTypeName("#define AV_CODEC_FLAG_INTERLACED_ME (1 << 29)")]
        public const int AV_CODEC_FLAG_INTERLACED_ME = (1 << 29);

        [NativeTypeName("#define AV_CODEC_FLAG_CLOSED_GOP (1U << 31)")]
        public const uint AV_CODEC_FLAG_CLOSED_GOP = (1U << 31);

        [NativeTypeName("#define AV_CODEC_FLAG2_FAST (1 <<  0)")]
        public const int AV_CODEC_FLAG2_FAST = (1 << 0);

        [NativeTypeName("#define AV_CODEC_FLAG2_NO_OUTPUT (1 <<  2)")]
        public const int AV_CODEC_FLAG2_NO_OUTPUT = (1 << 2);

        [NativeTypeName("#define AV_CODEC_FLAG2_LOCAL_HEADER (1 <<  3)")]
        public const int AV_CODEC_FLAG2_LOCAL_HEADER = (1 << 3);

        [NativeTypeName("#define AV_CODEC_FLAG2_CHUNKS (1 << 15)")]
        public const int AV_CODEC_FLAG2_CHUNKS = (1 << 15);

        [NativeTypeName("#define AV_CODEC_FLAG2_IGNORE_CROP (1 << 16)")]
        public const int AV_CODEC_FLAG2_IGNORE_CROP = (1 << 16);

        [NativeTypeName("#define AV_CODEC_FLAG2_SHOW_ALL (1 << 22)")]
        public const int AV_CODEC_FLAG2_SHOW_ALL = (1 << 22);

        [NativeTypeName("#define AV_CODEC_FLAG2_EXPORT_MVS (1 << 28)")]
        public const int AV_CODEC_FLAG2_EXPORT_MVS = (1 << 28);

        [NativeTypeName("#define AV_CODEC_FLAG2_SKIP_MANUAL (1 << 29)")]
        public const int AV_CODEC_FLAG2_SKIP_MANUAL = (1 << 29);

        [NativeTypeName("#define AV_CODEC_FLAG2_RO_FLUSH_NOOP (1 << 30)")]
        public const int AV_CODEC_FLAG2_RO_FLUSH_NOOP = (1 << 30);

        [NativeTypeName("#define AV_CODEC_FLAG2_ICC_PROFILES (1U << 31)")]
        public const uint AV_CODEC_FLAG2_ICC_PROFILES = (1U << 31);

        [NativeTypeName("#define AV_CODEC_EXPORT_DATA_MVS (1 << 0)")]
        public const int AV_CODEC_EXPORT_DATA_MVS = (1 << 0);

        [NativeTypeName("#define AV_CODEC_EXPORT_DATA_PRFT (1 << 1)")]
        public const int AV_CODEC_EXPORT_DATA_PRFT = (1 << 1);

        [NativeTypeName("#define AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS (1 << 2)")]
        public const int AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS = (1 << 2);

        [NativeTypeName("#define AV_CODEC_EXPORT_DATA_FILM_GRAIN (1 << 3)")]
        public const int AV_CODEC_EXPORT_DATA_FILM_GRAIN = (1 << 3);

        [NativeTypeName("#define AV_CODEC_EXPORT_DATA_ENHANCEMENTS (1 << 4)")]
        public const int AV_CODEC_EXPORT_DATA_ENHANCEMENTS = (1 << 4);

        [NativeTypeName("#define AV_GET_BUFFER_FLAG_REF (1 << 0)")]
        public const int AV_GET_BUFFER_FLAG_REF = (1 << 0);

        [NativeTypeName("#define AV_GET_ENCODE_BUFFER_FLAG_REF (1 << 0)")]
        public const int AV_GET_ENCODE_BUFFER_FLAG_REF = (1 << 0);

        [NativeTypeName("#define AV_CODEC_RECEIVE_FRAME_FLAG_SYNCHRONOUS (1 << 0)")]
        public const int AV_CODEC_RECEIVE_FRAME_FLAG_SYNCHRONOUS = (1 << 0);

        [NativeTypeName("#define SLICE_FLAG_CODED_ORDER 0x0001")]
        public const int SLICE_FLAG_CODED_ORDER = 0x0001;

        [NativeTypeName("#define SLICE_FLAG_ALLOW_FIELD 0x0002")]
        public const int SLICE_FLAG_ALLOW_FIELD = 0x0002;

        [NativeTypeName("#define SLICE_FLAG_ALLOW_PLANE 0x0004")]
        public const int SLICE_FLAG_ALLOW_PLANE = 0x0004;

        [NativeTypeName("#define FF_CMP_SAD 0")]
        public const int FF_CMP_SAD = 0;

        [NativeTypeName("#define FF_CMP_SSE 1")]
        public const int FF_CMP_SSE = 1;

        [NativeTypeName("#define FF_CMP_SATD 2")]
        public const int FF_CMP_SATD = 2;

        [NativeTypeName("#define FF_CMP_DCT 3")]
        public const int FF_CMP_DCT = 3;

        [NativeTypeName("#define FF_CMP_PSNR 4")]
        public const int FF_CMP_PSNR = 4;

        [NativeTypeName("#define FF_CMP_BIT 5")]
        public const int FF_CMP_BIT = 5;

        [NativeTypeName("#define FF_CMP_RD 6")]
        public const int FF_CMP_RD = 6;

        [NativeTypeName("#define FF_CMP_ZERO 7")]
        public const int FF_CMP_ZERO = 7;

        [NativeTypeName("#define FF_CMP_VSAD 8")]
        public const int FF_CMP_VSAD = 8;

        [NativeTypeName("#define FF_CMP_VSSE 9")]
        public const int FF_CMP_VSSE = 9;

        [NativeTypeName("#define FF_CMP_NSSE 10")]
        public const int FF_CMP_NSSE = 10;

        [NativeTypeName("#define FF_CMP_W53 11")]
        public const int FF_CMP_W53 = 11;

        [NativeTypeName("#define FF_CMP_W97 12")]
        public const int FF_CMP_W97 = 12;

        [NativeTypeName("#define FF_CMP_DCTMAX 13")]
        public const int FF_CMP_DCTMAX = 13;

        [NativeTypeName("#define FF_CMP_DCT264 14")]
        public const int FF_CMP_DCT264 = 14;

        [NativeTypeName("#define FF_CMP_MEDIAN_SAD 15")]
        public const int FF_CMP_MEDIAN_SAD = 15;

        [NativeTypeName("#define FF_CMP_CHROMA 256")]
        public const int FF_CMP_CHROMA = 256;

        [NativeTypeName("#define FF_MB_DECISION_SIMPLE 0")]
        public const int FF_MB_DECISION_SIMPLE = 0;

        [NativeTypeName("#define FF_MB_DECISION_BITS 1")]
        public const int FF_MB_DECISION_BITS = 1;

        [NativeTypeName("#define FF_MB_DECISION_RD 2")]
        public const int FF_MB_DECISION_RD = 2;

        [NativeTypeName("#define FF_COMPRESSION_DEFAULT -1")]
        public const int FF_COMPRESSION_DEFAULT = -1;

        [NativeTypeName("#define FF_BUG_AUTODETECT 1")]
        public const int FF_BUG_AUTODETECT = 1;

        [NativeTypeName("#define FF_BUG_XVID_ILACE 4")]
        public const int FF_BUG_XVID_ILACE = 4;

        [NativeTypeName("#define FF_BUG_UMP4 8")]
        public const int FF_BUG_UMP4 = 8;

        [NativeTypeName("#define FF_BUG_NO_PADDING 16")]
        public const int FF_BUG_NO_PADDING = 16;

        [NativeTypeName("#define FF_BUG_AMV 32")]
        public const int FF_BUG_AMV = 32;

        [NativeTypeName("#define FF_BUG_QPEL_CHROMA 64")]
        public const int FF_BUG_QPEL_CHROMA = 64;

        [NativeTypeName("#define FF_BUG_STD_QPEL 128")]
        public const int FF_BUG_STD_QPEL = 128;

        [NativeTypeName("#define FF_BUG_QPEL_CHROMA2 256")]
        public const int FF_BUG_QPEL_CHROMA2 = 256;

        [NativeTypeName("#define FF_BUG_DIRECT_BLOCKSIZE 512")]
        public const int FF_BUG_DIRECT_BLOCKSIZE = 512;

        [NativeTypeName("#define FF_BUG_EDGE 1024")]
        public const int FF_BUG_EDGE = 1024;

        [NativeTypeName("#define FF_BUG_HPEL_CHROMA 2048")]
        public const int FF_BUG_HPEL_CHROMA = 2048;

        [NativeTypeName("#define FF_BUG_DC_CLIP 4096")]
        public const int FF_BUG_DC_CLIP = 4096;

        [NativeTypeName("#define FF_BUG_MS 8192")]
        public const int FF_BUG_MS = 8192;

        [NativeTypeName("#define FF_BUG_TRUNCATED 16384")]
        public const int FF_BUG_TRUNCATED = 16384;

        [NativeTypeName("#define FF_BUG_IEDGE 32768")]
        public const int FF_BUG_IEDGE = 32768;

        [NativeTypeName("#define FF_EC_GUESS_MVS 1")]
        public const int FF_EC_GUESS_MVS = 1;

        [NativeTypeName("#define FF_EC_DEBLOCK 2")]
        public const int FF_EC_DEBLOCK = 2;

        [NativeTypeName("#define FF_EC_FAVOR_INTER 256")]
        public const int FF_EC_FAVOR_INTER = 256;

        [NativeTypeName("#define FF_DEBUG_PICT_INFO 1")]
        public const int FF_DEBUG_PICT_INFO = 1;

        [NativeTypeName("#define FF_DEBUG_RC 2")]
        public const int FF_DEBUG_RC = 2;

        [NativeTypeName("#define FF_DEBUG_BITSTREAM 4")]
        public const int FF_DEBUG_BITSTREAM = 4;

        [NativeTypeName("#define FF_DEBUG_MB_TYPE 8")]
        public const int FF_DEBUG_MB_TYPE = 8;

        [NativeTypeName("#define FF_DEBUG_QP 16")]
        public const int FF_DEBUG_QP = 16;

        [NativeTypeName("#define FF_DEBUG_DCT_COEFF 0x00000040")]
        public const int FF_DEBUG_DCT_COEFF = 0x00000040;

        [NativeTypeName("#define FF_DEBUG_SKIP 0x00000080")]
        public const int FF_DEBUG_SKIP = 0x00000080;

        [NativeTypeName("#define FF_DEBUG_STARTCODE 0x00000100")]
        public const int FF_DEBUG_STARTCODE = 0x00000100;

        [NativeTypeName("#define FF_DEBUG_ER 0x00000400")]
        public const int FF_DEBUG_ER = 0x00000400;

        [NativeTypeName("#define FF_DEBUG_MMCO 0x00000800")]
        public const int FF_DEBUG_MMCO = 0x00000800;

        [NativeTypeName("#define FF_DEBUG_BUGS 0x00001000")]
        public const int FF_DEBUG_BUGS = 0x00001000;

        [NativeTypeName("#define FF_DEBUG_BUFFERS 0x00008000")]
        public const int FF_DEBUG_BUFFERS = 0x00008000;

        [NativeTypeName("#define FF_DEBUG_THREADS 0x00010000")]
        public const int FF_DEBUG_THREADS = 0x00010000;

        [NativeTypeName("#define FF_DEBUG_GREEN_MD 0x00800000")]
        public const int FF_DEBUG_GREEN_MD = 0x00800000;

        [NativeTypeName("#define FF_DEBUG_NOMC 0x01000000")]
        public const int FF_DEBUG_NOMC = 0x01000000;

        [NativeTypeName("#define FF_DCT_AUTO 0")]
        public const int FF_DCT_AUTO = 0;

        [NativeTypeName("#define FF_DCT_FASTINT 1")]
        public const int FF_DCT_FASTINT = 1;

        [NativeTypeName("#define FF_DCT_INT 2")]
        public const int FF_DCT_INT = 2;

        [NativeTypeName("#define FF_DCT_MMX 3")]
        public const int FF_DCT_MMX = 3;

        [NativeTypeName("#define FF_DCT_ALTIVEC 5")]
        public const int FF_DCT_ALTIVEC = 5;

        [NativeTypeName("#define FF_DCT_FAAN 6")]
        public const int FF_DCT_FAAN = 6;

        [NativeTypeName("#define FF_DCT_NEON 7")]
        public const int FF_DCT_NEON = 7;

        [NativeTypeName("#define FF_IDCT_AUTO 0")]
        public const int FF_IDCT_AUTO = 0;

        [NativeTypeName("#define FF_IDCT_INT 1")]
        public const int FF_IDCT_INT = 1;

        [NativeTypeName("#define FF_IDCT_SIMPLE 2")]
        public const int FF_IDCT_SIMPLE = 2;

        [NativeTypeName("#define FF_IDCT_SIMPLEMMX 3")]
        public const int FF_IDCT_SIMPLEMMX = 3;

        [NativeTypeName("#define FF_IDCT_ARM 7")]
        public const int FF_IDCT_ARM = 7;

        [NativeTypeName("#define FF_IDCT_ALTIVEC 8")]
        public const int FF_IDCT_ALTIVEC = 8;

        [NativeTypeName("#define FF_IDCT_SIMPLEARM 10")]
        public const int FF_IDCT_SIMPLEARM = 10;

        [NativeTypeName("#define FF_IDCT_XVID 14")]
        public const int FF_IDCT_XVID = 14;

        [NativeTypeName("#define FF_IDCT_SIMPLEARMV5TE 16")]
        public const int FF_IDCT_SIMPLEARMV5TE = 16;

        [NativeTypeName("#define FF_IDCT_SIMPLEARMV6 17")]
        public const int FF_IDCT_SIMPLEARMV6 = 17;

        [NativeTypeName("#define FF_IDCT_FAAN 20")]
        public const int FF_IDCT_FAAN = 20;

        [NativeTypeName("#define FF_IDCT_SIMPLENEON 22")]
        public const int FF_IDCT_SIMPLENEON = 22;

        [NativeTypeName("#define FF_IDCT_SIMPLEAUTO 128")]
        public const int FF_IDCT_SIMPLEAUTO = 128;

        [NativeTypeName("#define FF_THREAD_FRAME 1")]
        public const int FF_THREAD_FRAME = 1;

        [NativeTypeName("#define FF_THREAD_SLICE 2")]
        public const int FF_THREAD_SLICE = 2;

        [NativeTypeName("#define FF_CODEC_PROPERTY_LOSSLESS 0x00000001")]
        public const int FF_CODEC_PROPERTY_LOSSLESS = 0x00000001;

        [NativeTypeName("#define FF_CODEC_PROPERTY_CLOSED_CAPTIONS 0x00000002")]
        public const int FF_CODEC_PROPERTY_CLOSED_CAPTIONS = 0x00000002;

        [NativeTypeName("#define FF_CODEC_PROPERTY_FILM_GRAIN 0x00000004")]
        public const int FF_CODEC_PROPERTY_FILM_GRAIN = 0x00000004;

        [NativeTypeName("#define FF_SUB_CHARENC_MODE_DO_NOTHING -1")]
        public const int FF_SUB_CHARENC_MODE_DO_NOTHING = -1;

        [NativeTypeName("#define FF_SUB_CHARENC_MODE_AUTOMATIC 0")]
        public const int FF_SUB_CHARENC_MODE_AUTOMATIC = 0;

        [NativeTypeName("#define FF_SUB_CHARENC_MODE_PRE_DECODER 1")]
        public const int FF_SUB_CHARENC_MODE_PRE_DECODER = 1;

        [NativeTypeName("#define FF_SUB_CHARENC_MODE_IGNORE 2")]
        public const int FF_SUB_CHARENC_MODE_IGNORE = 2;

        [NativeTypeName("#define AV_HWACCEL_CODEC_CAP_EXPERIMENTAL 0x0200")]
        public const int AV_HWACCEL_CODEC_CAP_EXPERIMENTAL = 0x0200;

        [NativeTypeName("#define AV_HWACCEL_FLAG_IGNORE_LEVEL (1 << 0)")]
        public const int AV_HWACCEL_FLAG_IGNORE_LEVEL = (1 << 0);

        [NativeTypeName("#define AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH (1 << 1)")]
        public const int AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH = (1 << 1);

        [NativeTypeName("#define AV_HWACCEL_FLAG_ALLOW_PROFILE_MISMATCH (1 << 2)")]
        public const int AV_HWACCEL_FLAG_ALLOW_PROFILE_MISMATCH = (1 << 2);

        [NativeTypeName("#define AV_HWACCEL_FLAG_UNSAFE_OUTPUT (1 << 3)")]
        public const int AV_HWACCEL_FLAG_UNSAFE_OUTPUT = (1 << 3);

        [NativeTypeName("#define AV_SUBTITLE_FLAG_FORCED 0x00000001")]
        public const int AV_SUBTITLE_FLAG_FORCED = 0x00000001;

        [NativeTypeName("#define AV_PARSER_PTS_NB 4")]
        public const int AV_PARSER_PTS_NB = 4;

        [NativeTypeName("#define PARSER_FLAG_COMPLETE_FRAMES 0x0001")]
        public const int PARSER_FLAG_COMPLETE_FRAMES = 0x0001;

        [NativeTypeName("#define PARSER_FLAG_ONCE 0x0002")]
        public const int PARSER_FLAG_ONCE = 0x0002;

        [NativeTypeName("#define PARSER_FLAG_FETCHED_OFFSET 0x0004")]
        public const int PARSER_FLAG_FETCHED_OFFSET = 0x0004;

        [NativeTypeName("#define PARSER_FLAG_USE_CODEC_TS 0x1000")]
        public const int PARSER_FLAG_USE_CODEC_TS = 0x1000;

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodec *")]
        public static extern AVCodec* av_codec_iterate(void** opaque);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodec *")]
        public static extern AVCodec* avcodec_find_decoder([NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodec *")]
        public static extern AVCodec* avcodec_find_decoder_by_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodec *")]
        public static extern AVCodec* avcodec_find_encoder([NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodec *")]
        public static extern AVCodec* avcodec_find_encoder_by_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_codec_is_encoder([NativeTypeName("const AVCodec *")] AVCodec* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_codec_is_decoder([NativeTypeName("const AVCodec *")] AVCodec* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_get_profile_name([NativeTypeName("const AVCodec *")] AVCodec* codec, int profile);

        public const int AV_CODEC_HW_CONFIG_METHOD_HW_DEVICE_CTX = 0x01;
        public const int AV_CODEC_HW_CONFIG_METHOD_HW_FRAMES_CTX = 0x02;
        public const int AV_CODEC_HW_CONFIG_METHOD_INTERNAL = 0x04;
        public const int AV_CODEC_HW_CONFIG_METHOD_AD_HOC = 0x08;

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecHWConfig *")]
        public static extern AVCodecHWConfig* avcodec_get_hw_config([NativeTypeName("const AVCodec *")] AVCodec* codec, int index);

        [NativeTypeName("#define AV_CODEC_CAP_DRAW_HORIZ_BAND (1 <<  0)")]
        public const int AV_CODEC_CAP_DRAW_HORIZ_BAND = (1 << 0);

        [NativeTypeName("#define AV_CODEC_CAP_DR1 (1 <<  1)")]
        public const int AV_CODEC_CAP_DR1 = (1 << 1);

        [NativeTypeName("#define AV_CODEC_CAP_DELAY (1 <<  5)")]
        public const int AV_CODEC_CAP_DELAY = (1 << 5);

        [NativeTypeName("#define AV_CODEC_CAP_SMALL_LAST_FRAME (1 <<  6)")]
        public const int AV_CODEC_CAP_SMALL_LAST_FRAME = (1 << 6);

        [NativeTypeName("#define AV_CODEC_CAP_EXPERIMENTAL (1 <<  9)")]
        public const int AV_CODEC_CAP_EXPERIMENTAL = (1 << 9);

        [NativeTypeName("#define AV_CODEC_CAP_CHANNEL_CONF (1 << 10)")]
        public const int AV_CODEC_CAP_CHANNEL_CONF = (1 << 10);

        [NativeTypeName("#define AV_CODEC_CAP_FRAME_THREADS (1 << 12)")]
        public const int AV_CODEC_CAP_FRAME_THREADS = (1 << 12);

        [NativeTypeName("#define AV_CODEC_CAP_SLICE_THREADS (1 << 13)")]
        public const int AV_CODEC_CAP_SLICE_THREADS = (1 << 13);

        [NativeTypeName("#define AV_CODEC_CAP_PARAM_CHANGE (1 << 14)")]
        public const int AV_CODEC_CAP_PARAM_CHANGE = (1 << 14);

        [NativeTypeName("#define AV_CODEC_CAP_OTHER_THREADS (1 << 15)")]
        public const int AV_CODEC_CAP_OTHER_THREADS = (1 << 15);

        [NativeTypeName("#define AV_CODEC_CAP_VARIABLE_FRAME_SIZE (1 << 16)")]
        public const int AV_CODEC_CAP_VARIABLE_FRAME_SIZE = (1 << 16);

        [NativeTypeName("#define AV_CODEC_CAP_AVOID_PROBING (1 << 17)")]
        public const int AV_CODEC_CAP_AVOID_PROBING = (1 << 17);

        [NativeTypeName("#define AV_CODEC_CAP_HARDWARE (1 << 18)")]
        public const int AV_CODEC_CAP_HARDWARE = (1 << 18);

        [NativeTypeName("#define AV_CODEC_CAP_HYBRID (1 << 19)")]
        public const int AV_CODEC_CAP_HYBRID = (1 << 19);

        [NativeTypeName("#define AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE (1 << 20)")]
        public const int AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE = (1 << 20);

        [NativeTypeName("#define AV_CODEC_CAP_ENCODER_FLUSH (1 << 21)")]
        public const int AV_CODEC_CAP_ENCODER_FLUSH = (1 << 21);

        [NativeTypeName("#define AV_CODEC_CAP_ENCODER_RECON_FRAME (1 << 22)")]
        public const int AV_CODEC_CAP_ENCODER_RECON_FRAME = (1 << 22);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVMediaType")]
        public static extern AVMediaType avcodec_get_type([NativeTypeName("enum AVCodecID")] AVCodecID codec_id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avcodec_get_name([NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_bits_per_sample([NativeTypeName("enum AVCodecID")] AVCodecID codec_id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_exact_bits_per_sample([NativeTypeName("enum AVCodecID")] AVCodecID codec_id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avcodec_profile_name([NativeTypeName("enum AVCodecID")] AVCodecID codec_id, int profile);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVCodecID")]
        public static extern AVCodecID av_get_pcm_codec([NativeTypeName("enum AVSampleFormat")] AVSampleFormat fmt, int be);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCPBProperties* av_cpb_properties_alloc([NativeTypeName("size_t *")] nuint* size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint av_xiphlacing([NativeTypeName("unsigned char *")] byte* s, [NativeTypeName("unsigned int")] uint v);

        [NativeTypeName("#define AV_INPUT_BUFFER_PADDING_SIZE 64")]
        public const int AV_INPUT_BUFFER_PADDING_SIZE = 64;

        [NativeTypeName("#define AV_EF_CRCCHECK (1<<0)")]
        public const int AV_EF_CRCCHECK = (1 << 0);

        [NativeTypeName("#define AV_EF_BITSTREAM (1<<1)")]
        public const int AV_EF_BITSTREAM = (1 << 1);

        [NativeTypeName("#define AV_EF_BUFFER (1<<2)")]
        public const int AV_EF_BUFFER = (1 << 2);

        [NativeTypeName("#define AV_EF_EXPLODE (1<<3)")]
        public const int AV_EF_EXPLODE = (1 << 3);

        [NativeTypeName("#define AV_EF_IGNORE_ERR (1<<15)")]
        public const int AV_EF_IGNORE_ERR = (1 << 15);

        [NativeTypeName("#define AV_EF_CAREFUL (1<<16)")]
        public const int AV_EF_CAREFUL = (1 << 16);

        [NativeTypeName("#define AV_EF_COMPLIANT (1<<17)")]
        public const int AV_EF_COMPLIANT = (1 << 17);

        [NativeTypeName("#define AV_EF_AGGRESSIVE (1<<18)")]
        public const int AV_EF_AGGRESSIVE = (1 << 18);

        [NativeTypeName("#define FF_COMPLIANCE_VERY_STRICT 2")]
        public const int FF_COMPLIANCE_VERY_STRICT = 2;

        [NativeTypeName("#define FF_COMPLIANCE_STRICT 1")]
        public const int FF_COMPLIANCE_STRICT = 1;

        [NativeTypeName("#define FF_COMPLIANCE_NORMAL 0")]
        public const int FF_COMPLIANCE_NORMAL = 0;

        [NativeTypeName("#define FF_COMPLIANCE_UNOFFICIAL -1")]
        public const int FF_COMPLIANCE_UNOFFICIAL = -1;

        [NativeTypeName("#define FF_COMPLIANCE_EXPERIMENTAL -2")]
        public const int FF_COMPLIANCE_EXPERIMENTAL = -2;

        [NativeTypeName("#define AV_PROFILE_UNKNOWN -99")]
        public const int AV_PROFILE_UNKNOWN = -99;

        [NativeTypeName("#define AV_PROFILE_RESERVED -100")]
        public const int AV_PROFILE_RESERVED = -100;

        [NativeTypeName("#define AV_PROFILE_AAC_MAIN 0")]
        public const int AV_PROFILE_AAC_MAIN = 0;

        [NativeTypeName("#define AV_PROFILE_AAC_LOW 1")]
        public const int AV_PROFILE_AAC_LOW = 1;

        [NativeTypeName("#define AV_PROFILE_AAC_SSR 2")]
        public const int AV_PROFILE_AAC_SSR = 2;

        [NativeTypeName("#define AV_PROFILE_AAC_LTP 3")]
        public const int AV_PROFILE_AAC_LTP = 3;

        [NativeTypeName("#define AV_PROFILE_AAC_HE 4")]
        public const int AV_PROFILE_AAC_HE = 4;

        [NativeTypeName("#define AV_PROFILE_AAC_HE_V2 28")]
        public const int AV_PROFILE_AAC_HE_V2 = 28;

        [NativeTypeName("#define AV_PROFILE_AAC_LD 22")]
        public const int AV_PROFILE_AAC_LD = 22;

        [NativeTypeName("#define AV_PROFILE_AAC_ELD 38")]
        public const int AV_PROFILE_AAC_ELD = 38;

        [NativeTypeName("#define AV_PROFILE_AAC_USAC 41")]
        public const int AV_PROFILE_AAC_USAC = 41;

        [NativeTypeName("#define AV_PROFILE_MPEG2_AAC_LOW 128")]
        public const int AV_PROFILE_MPEG2_AAC_LOW = 128;

        [NativeTypeName("#define AV_PROFILE_MPEG2_AAC_HE 131")]
        public const int AV_PROFILE_MPEG2_AAC_HE = 131;

        [NativeTypeName("#define AV_PROFILE_DNXHD 0")]
        public const int AV_PROFILE_DNXHD = 0;

        [NativeTypeName("#define AV_PROFILE_DNXHR_LB 1")]
        public const int AV_PROFILE_DNXHR_LB = 1;

        [NativeTypeName("#define AV_PROFILE_DNXHR_SQ 2")]
        public const int AV_PROFILE_DNXHR_SQ = 2;

        [NativeTypeName("#define AV_PROFILE_DNXHR_HQ 3")]
        public const int AV_PROFILE_DNXHR_HQ = 3;

        [NativeTypeName("#define AV_PROFILE_DNXHR_HQX 4")]
        public const int AV_PROFILE_DNXHR_HQX = 4;

        [NativeTypeName("#define AV_PROFILE_DNXHR_444 5")]
        public const int AV_PROFILE_DNXHR_444 = 5;

        [NativeTypeName("#define AV_PROFILE_DTS 20")]
        public const int AV_PROFILE_DTS = 20;

        [NativeTypeName("#define AV_PROFILE_DTS_ES 30")]
        public const int AV_PROFILE_DTS_ES = 30;

        [NativeTypeName("#define AV_PROFILE_DTS_96_24 40")]
        public const int AV_PROFILE_DTS_96_24 = 40;

        [NativeTypeName("#define AV_PROFILE_DTS_HD_HRA 50")]
        public const int AV_PROFILE_DTS_HD_HRA = 50;

        [NativeTypeName("#define AV_PROFILE_DTS_HD_MA 60")]
        public const int AV_PROFILE_DTS_HD_MA = 60;

        [NativeTypeName("#define AV_PROFILE_DTS_EXPRESS 70")]
        public const int AV_PROFILE_DTS_EXPRESS = 70;

        [NativeTypeName("#define AV_PROFILE_DTS_HD_MA_X 61")]
        public const int AV_PROFILE_DTS_HD_MA_X = 61;

        [NativeTypeName("#define AV_PROFILE_DTS_HD_MA_X_IMAX 62")]
        public const int AV_PROFILE_DTS_HD_MA_X_IMAX = 62;

        [NativeTypeName("#define AV_PROFILE_EAC3_DDP_ATMOS 30")]
        public const int AV_PROFILE_EAC3_DDP_ATMOS = 30;

        [NativeTypeName("#define AV_PROFILE_TRUEHD_ATMOS 30")]
        public const int AV_PROFILE_TRUEHD_ATMOS = 30;

        [NativeTypeName("#define AV_PROFILE_MPEG2_422 0")]
        public const int AV_PROFILE_MPEG2_422 = 0;

        [NativeTypeName("#define AV_PROFILE_MPEG2_HIGH 1")]
        public const int AV_PROFILE_MPEG2_HIGH = 1;

        [NativeTypeName("#define AV_PROFILE_MPEG2_SS 2")]
        public const int AV_PROFILE_MPEG2_SS = 2;

        [NativeTypeName("#define AV_PROFILE_MPEG2_SNR_SCALABLE 3")]
        public const int AV_PROFILE_MPEG2_SNR_SCALABLE = 3;

        [NativeTypeName("#define AV_PROFILE_MPEG2_MAIN 4")]
        public const int AV_PROFILE_MPEG2_MAIN = 4;

        [NativeTypeName("#define AV_PROFILE_MPEG2_SIMPLE 5")]
        public const int AV_PROFILE_MPEG2_SIMPLE = 5;

        [NativeTypeName("#define AV_PROFILE_H264_CONSTRAINED (1<<9)")]
        public const int AV_PROFILE_H264_CONSTRAINED = (1 << 9);

        [NativeTypeName("#define AV_PROFILE_H264_INTRA (1<<11)")]
        public const int AV_PROFILE_H264_INTRA = (1 << 11);

        [NativeTypeName("#define AV_PROFILE_H264_BASELINE 66")]
        public const int AV_PROFILE_H264_BASELINE = 66;

        [NativeTypeName("#define AV_PROFILE_H264_CONSTRAINED_BASELINE (66|AV_PROFILE_H264_CONSTRAINED)")]
        public const int AV_PROFILE_H264_CONSTRAINED_BASELINE = (66 | (1 << 9));

        [NativeTypeName("#define AV_PROFILE_H264_MAIN 77")]
        public const int AV_PROFILE_H264_MAIN = 77;

        [NativeTypeName("#define AV_PROFILE_H264_EXTENDED 88")]
        public const int AV_PROFILE_H264_EXTENDED = 88;

        [NativeTypeName("#define AV_PROFILE_H264_HIGH 100")]
        public const int AV_PROFILE_H264_HIGH = 100;

        [NativeTypeName("#define AV_PROFILE_H264_HIGH_10 110")]
        public const int AV_PROFILE_H264_HIGH_10 = 110;

        [NativeTypeName("#define AV_PROFILE_H264_HIGH_10_INTRA (110|AV_PROFILE_H264_INTRA)")]
        public const int AV_PROFILE_H264_HIGH_10_INTRA = (110 | (1 << 11));

        [NativeTypeName("#define AV_PROFILE_H264_MULTIVIEW_HIGH 118")]
        public const int AV_PROFILE_H264_MULTIVIEW_HIGH = 118;

        [NativeTypeName("#define AV_PROFILE_H264_HIGH_422 122")]
        public const int AV_PROFILE_H264_HIGH_422 = 122;

        [NativeTypeName("#define AV_PROFILE_H264_HIGH_422_INTRA (122|AV_PROFILE_H264_INTRA)")]
        public const int AV_PROFILE_H264_HIGH_422_INTRA = (122 | (1 << 11));

        [NativeTypeName("#define AV_PROFILE_H264_STEREO_HIGH 128")]
        public const int AV_PROFILE_H264_STEREO_HIGH = 128;

        [NativeTypeName("#define AV_PROFILE_H264_HIGH_444 144")]
        public const int AV_PROFILE_H264_HIGH_444 = 144;

        [NativeTypeName("#define AV_PROFILE_H264_HIGH_444_PREDICTIVE 244")]
        public const int AV_PROFILE_H264_HIGH_444_PREDICTIVE = 244;

        [NativeTypeName("#define AV_PROFILE_H264_HIGH_444_INTRA (244|AV_PROFILE_H264_INTRA)")]
        public const int AV_PROFILE_H264_HIGH_444_INTRA = (244 | (1 << 11));

        [NativeTypeName("#define AV_PROFILE_H264_CAVLC_444 44")]
        public const int AV_PROFILE_H264_CAVLC_444 = 44;

        [NativeTypeName("#define AV_PROFILE_VC1_SIMPLE 0")]
        public const int AV_PROFILE_VC1_SIMPLE = 0;

        [NativeTypeName("#define AV_PROFILE_VC1_MAIN 1")]
        public const int AV_PROFILE_VC1_MAIN = 1;

        [NativeTypeName("#define AV_PROFILE_VC1_COMPLEX 2")]
        public const int AV_PROFILE_VC1_COMPLEX = 2;

        [NativeTypeName("#define AV_PROFILE_VC1_ADVANCED 3")]
        public const int AV_PROFILE_VC1_ADVANCED = 3;

        [NativeTypeName("#define AV_PROFILE_MPEG4_SIMPLE 0")]
        public const int AV_PROFILE_MPEG4_SIMPLE = 0;

        [NativeTypeName("#define AV_PROFILE_MPEG4_SIMPLE_SCALABLE 1")]
        public const int AV_PROFILE_MPEG4_SIMPLE_SCALABLE = 1;

        [NativeTypeName("#define AV_PROFILE_MPEG4_CORE 2")]
        public const int AV_PROFILE_MPEG4_CORE = 2;

        [NativeTypeName("#define AV_PROFILE_MPEG4_MAIN 3")]
        public const int AV_PROFILE_MPEG4_MAIN = 3;

        [NativeTypeName("#define AV_PROFILE_MPEG4_N_BIT 4")]
        public const int AV_PROFILE_MPEG4_N_BIT = 4;

        [NativeTypeName("#define AV_PROFILE_MPEG4_SCALABLE_TEXTURE 5")]
        public const int AV_PROFILE_MPEG4_SCALABLE_TEXTURE = 5;

        [NativeTypeName("#define AV_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION 6")]
        public const int AV_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION = 6;

        [NativeTypeName("#define AV_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE 7")]
        public const int AV_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE = 7;

        [NativeTypeName("#define AV_PROFILE_MPEG4_HYBRID 8")]
        public const int AV_PROFILE_MPEG4_HYBRID = 8;

        [NativeTypeName("#define AV_PROFILE_MPEG4_ADVANCED_REAL_TIME 9")]
        public const int AV_PROFILE_MPEG4_ADVANCED_REAL_TIME = 9;

        [NativeTypeName("#define AV_PROFILE_MPEG4_CORE_SCALABLE 10")]
        public const int AV_PROFILE_MPEG4_CORE_SCALABLE = 10;

        [NativeTypeName("#define AV_PROFILE_MPEG4_ADVANCED_CODING 11")]
        public const int AV_PROFILE_MPEG4_ADVANCED_CODING = 11;

        [NativeTypeName("#define AV_PROFILE_MPEG4_ADVANCED_CORE 12")]
        public const int AV_PROFILE_MPEG4_ADVANCED_CORE = 12;

        [NativeTypeName("#define AV_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE 13")]
        public const int AV_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE = 13;

        [NativeTypeName("#define AV_PROFILE_MPEG4_SIMPLE_STUDIO 14")]
        public const int AV_PROFILE_MPEG4_SIMPLE_STUDIO = 14;

        [NativeTypeName("#define AV_PROFILE_MPEG4_ADVANCED_SIMPLE 15")]
        public const int AV_PROFILE_MPEG4_ADVANCED_SIMPLE = 15;

        [NativeTypeName("#define AV_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 1")]
        public const int AV_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 = 1;

        [NativeTypeName("#define AV_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 2")]
        public const int AV_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 = 2;

        [NativeTypeName("#define AV_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION 32768")]
        public const int AV_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION = 32768;

        [NativeTypeName("#define AV_PROFILE_JPEG2000_DCINEMA_2K 3")]
        public const int AV_PROFILE_JPEG2000_DCINEMA_2K = 3;

        [NativeTypeName("#define AV_PROFILE_JPEG2000_DCINEMA_4K 4")]
        public const int AV_PROFILE_JPEG2000_DCINEMA_4K = 4;

        [NativeTypeName("#define AV_PROFILE_VP9_0 0")]
        public const int AV_PROFILE_VP9_0 = 0;

        [NativeTypeName("#define AV_PROFILE_VP9_1 1")]
        public const int AV_PROFILE_VP9_1 = 1;

        [NativeTypeName("#define AV_PROFILE_VP9_2 2")]
        public const int AV_PROFILE_VP9_2 = 2;

        [NativeTypeName("#define AV_PROFILE_VP9_3 3")]
        public const int AV_PROFILE_VP9_3 = 3;

        [NativeTypeName("#define AV_PROFILE_HEVC_MAIN 1")]
        public const int AV_PROFILE_HEVC_MAIN = 1;

        [NativeTypeName("#define AV_PROFILE_HEVC_MAIN_10 2")]
        public const int AV_PROFILE_HEVC_MAIN_10 = 2;

        [NativeTypeName("#define AV_PROFILE_HEVC_MAIN_STILL_PICTURE 3")]
        public const int AV_PROFILE_HEVC_MAIN_STILL_PICTURE = 3;

        [NativeTypeName("#define AV_PROFILE_HEVC_REXT 4")]
        public const int AV_PROFILE_HEVC_REXT = 4;

        [NativeTypeName("#define AV_PROFILE_HEVC_MULTIVIEW_MAIN 6")]
        public const int AV_PROFILE_HEVC_MULTIVIEW_MAIN = 6;

        [NativeTypeName("#define AV_PROFILE_HEVC_SCC 9")]
        public const int AV_PROFILE_HEVC_SCC = 9;

        [NativeTypeName("#define AV_PROFILE_VVC_MAIN_10 1")]
        public const int AV_PROFILE_VVC_MAIN_10 = 1;

        [NativeTypeName("#define AV_PROFILE_VVC_MAIN_10_444 33")]
        public const int AV_PROFILE_VVC_MAIN_10_444 = 33;

        [NativeTypeName("#define AV_PROFILE_AV1_MAIN 0")]
        public const int AV_PROFILE_AV1_MAIN = 0;

        [NativeTypeName("#define AV_PROFILE_AV1_HIGH 1")]
        public const int AV_PROFILE_AV1_HIGH = 1;

        [NativeTypeName("#define AV_PROFILE_AV1_PROFESSIONAL 2")]
        public const int AV_PROFILE_AV1_PROFESSIONAL = 2;

        [NativeTypeName("#define AV_PROFILE_MJPEG_HUFFMAN_BASELINE_DCT 0xc0")]
        public const int AV_PROFILE_MJPEG_HUFFMAN_BASELINE_DCT = 0xc0;

        [NativeTypeName("#define AV_PROFILE_MJPEG_HUFFMAN_EXTENDED_SEQUENTIAL_DCT 0xc1")]
        public const int AV_PROFILE_MJPEG_HUFFMAN_EXTENDED_SEQUENTIAL_DCT = 0xc1;

        [NativeTypeName("#define AV_PROFILE_MJPEG_HUFFMAN_PROGRESSIVE_DCT 0xc2")]
        public const int AV_PROFILE_MJPEG_HUFFMAN_PROGRESSIVE_DCT = 0xc2;

        [NativeTypeName("#define AV_PROFILE_MJPEG_HUFFMAN_LOSSLESS 0xc3")]
        public const int AV_PROFILE_MJPEG_HUFFMAN_LOSSLESS = 0xc3;

        [NativeTypeName("#define AV_PROFILE_MJPEG_JPEG_LS 0xf7")]
        public const int AV_PROFILE_MJPEG_JPEG_LS = 0xf7;

        [NativeTypeName("#define AV_PROFILE_SBC_MSBC 1")]
        public const int AV_PROFILE_SBC_MSBC = 1;

        [NativeTypeName("#define AV_PROFILE_PRORES_PROXY 0")]
        public const int AV_PROFILE_PRORES_PROXY = 0;

        [NativeTypeName("#define AV_PROFILE_PRORES_LT 1")]
        public const int AV_PROFILE_PRORES_LT = 1;

        [NativeTypeName("#define AV_PROFILE_PRORES_STANDARD 2")]
        public const int AV_PROFILE_PRORES_STANDARD = 2;

        [NativeTypeName("#define AV_PROFILE_PRORES_HQ 3")]
        public const int AV_PROFILE_PRORES_HQ = 3;

        [NativeTypeName("#define AV_PROFILE_PRORES_4444 4")]
        public const int AV_PROFILE_PRORES_4444 = 4;

        [NativeTypeName("#define AV_PROFILE_PRORES_XQ 5")]
        public const int AV_PROFILE_PRORES_XQ = 5;

        [NativeTypeName("#define AV_PROFILE_PRORES_RAW 0")]
        public const int AV_PROFILE_PRORES_RAW = 0;

        [NativeTypeName("#define AV_PROFILE_PRORES_RAW_HQ 1")]
        public const int AV_PROFILE_PRORES_RAW_HQ = 1;

        [NativeTypeName("#define AV_PROFILE_ARIB_PROFILE_A 0")]
        public const int AV_PROFILE_ARIB_PROFILE_A = 0;

        [NativeTypeName("#define AV_PROFILE_ARIB_PROFILE_C 1")]
        public const int AV_PROFILE_ARIB_PROFILE_C = 1;

        [NativeTypeName("#define AV_PROFILE_KLVA_SYNC 0")]
        public const int AV_PROFILE_KLVA_SYNC = 0;

        [NativeTypeName("#define AV_PROFILE_KLVA_ASYNC 1")]
        public const int AV_PROFILE_KLVA_ASYNC = 1;

        [NativeTypeName("#define AV_PROFILE_EVC_BASELINE 0")]
        public const int AV_PROFILE_EVC_BASELINE = 0;

        [NativeTypeName("#define AV_PROFILE_EVC_MAIN 1")]
        public const int AV_PROFILE_EVC_MAIN = 1;

        [NativeTypeName("#define AV_PROFILE_APV_422_10 33")]
        public const int AV_PROFILE_APV_422_10 = 33;

        [NativeTypeName("#define AV_PROFILE_APV_422_12 44")]
        public const int AV_PROFILE_APV_422_12 = 44;

        [NativeTypeName("#define AV_PROFILE_APV_444_10 55")]
        public const int AV_PROFILE_APV_444_10 = 55;

        [NativeTypeName("#define AV_PROFILE_APV_444_12 66")]
        public const int AV_PROFILE_APV_444_12 = 66;

        [NativeTypeName("#define AV_PROFILE_APV_4444_10 77")]
        public const int AV_PROFILE_APV_4444_10 = 77;

        [NativeTypeName("#define AV_PROFILE_APV_4444_12 88")]
        public const int AV_PROFILE_APV_4444_12 = 88;

        [NativeTypeName("#define AV_PROFILE_APV_400_10 99")]
        public const int AV_PROFILE_APV_400_10 = 99;

        [NativeTypeName("#define AV_LEVEL_UNKNOWN -99")]
        public const int AV_LEVEL_UNKNOWN = -99;

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecDescriptor *")]
        public static extern AVCodecDescriptor* avcodec_descriptor_get([NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecDescriptor *")]
        public static extern AVCodecDescriptor* avcodec_descriptor_next([NativeTypeName("const AVCodecDescriptor *")] AVCodecDescriptor* prev);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecDescriptor *")]
        public static extern AVCodecDescriptor* avcodec_descriptor_get_by_name([NativeTypeName("const char *")] sbyte* name);

        [NativeTypeName("#define AV_CODEC_PROP_INTRA_ONLY (1 << 0)")]
        public const int AV_CODEC_PROP_INTRA_ONLY = (1 << 0);

        [NativeTypeName("#define AV_CODEC_PROP_LOSSY (1 << 1)")]
        public const int AV_CODEC_PROP_LOSSY = (1 << 1);

        [NativeTypeName("#define AV_CODEC_PROP_LOSSLESS (1 << 2)")]
        public const int AV_CODEC_PROP_LOSSLESS = (1 << 2);

        [NativeTypeName("#define AV_CODEC_PROP_REORDER (1 << 3)")]
        public const int AV_CODEC_PROP_REORDER = (1 << 3);

        [NativeTypeName("#define AV_CODEC_PROP_FIELDS (1 << 4)")]
        public const int AV_CODEC_PROP_FIELDS = (1 << 4);

        [NativeTypeName("#define AV_CODEC_PROP_ENHANCEMENT (1 << 5)")]
        public const int AV_CODEC_PROP_ENHANCEMENT = (1 << 5);

        [NativeTypeName("#define AV_CODEC_PROP_BITMAP_SUB (1 << 16)")]
        public const int AV_CODEC_PROP_BITMAP_SUB = (1 << 16);

        [NativeTypeName("#define AV_CODEC_PROP_TEXT_SUB (1 << 17)")]
        public const int AV_CODEC_PROP_TEXT_SUB = (1 << 17);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVPacketSideData* av_packet_side_data_new(AVPacketSideData** psd, int* pnb_sd, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, [NativeTypeName("size_t")] nuint size, int flags);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVPacketSideData* av_packet_side_data_add(AVPacketSideData** sd, int* nb_sd, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, void* data, [NativeTypeName("size_t")] nuint size, int flags);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVPacketSideData *")]
        public static extern AVPacketSideData* av_packet_side_data_get([NativeTypeName("const AVPacketSideData *")] AVPacketSideData* sd, int nb_sd, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_side_data_remove(AVPacketSideData* sd, int* nb_sd, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_side_data_free(AVPacketSideData** sd, int* nb_sd);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_side_data_from_frame(AVPacketSideData** sd, int* nb_sd, [NativeTypeName("const struct AVFrameSideData *")] AVFrameSideData* src, [NativeTypeName("unsigned int")] uint flags);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_side_data_to_frame([NativeTypeName("struct AVFrameSideData ***")] AVFrameSideData*** sd, int* nb_sd, [NativeTypeName("const AVPacketSideData *")] AVPacketSideData* src, [NativeTypeName("unsigned int")] uint flags);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_packet_side_data_name([NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVPacket* av_packet_alloc();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVPacket* av_packet_clone([NativeTypeName("const AVPacket *")] AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_free(AVPacket** pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_init_packet(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_new_packet(AVPacket* pkt, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_shrink_packet(AVPacket* pkt, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_grow_packet(AVPacket* pkt, int grow_by);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_from_data(AVPacket* pkt, [NativeTypeName("uint8_t *")] byte* data, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* av_packet_new_side_data(AVPacket* pkt, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, [NativeTypeName("size_t")] nuint size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_add_side_data(AVPacket* pkt, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, [NativeTypeName("uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_shrink_side_data(AVPacket* pkt, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, [NativeTypeName("size_t")] nuint size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* av_packet_get_side_data([NativeTypeName("const AVPacket *")] AVPacket* pkt, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, [NativeTypeName("size_t *")] nuint* size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* av_packet_pack_dictionary(AVDictionary* dict, [NativeTypeName("size_t *")] nuint* size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_unpack_dictionary([NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size, AVDictionary** dict);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_free_side_data(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_ref(AVPacket* dst, [NativeTypeName("const AVPacket *")] AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_unref(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_move_ref(AVPacket* dst, AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_copy_props(AVPacket* dst, [NativeTypeName("const AVPacket *")] AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_make_refcounted(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_make_writable(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_rescale_ts(AVPacket* pkt, AVRational tb_src, AVRational tb_dst);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct AVContainerFifo *")]
        public static extern AVContainerFifo* av_container_fifo_alloc_avpacket([NativeTypeName("unsigned int")] uint flags);

        [NativeTypeName("#define AV_PKT_FLAG_KEY 0x0001")]
        public const int AV_PKT_FLAG_KEY = 0x0001;

        [NativeTypeName("#define AV_PKT_FLAG_CORRUPT 0x0002")]
        public const int AV_PKT_FLAG_CORRUPT = 0x0002;

        [NativeTypeName("#define AV_PKT_FLAG_DISCARD 0x0004")]
        public const int AV_PKT_FLAG_DISCARD = 0x0004;

        [NativeTypeName("#define AV_PKT_FLAG_TRUSTED 0x0008")]
        public const int AV_PKT_FLAG_TRUSTED = 0x0008;

        [NativeTypeName("#define AV_PKT_FLAG_DISPOSABLE 0x0010")]
        public const int AV_PKT_FLAG_DISPOSABLE = 0x0010;

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodecParameters* avcodec_parameters_alloc();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_parameters_free(AVCodecParameters** par);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_parameters_copy(AVCodecParameters* dst, [NativeTypeName("const AVCodecParameters *")] AVCodecParameters* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_audio_frame_duration2(AVCodecParameters* par, int frame_bytes);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVBitStreamFilter *")]
        public static extern AVBitStreamFilter* av_bsf_get_by_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVBitStreamFilter *")]
        public static extern AVBitStreamFilter* av_bsf_iterate(void** opaque);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_alloc([NativeTypeName("const AVBitStreamFilter *")] AVBitStreamFilter* filter, AVBSFContext** ctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_init(AVBSFContext* ctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_send_packet(AVBSFContext* ctx, AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_receive_packet(AVBSFContext* ctx, AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_bsf_flush(AVBSFContext* ctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_bsf_free(AVBSFContext** ctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* av_bsf_get_class();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBSFList* av_bsf_list_alloc();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_bsf_list_free(AVBSFList** lst);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_list_append(AVBSFList* lst, AVBSFContext* bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_list_append2(AVBSFList* lst, [NativeTypeName("const char *")] sbyte* bsf_name, AVDictionary** options);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_list_finalize(AVBSFList** lst, AVBSFContext** bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_list_parse_str([NativeTypeName("const char *")] sbyte* str, AVBSFContext** bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_get_null_filter(AVBSFContext** bsf);
    }
}

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.FFMpeg.Native
{
    public enum SwsDither
    {
        SWS_DITHER_NONE = 0,
        SWS_DITHER_AUTO,
        SWS_DITHER_BAYER,
        SWS_DITHER_ED,
        SWS_DITHER_A_DITHER,
        SWS_DITHER_X_DITHER,
        SWS_DITHER_NB,
        SWS_DITHER_MAX_ENUM = 0x7FFFFFFF,
    }

    public enum SwsAlphaBlend
    {
        SWS_ALPHA_BLEND_NONE = 0,
        SWS_ALPHA_BLEND_UNIFORM,
        SWS_ALPHA_BLEND_CHECKERBOARD,
        SWS_ALPHA_BLEND_NB,
        SWS_ALPHA_BLEND_MAX_ENUM = 0x7FFFFFFF,
    }

    public enum SwsFlags
    {
        SWS_FAST_BILINEAR = 1 << 0,
        SWS_BILINEAR = 1 << 1,
        SWS_BICUBIC = 1 << 2,
        SWS_X = 1 << 3,
        SWS_POINT = 1 << 4,
        SWS_AREA = 1 << 5,
        SWS_BICUBLIN = 1 << 6,
        SWS_GAUSS = 1 << 7,
        SWS_SINC = 1 << 8,
        SWS_LANCZOS = 1 << 9,
        SWS_SPLINE = 1 << 10,
        SWS_STRICT = 1 << 11,
        SWS_PRINT_INFO = 1 << 12,
        SWS_FULL_CHR_H_INT = 1 << 13,
        SWS_FULL_CHR_H_INP = 1 << 14,
        SWS_ACCURATE_RND = 1 << 18,
        SWS_BITEXACT = 1 << 19,
        SWS_UNSTABLE = 1 << 20,
        SWS_DIRECT_BGR = 1 << 15,
        SWS_ERROR_DIFFUSION = 1 << 23,
    }

    public enum SwsIntent
    {
        SWS_INTENT_PERCEPTUAL = 0,
        SWS_INTENT_RELATIVE_COLORIMETRIC = 1,
        SWS_INTENT_SATURATION = 2,
        SWS_INTENT_ABSOLUTE_COLORIMETRIC = 3,
        SWS_INTENT_NB,
    }

    public unsafe partial struct SwsContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public void* opaque;

        [NativeTypeName("unsigned int")]
        public uint flags;

        [NativeTypeName("double[2]")]
        public _scaler_params_e__FixedBuffer scaler_params;

        public int threads;

        public SwsDither dither;

        public SwsAlphaBlend alpha_blend;

        public int gamma_flag;

        public int src_w;

        public int src_h;

        public int dst_w;

        public int dst_h;

        public int src_format;

        public int dst_format;

        public int src_range;

        public int dst_range;

        public int src_v_chr_pos;

        public int src_h_chr_pos;

        public int dst_v_chr_pos;

        public int dst_h_chr_pos;

        public int intent;

        [InlineArray(2)]
        public partial struct _scaler_params_e__FixedBuffer
        {
            public double e0;
        }
    }

    public unsafe partial struct SwsVector
    {
        public double* coeff;

        public int length;
    }

    public unsafe partial struct SwsFilter
    {
        public SwsVector* lumH;

        public SwsVector* lumV;

        public SwsVector* chrH;

        public SwsVector* chrV;
    }

    public static unsafe partial class Methods
    {
        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint swscale_version();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* swscale_configuration();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* swscale_license();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* sws_get_class();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsContext* sws_alloc_context();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_free_context(SwsContext** ctx);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_test_format([NativeTypeName("enum AVPixelFormat")] AVPixelFormat format, int output);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_test_hw_format([NativeTypeName("enum AVPixelFormat")] AVPixelFormat format);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_test_colorspace([NativeTypeName("enum AVColorSpace")] AVColorSpace colorspace, int output);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_test_primaries([NativeTypeName("enum AVColorPrimaries")] AVColorPrimaries primaries, int output);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_test_transfer([NativeTypeName("enum AVColorTransferCharacteristic")] AVColorTransferCharacteristic trc, int output);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_test_frame([NativeTypeName("const AVFrame *")] AVFrame* frame, int output);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_frame_setup(SwsContext* ctx, [NativeTypeName("const AVFrame *")] AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_is_noop([NativeTypeName("const AVFrame *")] AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_scale_frame(SwsContext* c, AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const int *")]
        public static extern int* sws_getCoefficients(int colorspace);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_isSupportedInput([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_isSupportedOutput([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_isSupportedEndiannessConversion([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_init_context(SwsContext* sws_context, SwsFilter* srcFilter, SwsFilter* dstFilter);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_freeContext(SwsContext* swsContext);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsContext* sws_getContext(int srcW, int srcH, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat srcFormat, int dstW, int dstH, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, [NativeTypeName("const double *")] double* param9);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_scale(SwsContext* c, [NativeTypeName("const uint8_t *const[]")] byte** srcSlice, [NativeTypeName("const int[]")] int* srcStride, int srcSliceY, int srcSliceH, [NativeTypeName("uint8_t *const[]")] byte** dst, [NativeTypeName("const int[]")] int* dstStride);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_frame_start(SwsContext* c, AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_frame_end(SwsContext* c);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_send_slice(SwsContext* c, [NativeTypeName("unsigned int")] uint slice_start, [NativeTypeName("unsigned int")] uint slice_height);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_receive_slice(SwsContext* c, [NativeTypeName("unsigned int")] uint slice_start, [NativeTypeName("unsigned int")] uint slice_height);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint sws_receive_slice_alignment([NativeTypeName("const SwsContext *")] SwsContext* c);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_setColorspaceDetails(SwsContext* c, [NativeTypeName("const int[4]")] int* inv_table, int srcRange, [NativeTypeName("const int[4]")] int* table, int dstRange, int brightness, int contrast, int saturation);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_getColorspaceDetails(SwsContext* c, int** inv_table, int* srcRange, int** table, int* dstRange, int* brightness, int* contrast, int* saturation);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsVector* sws_allocVec(int length);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsVector* sws_getGaussianVec(double variance, double quality);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_scaleVec(SwsVector* a, double scalar);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_normalizeVec(SwsVector* a, double height);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_freeVec(SwsVector* a);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsFilter* sws_getDefaultFilter(float lumaGBlur, float chromaGBlur, float lumaSharpen, float chromaSharpen, float chromaHShift, float chromaVShift, int verbose);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_freeFilter(SwsFilter* filter);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsContext* sws_getCachedContext(SwsContext* context, int srcW, int srcH, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat srcFormat, int dstW, int dstH, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, [NativeTypeName("const double *")] double* param10);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_convertPalette8ToPacked32([NativeTypeName("const uint8_t *")] byte* src, [NativeTypeName("uint8_t *")] byte* dst, int num_pixels, [NativeTypeName("const uint8_t *")] byte* palette);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_convertPalette8ToPacked24([NativeTypeName("const uint8_t *")] byte* src, [NativeTypeName("uint8_t *")] byte* dst, int num_pixels, [NativeTypeName("const uint8_t *")] byte* palette);

        [NativeTypeName("#define SWS_SRC_V_CHR_DROP_MASK 0x30000")]
        public const int SWS_SRC_V_CHR_DROP_MASK = 0x30000;

        [NativeTypeName("#define SWS_SRC_V_CHR_DROP_SHIFT 16")]
        public const int SWS_SRC_V_CHR_DROP_SHIFT = 16;

        [NativeTypeName("#define SWS_PARAM_DEFAULT 123456")]
        public const int SWS_PARAM_DEFAULT = 123456;

        [NativeTypeName("#define SWS_MAX_REDUCE_CUTOFF 0.002")]
        public const double SWS_MAX_REDUCE_CUTOFF = 0.002;

        [NativeTypeName("#define SWS_CS_ITU709 1")]
        public const int SWS_CS_ITU709 = 1;

        [NativeTypeName("#define SWS_CS_FCC 4")]
        public const int SWS_CS_FCC = 4;

        [NativeTypeName("#define SWS_CS_ITU601 5")]
        public const int SWS_CS_ITU601 = 5;

        [NativeTypeName("#define SWS_CS_ITU624 5")]
        public const int SWS_CS_ITU624 = 5;

        [NativeTypeName("#define SWS_CS_SMPTE170M 5")]
        public const int SWS_CS_SMPTE170M = 5;

        [NativeTypeName("#define SWS_CS_SMPTE240M 7")]
        public const int SWS_CS_SMPTE240M = 7;

        [NativeTypeName("#define SWS_CS_DEFAULT 5")]
        public const int SWS_CS_DEFAULT = 5;

        [NativeTypeName("#define SWS_CS_BT2020 9")]
        public const int SWS_CS_BT2020 = 9;
    }
}

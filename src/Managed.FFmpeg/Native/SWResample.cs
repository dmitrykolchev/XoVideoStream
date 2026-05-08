using System.Runtime.InteropServices;

namespace Managed.FFMpeg.Native
{
    public enum SwrDitherType
    {
        SWR_DITHER_NONE = 0,
        SWR_DITHER_RECTANGULAR,
        SWR_DITHER_TRIANGULAR,
        SWR_DITHER_TRIANGULAR_HIGHPASS,
        SWR_DITHER_NS = 64,
        SWR_DITHER_NS_LIPSHITZ,
        SWR_DITHER_NS_F_WEIGHTED,
        SWR_DITHER_NS_MODIFIED_E_WEIGHTED,
        SWR_DITHER_NS_IMPROVED_E_WEIGHTED,
        SWR_DITHER_NS_SHIBATA,
        SWR_DITHER_NS_LOW_SHIBATA,
        SWR_DITHER_NS_HIGH_SHIBATA,
        SWR_DITHER_NB,
    }

    public enum SwrEngine
    {
        SWR_ENGINE_SWR,
        SWR_ENGINE_SOXR,
        SWR_ENGINE_NB,
    }

    public enum SwrFilterType
    {
        SWR_FILTER_TYPE_CUBIC,
        SWR_FILTER_TYPE_BLACKMAN_NUTTALL,
        SWR_FILTER_TYPE_KAISER,
    }

    public static unsafe partial class Methods
    {
        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* swr_get_class();

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct SwrContext *")]
        public static extern SwrContext* swr_alloc();

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_init([NativeTypeName("struct SwrContext *")] SwrContext* s);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_is_initialized([NativeTypeName("struct SwrContext *")] SwrContext* s);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_alloc_set_opts2([NativeTypeName("struct SwrContext **")] SwrContext** ps, [NativeTypeName("const AVChannelLayout *")] AVChannelLayout* out_ch_layout, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat out_sample_fmt, int out_sample_rate, [NativeTypeName("const AVChannelLayout *")] AVChannelLayout* in_ch_layout, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat in_sample_fmt, int in_sample_rate, int log_offset, void* log_ctx);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void swr_free([NativeTypeName("struct SwrContext **")] SwrContext** s);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void swr_close([NativeTypeName("struct SwrContext *")] SwrContext* s);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_convert([NativeTypeName("struct SwrContext *")] SwrContext* s, [NativeTypeName("uint8_t *const *")] byte** @out, int out_count, [NativeTypeName("const uint8_t *const *")] byte** @in, int in_count);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long swr_next_pts([NativeTypeName("struct SwrContext *")] SwrContext* s, [NativeTypeName("int64_t")] long pts);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_set_compensation([NativeTypeName("struct SwrContext *")] SwrContext* s, int sample_delta, int compensation_distance);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_set_channel_mapping([NativeTypeName("struct SwrContext *")] SwrContext* s, [NativeTypeName("const int *")] int* channel_map);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_build_matrix2([NativeTypeName("const AVChannelLayout *")] AVChannelLayout* in_layout, [NativeTypeName("const AVChannelLayout *")] AVChannelLayout* out_layout, double center_mix_level, double surround_mix_level, double lfe_mix_level, double maxval, double rematrix_volume, double* matrix, [NativeTypeName("ptrdiff_t")] nint stride, [NativeTypeName("enum AVMatrixEncoding")] AVMatrixEncoding matrix_encoding, void* log_context);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_set_matrix([NativeTypeName("struct SwrContext *")] SwrContext* s, [NativeTypeName("const double *")] double* matrix, int stride);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_drop_output([NativeTypeName("struct SwrContext *")] SwrContext* s, int count);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_inject_silence([NativeTypeName("struct SwrContext *")] SwrContext* s, int count);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long swr_get_delay([NativeTypeName("struct SwrContext *")] SwrContext* s, [NativeTypeName("int64_t")] long @base);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_get_out_samples([NativeTypeName("struct SwrContext *")] SwrContext* s, int in_samples);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint swresample_version();

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* swresample_configuration();

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* swresample_license();

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_convert_frame(SwrContext* swr, AVFrame* output, [NativeTypeName("const AVFrame *")] AVFrame* input);

        [DllImport("swresample", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int swr_config_frame(SwrContext* swr, [NativeTypeName("const AVFrame *")] AVFrame* @out, [NativeTypeName("const AVFrame *")] AVFrame* @in);

        [NativeTypeName("#define SWR_FLAG_RESAMPLE 1")]
        public const int SWR_FLAG_RESAMPLE = 1;
    }
}

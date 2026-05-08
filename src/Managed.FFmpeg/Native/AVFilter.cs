using System;
using System.Runtime.InteropServices;

namespace Managed.FFMpeg.Native
{
    public unsafe partial struct AVFilterFormatsConfig
    {
        public AVFilterFormats* formats;

        public AVFilterFormats* samplerates;

        public AVFilterChannelLayouts* channel_layouts;

        public AVFilterFormats* color_spaces;

        public AVFilterFormats* color_ranges;

        public AVFilterFormats* alpha_modes;
    }

    public unsafe partial struct AVFilter
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("const AVFilterPad *")]
        public AVFilterPad* inputs;

        [NativeTypeName("const AVFilterPad *")]
        public AVFilterPad* outputs;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        public int flags;
    }

    public unsafe partial struct AVFilterContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("const AVFilter *")]
        public AVFilter* filter;

        [NativeTypeName("char *")]
        public sbyte* name;

        public AVFilterPad* input_pads;

        public AVFilterLink** inputs;

        [NativeTypeName("unsigned int")]
        public uint nb_inputs;

        public AVFilterPad* output_pads;

        public AVFilterLink** outputs;

        [NativeTypeName("unsigned int")]
        public uint nb_outputs;

        public void* priv;

        [NativeTypeName("struct AVFilterGraph *")]
        public AVFilterGraph* graph;

        public int thread_type;

        public int nb_threads;

        [NativeTypeName("struct AVFilterCommand *")]
        [Obsolete]
        public AVFilterCommand* command_queue;

        [NativeTypeName("char *")]
        public sbyte* enable_str;

        [Obsolete]
        public void* enable;

        public double* var_values;

        public int is_disabled;

        public AVBufferRef* hw_device_ctx;

        [NativeTypeName("unsigned int")]
        [Obsolete]
        public uint ready;

        public int extra_hw_frames;
    }

    public unsafe partial struct AVFilterLink
    {
        public AVFilterContext* src;

        public AVFilterPad* srcpad;

        public AVFilterContext* dst;

        public AVFilterPad* dstpad;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        public int format;

        public int w;

        public int h;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace colorspace;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        public int sample_rate;

        public AVChannelLayout ch_layout;

        public AVRational time_base;

        public AVFrameSideData** side_data;

        public int nb_side_data;

        [NativeTypeName("enum AVAlphaMode")]
        public AVAlphaMode alpha_mode;

        public AVFilterFormatsConfig incfg;

        public AVFilterFormatsConfig outcfg;
    }

    public unsafe partial struct AVFilterGraph
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public AVFilterContext** filters;

        [NativeTypeName("unsigned int")]
        public uint nb_filters;

        [NativeTypeName("char *")]
        public sbyte* scale_sws_opts;

        public int thread_type;

        public int nb_threads;

        public void* opaque;

        [NativeTypeName("avfilter_execute_func *")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, delegate* unmanaged[Cdecl]<AVFilterContext*, void*, int, int, int>, void*, int*, int, int> execute;

        [NativeTypeName("char *")]
        public sbyte* aresample_swr_opts;

        [NativeTypeName("unsigned int")]
        public uint max_buffered_frames;
    }

    public enum AVFILTER_AUTO_CONVERT
    {
        AVFILTER_AUTO_CONVERT_ALL = 0,
        AVFILTER_AUTO_CONVERT_NONE = -1,
    }

    public unsafe partial struct AVFilterInOut
    {
        [NativeTypeName("char *")]
        public sbyte* name;

        public AVFilterContext* filter_ctx;

        public int pad_idx;

        [NativeTypeName("struct AVFilterInOut *")]
        public AVFilterInOut* next;
    }

    public unsafe partial struct AVFilterPadParams
    {
        [NativeTypeName("char *")]
        public sbyte* label;
    }

    public unsafe partial struct AVFilterParams
    {
        public AVFilterContext* filter;

        [NativeTypeName("char *")]
        public sbyte* filter_name;

        [NativeTypeName("char *")]
        public sbyte* instance_name;

        public AVDictionary* opts;

        public AVFilterPadParams** inputs;

        [NativeTypeName("unsigned int")]
        public uint nb_inputs;

        public AVFilterPadParams** outputs;

        [NativeTypeName("unsigned int")]
        public uint nb_outputs;
    }

    public unsafe partial struct AVFilterChain
    {
        public AVFilterParams** filters;

        [NativeTypeName("size_t")]
        public nuint nb_filters;
    }

    public unsafe partial struct AVFilterGraphSegment
    {
        public AVFilterGraph* graph;

        public AVFilterChain** chains;

        [NativeTypeName("size_t")]
        public nuint nb_chains;

        [NativeTypeName("char *")]
        public sbyte* scale_sws_opts;
    }

    public enum AV_BUFFERSRC_FLAG
    {
        AV_BUFFERSRC_FLAG_NO_CHECK_FORMAT = 1,
        AV_BUFFERSRC_FLAG_PUSH = 4,
        AV_BUFFERSRC_FLAG_KEEP_REF = 8,
    }

    public unsafe partial struct AVBufferSrcParameters
    {
        public int format;

        public AVRational time_base;

        public int width;

        public int height;

        public AVRational sample_aspect_ratio;

        public AVRational frame_rate;

        public AVBufferRef* hw_frames_ctx;

        public int sample_rate;

        public AVChannelLayout ch_layout;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace color_space;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        public AVFrameSideData** side_data;

        public int nb_side_data;

        [NativeTypeName("enum AVAlphaMode")]
        public AVAlphaMode alpha_mode;
    }

    public static unsafe partial class Methods
    {
        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avfilter_version();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avfilter_configuration();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avfilter_license();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avfilter_pad_get_name([NativeTypeName("const AVFilterPad *")] AVFilterPad* pads, int pad_idx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVMediaType")]
        public static extern AVMediaType avfilter_pad_get_type([NativeTypeName("const AVFilterPad *")] AVFilterPad* pads, int pad_idx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* avfilter_link_get_hw_frames_ctx(AVFilterLink* link);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avfilter_filter_pad_count([NativeTypeName("const AVFilter *")] AVFilter* filter, int is_output);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_link(AVFilterContext* src, [NativeTypeName("unsigned int")] uint srcpad, AVFilterContext* dst, [NativeTypeName("unsigned int")] uint dstpad);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_process_command(AVFilterContext* filter, [NativeTypeName("const char *")] sbyte* cmd, [NativeTypeName("const char *")] sbyte* arg, [NativeTypeName("char *")] sbyte* res, int res_len, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVFilter *")]
        public static extern AVFilter* av_filter_iterate(void** opaque);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVFilter *")]
        public static extern AVFilter* avfilter_get_by_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_init_str(AVFilterContext* ctx, [NativeTypeName("const char *")] sbyte* args);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_init_dict(AVFilterContext* ctx, AVDictionary** options);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_free(AVFilterContext* filter);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_insert_filter(AVFilterLink* link, AVFilterContext* filt, [NativeTypeName("unsigned int")] uint filt_srcpad_idx, [NativeTypeName("unsigned int")] uint filt_dstpad_idx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avfilter_get_class();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFilterGraph* avfilter_graph_alloc();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* graph, [NativeTypeName("const AVFilter *")] AVFilter* filter, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_create_filter(AVFilterContext** filt_ctx, [NativeTypeName("const AVFilter *")] AVFilter* filt, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* args, void* opaque, AVFilterGraph* graph_ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_graph_set_auto_convert(AVFilterGraph* graph, [NativeTypeName("unsigned int")] uint flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_config(AVFilterGraph* graphctx, void* log_ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_graph_free(AVFilterGraph** graph);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFilterInOut* avfilter_inout_alloc();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_inout_free(AVFilterInOut** inout);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_parse(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* filters, AVFilterInOut* inputs, AVFilterInOut* outputs, void* log_ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_parse_ptr(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* filters, AVFilterInOut** inputs, AVFilterInOut** outputs, void* log_ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_parse2(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* filters, AVFilterInOut** inputs, AVFilterInOut** outputs);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_segment_parse(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* graph_str, int flags, AVFilterGraphSegment** seg);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_segment_create_filters(AVFilterGraphSegment* seg, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_segment_apply_opts(AVFilterGraphSegment* seg, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_segment_init(AVFilterGraphSegment* seg, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_segment_link(AVFilterGraphSegment* seg, int flags, AVFilterInOut** inputs, AVFilterInOut** outputs);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_segment_apply(AVFilterGraphSegment* seg, int flags, AVFilterInOut** inputs, AVFilterInOut** outputs);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_graph_segment_free(AVFilterGraphSegment** seg);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_send_command(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* target, [NativeTypeName("const char *")] sbyte* cmd, [NativeTypeName("const char *")] sbyte* arg, [NativeTypeName("char *")] sbyte* res, int res_len, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_queue_command(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* target, [NativeTypeName("const char *")] sbyte* cmd, [NativeTypeName("const char *")] sbyte* arg, int flags, double ts);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* avfilter_graph_dump(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* options);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_request_oldest(AVFilterGraph* graph);

        [NativeTypeName("#define AVFILTER_FLAG_DYNAMIC_INPUTS (1 << 0)")]
        public const int AVFILTER_FLAG_DYNAMIC_INPUTS = (1 << 0);

        [NativeTypeName("#define AVFILTER_FLAG_DYNAMIC_OUTPUTS (1 << 1)")]
        public const int AVFILTER_FLAG_DYNAMIC_OUTPUTS = (1 << 1);

        [NativeTypeName("#define AVFILTER_FLAG_SLICE_THREADS (1 << 2)")]
        public const int AVFILTER_FLAG_SLICE_THREADS = (1 << 2);

        [NativeTypeName("#define AVFILTER_FLAG_METADATA_ONLY (1 << 3)")]
        public const int AVFILTER_FLAG_METADATA_ONLY = (1 << 3);

        [NativeTypeName("#define AVFILTER_FLAG_HWDEVICE (1 << 4)")]
        public const int AVFILTER_FLAG_HWDEVICE = (1 << 4);

        [NativeTypeName("#define AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC (1 << 16)")]
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC = (1 << 16);

        [NativeTypeName("#define AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL (1 << 17)")]
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL = (1 << 17);

        [NativeTypeName("#define AVFILTER_FLAG_SUPPORT_TIMELINE (AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC | AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL)")]
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE = ((1 << 16) | (1 << 17));

        [NativeTypeName("#define AVFILTER_THREAD_SLICE (1 << 0)")]
        public const int AVFILTER_THREAD_SLICE = (1 << 0);

        [NativeTypeName("#define AVFILTER_CMD_FLAG_ONE 1")]
        public const int AVFILTER_CMD_FLAG_ONE = 1;

        [NativeTypeName("#define AVFILTER_CMD_FLAG_FAST 2")]
        public const int AVFILTER_CMD_FLAG_FAST = 2;

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_frame_flags(AVFilterContext* ctx, AVFrame* frame, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_buffersink_set_frame_size(AVFilterContext* ctx, [NativeTypeName("unsigned int")] uint frame_size);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVMediaType")]
        public static extern AVMediaType av_buffersink_get_type([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_buffersink_get_time_base([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_format([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_buffersink_get_frame_rate([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_w([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_h([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_buffersink_get_sample_aspect_ratio([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVColorSpace")]
        public static extern AVColorSpace av_buffersink_get_colorspace([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVColorRange")]
        public static extern AVColorRange av_buffersink_get_color_range([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVAlphaMode")]
        public static extern AVAlphaMode av_buffersink_get_alpha_mode([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_channels([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_ch_layout([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx, AVChannelLayout* ch_layout);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_sample_rate([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffersink_get_hw_frames_ctx([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVFrameSideData *const *")]
        public static extern AVFrameSideData** av_buffersink_get_side_data([NativeTypeName("const AVFilterContext *")] AVFilterContext* ctx, int* nb_side_data);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_frame(AVFilterContext* ctx, AVFrame* frame);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersink_get_samples(AVFilterContext* ctx, AVFrame* frame, int nb_samples);

        [NativeTypeName("#define AV_BUFFERSINK_FLAG_PEEK 1")]
        public const int AV_BUFFERSINK_FLAG_PEEK = 1;

        [NativeTypeName("#define AV_BUFFERSINK_FLAG_NO_REQUEST 2")]
        public const int AV_BUFFERSINK_FLAG_NO_REQUEST = 2;

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint av_buffersrc_get_nb_failed_requests(AVFilterContext* buffer_src);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferSrcParameters* av_buffersrc_parameters_alloc();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersrc_parameters_set(AVFilterContext* ctx, AVBufferSrcParameters* param1);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersrc_write_frame(AVFilterContext* ctx, [NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersrc_add_frame(AVFilterContext* ctx, AVFrame* frame);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersrc_add_frame_flags(AVFilterContext* buffer_src, AVFrame* frame, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersrc_close(AVFilterContext* ctx, [NativeTypeName("int64_t")] long pts, [NativeTypeName("unsigned int")] uint flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffersrc_get_status(AVFilterContext* ctx);
    }
}

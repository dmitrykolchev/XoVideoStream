using System.Runtime.InteropServices;

namespace Managed.FFMpeg.Native
{
    public partial struct AVDeviceRect
    {
        public int x;

        public int y;

        public int width;

        public int height;
    }

    public enum AVAppToDevMessageType
    {
        AV_APP_TO_DEV_NONE = unchecked((int)(((sbyte)('E')) | (((sbyte)('N')) << 8) | (((sbyte)('O')) << 16) | ((uint)('N') << 24))),
        AV_APP_TO_DEV_WINDOW_SIZE = unchecked((int)(((sbyte)('M')) | (((sbyte)('O')) << 8) | (((sbyte)('E')) << 16) | ((uint)('G') << 24))),
        AV_APP_TO_DEV_WINDOW_REPAINT = unchecked((int)(((sbyte)('A')) | (((sbyte)('P')) << 8) | (((sbyte)('E')) << 16) | ((uint)('R') << 24))),
        AV_APP_TO_DEV_PAUSE = unchecked((int)(((sbyte)(' ')) | (((sbyte)('U')) << 8) | (((sbyte)('A')) << 16) | ((uint)('P') << 24))),
        AV_APP_TO_DEV_PLAY = unchecked((int)(((sbyte)('Y')) | (((sbyte)('A')) << 8) | (((sbyte)('L')) << 16) | ((uint)('P') << 24))),
        AV_APP_TO_DEV_TOGGLE_PAUSE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('A')) << 16) | ((uint)('P') << 24))),
        AV_APP_TO_DEV_SET_VOLUME = unchecked((int)(((sbyte)('L')) | (((sbyte)('O')) << 8) | (((sbyte)('V')) << 16) | ((uint)('S') << 24))),
        AV_APP_TO_DEV_MUTE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)(' ') << 24))),
        AV_APP_TO_DEV_UNMUTE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)('U') << 24))),
        AV_APP_TO_DEV_TOGGLE_MUTE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)('T') << 24))),
        AV_APP_TO_DEV_GET_VOLUME = unchecked((int)(((sbyte)('L')) | (((sbyte)('O')) << 8) | (((sbyte)('V')) << 16) | ((uint)('G') << 24))),
        AV_APP_TO_DEV_GET_MUTE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)('G') << 24))),
    }

    public enum AVDevToAppMessageType
    {
        AV_DEV_TO_APP_NONE = unchecked((int)(((sbyte)('E')) | (((sbyte)('N')) << 8) | (((sbyte)('O')) << 16) | ((uint)('N') << 24))),
        AV_DEV_TO_APP_CREATE_WINDOW_BUFFER = unchecked((int)(((sbyte)('E')) | (((sbyte)('R')) << 8) | (((sbyte)('C')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_PREPARE_WINDOW_BUFFER = unchecked((int)(((sbyte)('E')) | (((sbyte)('R')) << 8) | (((sbyte)('P')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_DISPLAY_WINDOW_BUFFER = unchecked((int)(((sbyte)('S')) | (((sbyte)('I')) << 8) | (((sbyte)('D')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_DESTROY_WINDOW_BUFFER = unchecked((int)(((sbyte)('S')) | (((sbyte)('E')) << 8) | (((sbyte)('D')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_BUFFER_OVERFLOW = unchecked((int)(((sbyte)('L')) | (((sbyte)('F')) << 8) | (((sbyte)('O')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_BUFFER_UNDERFLOW = unchecked((int)(((sbyte)('L')) | (((sbyte)('F')) << 8) | (((sbyte)('U')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_BUFFER_READABLE = unchecked((int)(((sbyte)(' ')) | (((sbyte)('D')) << 8) | (((sbyte)('R')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_BUFFER_WRITABLE = unchecked((int)(((sbyte)(' ')) | (((sbyte)('R')) << 8) | (((sbyte)('W')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_MUTE_STATE_CHANGED = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)('C') << 24))),
        AV_DEV_TO_APP_VOLUME_LEVEL_CHANGED = unchecked((int)(((sbyte)('L')) | (((sbyte)('O')) << 8) | (((sbyte)('V')) << 16) | ((uint)('C') << 24))),
    }

    public unsafe partial struct AVDeviceInfo
    {
        [NativeTypeName("char *")]
        public sbyte* device_name;

        [NativeTypeName("char *")]
        public sbyte* device_description;

        [NativeTypeName("enum AVMediaType *")]
        public AVMediaType* media_types;

        public int nb_media_types;
    }

    public unsafe partial struct AVDeviceInfoList
    {
        public AVDeviceInfo** devices;

        public int nb_devices;

        public int default_device;
    }

    public static unsafe partial class Methods
    {
        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avdevice_version();

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avdevice_configuration();

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avdevice_license();

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avdevice_register_all();

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVInputFormat *")]
        public static extern AVInputFormat* av_input_audio_device_next([NativeTypeName("const AVInputFormat *")] AVInputFormat* d);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVInputFormat *")]
        public static extern AVInputFormat* av_input_video_device_next([NativeTypeName("const AVInputFormat *")] AVInputFormat* d);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVOutputFormat *")]
        public static extern AVOutputFormat* av_output_audio_device_next([NativeTypeName("const AVOutputFormat *")] AVOutputFormat* d);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVOutputFormat *")]
        public static extern AVOutputFormat* av_output_video_device_next([NativeTypeName("const AVOutputFormat *")] AVOutputFormat* d);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avdevice_app_to_dev_control_message([NativeTypeName("struct AVFormatContext *")] AVFormatContext* s, [NativeTypeName("enum AVAppToDevMessageType")] AVAppToDevMessageType type, void* data, [NativeTypeName("size_t")] nuint data_size);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avdevice_dev_to_app_control_message([NativeTypeName("struct AVFormatContext *")] AVFormatContext* s, [NativeTypeName("enum AVDevToAppMessageType")] AVDevToAppMessageType type, void* data, [NativeTypeName("size_t")] nuint data_size);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avdevice_list_devices([NativeTypeName("struct AVFormatContext *")] AVFormatContext* s, AVDeviceInfoList** device_list);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avdevice_free_list_devices(AVDeviceInfoList** device_list);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avdevice_list_input_sources([NativeTypeName("const AVInputFormat *")] AVInputFormat* device, [NativeTypeName("const char *")] sbyte* device_name, AVDictionary* device_options, AVDeviceInfoList** device_list);

        [DllImport("avdevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avdevice_list_output_sinks([NativeTypeName("const AVOutputFormat *")] AVOutputFormat* device, [NativeTypeName("const char *")] sbyte* device_name, AVDictionary* device_options, AVDeviceInfoList** device_list);
    }
}

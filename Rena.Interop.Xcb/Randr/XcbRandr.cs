using System.Runtime.InteropServices;

namespace Rena.Interop.Xcb;

public static unsafe partial class XcbRandr
{
    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_mode_next", ExactSpelling = true)]
    public static extern void mode_next(xcb_randr_mode_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_mode_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t mode_end(xcb_randr_mode_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_crtc_next", ExactSpelling = true)]
    public static extern void crtc_next(xcb_randr_crtc_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_crtc_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t crtc_end(xcb_randr_crtc_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_output_next", ExactSpelling = true)]
    public static extern void output_next(xcb_randr_output_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_output_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t output_end(xcb_randr_output_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_provider_next", ExactSpelling = true)]
    public static extern void provider_next(xcb_randr_provider_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_provider_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t provider_end(xcb_randr_provider_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_lease_next", ExactSpelling = true)]
    public static extern void lease_next(xcb_randr_lease_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_lease_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t lease_end(xcb_randr_lease_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_screen_size_next", ExactSpelling = true)]
    public static extern void screen_size_next(xcb_randr_screen_size_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_screen_size_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t screen_size_end(xcb_randr_screen_size_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_refresh_rates_sizeof", ExactSpelling = true)]
    public static extern int refresh_rates_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_refresh_rates_rates", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* refresh_rates_rates([NativeTypeName("const xcb_randr_refresh_rates_t *")] xcb_randr_refresh_rates_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_refresh_rates_rates_length", ExactSpelling = true)]
    public static extern int refresh_rates_rates_length([NativeTypeName("const xcb_randr_refresh_rates_t *")] xcb_randr_refresh_rates_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_refresh_rates_rates_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t refresh_rates_rates_end([NativeTypeName("const xcb_randr_refresh_rates_t *")] xcb_randr_refresh_rates_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_refresh_rates_next", ExactSpelling = true)]
    public static extern void refresh_rates_next(xcb_randr_refresh_rates_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_refresh_rates_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t refresh_rates_end(xcb_randr_refresh_rates_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_version", ExactSpelling = true)]
    public static extern xcb_randr_query_version_cookie_t query_version(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint major_version, [NativeTypeName("uint32_t")] uint minor_version);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_version_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_query_version_cookie_t query_version_unchecked(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint major_version, [NativeTypeName("uint32_t")] uint minor_version);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_version_reply", ExactSpelling = true)]
    public static extern xcb_randr_query_version_reply_t* query_version_reply(xcb_connection_t* c, xcb_randr_query_version_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_screen_config", ExactSpelling = true)]
    public static extern xcb_randr_set_screen_config_cookie_t set_screen_config(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_timestamp_t")] uint timestamp, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp, [NativeTypeName("uint16_t")] ushort sizeID, [NativeTypeName("uint16_t")] ushort rotation, [NativeTypeName("uint16_t")] ushort rate);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_screen_config_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_set_screen_config_cookie_t set_screen_config_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_timestamp_t")] uint timestamp, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp, [NativeTypeName("uint16_t")] ushort sizeID, [NativeTypeName("uint16_t")] ushort rotation, [NativeTypeName("uint16_t")] ushort rate);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_screen_config_reply", ExactSpelling = true)]
    public static extern xcb_randr_set_screen_config_reply_t* set_screen_config_reply(xcb_connection_t* c, xcb_randr_set_screen_config_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_select_input_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_input_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort enable);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_select_input", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_input(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort enable);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info_sizeof", ExactSpelling = true)]
    public static extern int get_screen_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_info_cookie_t get_screen_info(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_info_cookie_t get_screen_info_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info_sizes", ExactSpelling = true)]
    public static extern xcb_randr_screen_size_t* get_screen_info_sizes([NativeTypeName("const xcb_randr_get_screen_info_reply_t *")] xcb_randr_get_screen_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info_sizes_length", ExactSpelling = true)]
    public static extern int get_screen_info_sizes_length([NativeTypeName("const xcb_randr_get_screen_info_reply_t *")] xcb_randr_get_screen_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info_sizes_iterator", ExactSpelling = true)]
    public static extern xcb_randr_screen_size_iterator_t get_screen_info_sizes_iterator([NativeTypeName("const xcb_randr_get_screen_info_reply_t *")] xcb_randr_get_screen_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info_rates_length", ExactSpelling = true)]
    public static extern int get_screen_info_rates_length([NativeTypeName("const xcb_randr_get_screen_info_reply_t *")] xcb_randr_get_screen_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info_rates_iterator", ExactSpelling = true)]
    public static extern xcb_randr_refresh_rates_iterator_t get_screen_info_rates_iterator([NativeTypeName("const xcb_randr_get_screen_info_reply_t *")] xcb_randr_get_screen_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_info_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_info_reply_t* get_screen_info_reply(xcb_connection_t* c, xcb_randr_get_screen_info_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_size_range", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_size_range_cookie_t get_screen_size_range(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_size_range_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_size_range_cookie_t get_screen_size_range_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_size_range_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_size_range_reply_t* get_screen_size_range_reply(xcb_connection_t* c, xcb_randr_get_screen_size_range_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_screen_size_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_screen_size_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint32_t")] uint mm_width, [NativeTypeName("uint32_t")] uint mm_height);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_screen_size", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_screen_size(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint32_t")] uint mm_width, [NativeTypeName("uint32_t")] uint mm_height);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_mode_info_next", ExactSpelling = true)]
    public static extern void mode_info_next(xcb_randr_mode_info_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_mode_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t mode_info_end(xcb_randr_mode_info_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_sizeof", ExactSpelling = true)]
    public static extern int get_screen_resources_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_resources_cookie_t get_screen_resources(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_resources_cookie_t get_screen_resources_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_crtcs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_crtc_t *")]
    public static extern uint* get_screen_resources_crtcs([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_crtcs_length", ExactSpelling = true)]
    public static extern int get_screen_resources_crtcs_length([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_crtcs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_screen_resources_crtcs_end([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_outputs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_output_t *")]
    public static extern uint* get_screen_resources_outputs([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_outputs_length", ExactSpelling = true)]
    public static extern int get_screen_resources_outputs_length([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_outputs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_screen_resources_outputs_end([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_modes", ExactSpelling = true)]
    public static extern xcb_randr_mode_info_t* get_screen_resources_modes([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_modes_length", ExactSpelling = true)]
    public static extern int get_screen_resources_modes_length([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_modes_iterator", ExactSpelling = true)]
    public static extern xcb_randr_mode_info_iterator_t get_screen_resources_modes_iterator([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_names", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_screen_resources_names([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_names_length", ExactSpelling = true)]
    public static extern int get_screen_resources_names_length([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_screen_resources_names_end([NativeTypeName("const xcb_randr_get_screen_resources_reply_t *")] xcb_randr_get_screen_resources_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_resources_reply_t* get_screen_resources_reply(xcb_connection_t* c, xcb_randr_get_screen_resources_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_sizeof", ExactSpelling = true)]
    public static extern int get_output_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info", ExactSpelling = true)]
    public static extern xcb_randr_get_output_info_cookie_t get_output_info(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_output_info_cookie_t get_output_info_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_crtcs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_crtc_t *")]
    public static extern uint* get_output_info_crtcs([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_crtcs_length", ExactSpelling = true)]
    public static extern int get_output_info_crtcs_length([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_crtcs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_output_info_crtcs_end([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_modes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_mode_t *")]
    public static extern uint* get_output_info_modes([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_modes_length", ExactSpelling = true)]
    public static extern int get_output_info_modes_length([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_modes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_output_info_modes_end([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_clones", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_output_t *")]
    public static extern uint* get_output_info_clones([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_clones_length", ExactSpelling = true)]
    public static extern int get_output_info_clones_length([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_clones_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_output_info_clones_end([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_name", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_output_info_name([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_name_length", ExactSpelling = true)]
    public static extern int get_output_info_name_length([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_output_info_name_end([NativeTypeName("const xcb_randr_get_output_info_reply_t *")] xcb_randr_get_output_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_info_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_output_info_reply_t* get_output_info_reply(xcb_connection_t* c, xcb_randr_get_output_info_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_output_properties_sizeof", ExactSpelling = true)]
    public static extern int list_output_properties_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_output_properties", ExactSpelling = true)]
    public static extern xcb_randr_list_output_properties_cookie_t list_output_properties(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_output_properties_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_list_output_properties_cookie_t list_output_properties_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_output_properties_atoms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* list_output_properties_atoms([NativeTypeName("const xcb_randr_list_output_properties_reply_t *")] xcb_randr_list_output_properties_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_output_properties_atoms_length", ExactSpelling = true)]
    public static extern int list_output_properties_atoms_length([NativeTypeName("const xcb_randr_list_output_properties_reply_t *")] xcb_randr_list_output_properties_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_output_properties_atoms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t list_output_properties_atoms_end([NativeTypeName("const xcb_randr_list_output_properties_reply_t *")] xcb_randr_list_output_properties_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_output_properties_reply", ExactSpelling = true)]
    public static extern xcb_randr_list_output_properties_reply_t* list_output_properties_reply(xcb_connection_t* c, xcb_randr_list_output_properties_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_output_property_sizeof", ExactSpelling = true)]
    public static extern int query_output_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_output_property", ExactSpelling = true)]
    public static extern xcb_randr_query_output_property_cookie_t query_output_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_output_property_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_query_output_property_cookie_t query_output_property_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_output_property_valid_values", ExactSpelling = true)]
    [return: NativeTypeName("int32_t *")]
    public static extern int* query_output_property_valid_values([NativeTypeName("const xcb_randr_query_output_property_reply_t *")] xcb_randr_query_output_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_output_property_valid_values_length", ExactSpelling = true)]
    public static extern int query_output_property_valid_values_length([NativeTypeName("const xcb_randr_query_output_property_reply_t *")] xcb_randr_query_output_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_output_property_valid_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t query_output_property_valid_values_end([NativeTypeName("const xcb_randr_query_output_property_reply_t *")] xcb_randr_query_output_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_output_property_reply", ExactSpelling = true)]
    public static extern xcb_randr_query_output_property_reply_t* query_output_property_reply(xcb_connection_t* c, xcb_randr_query_output_property_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_output_property_sizeof", ExactSpelling = true)]
    public static extern int configure_output_property_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint values_len);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_output_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t configure_output_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("uint8_t")] byte pending, [NativeTypeName("uint8_t")] byte range, [NativeTypeName("uint32_t")] uint values_len, [NativeTypeName("const int32_t *")] int* values);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_output_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t configure_output_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("uint8_t")] byte pending, [NativeTypeName("uint8_t")] byte range, [NativeTypeName("uint32_t")] uint values_len, [NativeTypeName("const int32_t *")] int* values);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_output_property_values", ExactSpelling = true)]
    [return: NativeTypeName("int32_t *")]
    public static extern int* configure_output_property_values([NativeTypeName("const xcb_randr_configure_output_property_request_t *")] xcb_randr_configure_output_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_output_property_values_length", ExactSpelling = true)]
    public static extern int configure_output_property_values_length([NativeTypeName("const xcb_randr_configure_output_property_request_t *")] xcb_randr_configure_output_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_output_property_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t configure_output_property_values_end([NativeTypeName("const xcb_randr_configure_output_property_request_t *")] xcb_randr_configure_output_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_output_property_sizeof", ExactSpelling = true)]
    public static extern int change_output_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_output_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_output_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint32_t")] uint num_units, [NativeTypeName("const void *")] void* data);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_output_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_output_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint32_t")] uint num_units, [NativeTypeName("const void *")] void* data);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_output_property_data", ExactSpelling = true)]
    public static extern void* change_output_property_data([NativeTypeName("const xcb_randr_change_output_property_request_t *")] xcb_randr_change_output_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_output_property_data_length", ExactSpelling = true)]
    public static extern int change_output_property_data_length([NativeTypeName("const xcb_randr_change_output_property_request_t *")] xcb_randr_change_output_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_output_property_data_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t change_output_property_data_end([NativeTypeName("const xcb_randr_change_output_property_request_t *")] xcb_randr_change_output_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_delete_output_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_output_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_delete_output_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_output_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_property_sizeof", ExactSpelling = true)]
    public static extern int get_output_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_property", ExactSpelling = true)]
    public static extern xcb_randr_get_output_property_cookie_t get_output_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint long_offset, [NativeTypeName("uint32_t")] uint long_length, [NativeTypeName("uint8_t")] byte _delete, [NativeTypeName("uint8_t")] byte pending);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_property_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_output_property_cookie_t get_output_property_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint long_offset, [NativeTypeName("uint32_t")] uint long_length, [NativeTypeName("uint8_t")] byte _delete, [NativeTypeName("uint8_t")] byte pending);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_property_data", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_output_property_data([NativeTypeName("const xcb_randr_get_output_property_reply_t *")] xcb_randr_get_output_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_property_data_length", ExactSpelling = true)]
    public static extern int get_output_property_data_length([NativeTypeName("const xcb_randr_get_output_property_reply_t *")] xcb_randr_get_output_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_property_data_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_output_property_data_end([NativeTypeName("const xcb_randr_get_output_property_reply_t *")] xcb_randr_get_output_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_property_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_output_property_reply_t* get_output_property_reply(xcb_connection_t* c, xcb_randr_get_output_property_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_mode_sizeof", ExactSpelling = true)]
    public static extern int create_mode_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint name_len);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_mode", ExactSpelling = true)]
    public static extern xcb_randr_create_mode_cookie_t create_mode(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, xcb_randr_mode_info_t mode_info, [NativeTypeName("uint32_t")] uint name_len, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_mode_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_create_mode_cookie_t create_mode_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, xcb_randr_mode_info_t mode_info, [NativeTypeName("uint32_t")] uint name_len, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_mode_reply", ExactSpelling = true)]
    public static extern xcb_randr_create_mode_reply_t* create_mode_reply(xcb_connection_t* c, xcb_randr_create_mode_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_destroy_mode_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t destroy_mode_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_mode_t")] uint mode);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_destroy_mode", ExactSpelling = true)]
    public static extern xcb_void_cookie_t destroy_mode(xcb_connection_t* c, [NativeTypeName("xcb_randr_mode_t")] uint mode);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_add_output_mode_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t add_output_mode_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_randr_mode_t")] uint mode);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_add_output_mode", ExactSpelling = true)]
    public static extern xcb_void_cookie_t add_output_mode(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_randr_mode_t")] uint mode);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_delete_output_mode_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_output_mode_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_randr_mode_t")] uint mode);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_delete_output_mode", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_output_mode(xcb_connection_t* c, [NativeTypeName("xcb_randr_output_t")] uint output, [NativeTypeName("xcb_randr_mode_t")] uint mode);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_sizeof", ExactSpelling = true)]
    public static extern int get_crtc_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_info_cookie_t get_crtc_info(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_info_cookie_t get_crtc_info_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_outputs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_output_t *")]
    public static extern uint* get_crtc_info_outputs([NativeTypeName("const xcb_randr_get_crtc_info_reply_t *")] xcb_randr_get_crtc_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_outputs_length", ExactSpelling = true)]
    public static extern int get_crtc_info_outputs_length([NativeTypeName("const xcb_randr_get_crtc_info_reply_t *")] xcb_randr_get_crtc_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_outputs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_info_outputs_end([NativeTypeName("const xcb_randr_get_crtc_info_reply_t *")] xcb_randr_get_crtc_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_possible", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_output_t *")]
    public static extern uint* get_crtc_info_possible([NativeTypeName("const xcb_randr_get_crtc_info_reply_t *")] xcb_randr_get_crtc_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_possible_length", ExactSpelling = true)]
    public static extern int get_crtc_info_possible_length([NativeTypeName("const xcb_randr_get_crtc_info_reply_t *")] xcb_randr_get_crtc_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_possible_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_info_possible_end([NativeTypeName("const xcb_randr_get_crtc_info_reply_t *")] xcb_randr_get_crtc_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_info_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_info_reply_t* get_crtc_info_reply(xcb_connection_t* c, xcb_randr_get_crtc_info_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_config_sizeof", ExactSpelling = true)]
    public static extern int set_crtc_config_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint outputs_len);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_config", ExactSpelling = true)]
    public static extern xcb_randr_set_crtc_config_cookie_t set_crtc_config(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, [NativeTypeName("xcb_timestamp_t")] uint timestamp, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("xcb_randr_mode_t")] uint mode, [NativeTypeName("uint16_t")] ushort rotation, [NativeTypeName("uint32_t")] uint outputs_len, [NativeTypeName("const xcb_randr_output_t *")] uint* outputs);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_config_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_set_crtc_config_cookie_t set_crtc_config_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, [NativeTypeName("xcb_timestamp_t")] uint timestamp, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("xcb_randr_mode_t")] uint mode, [NativeTypeName("uint16_t")] ushort rotation, [NativeTypeName("uint32_t")] uint outputs_len, [NativeTypeName("const xcb_randr_output_t *")] uint* outputs);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_config_reply", ExactSpelling = true)]
    public static extern xcb_randr_set_crtc_config_reply_t* set_crtc_config_reply(xcb_connection_t* c, xcb_randr_set_crtc_config_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_size", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_gamma_size_cookie_t get_crtc_gamma_size(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_size_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_gamma_size_cookie_t get_crtc_gamma_size_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_size_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_gamma_size_reply_t* get_crtc_gamma_size_reply(xcb_connection_t* c, xcb_randr_get_crtc_gamma_size_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_sizeof", ExactSpelling = true)]
    public static extern int get_crtc_gamma_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_gamma_cookie_t get_crtc_gamma(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_gamma_cookie_t get_crtc_gamma_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_red", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* get_crtc_gamma_red([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_red_length", ExactSpelling = true)]
    public static extern int get_crtc_gamma_red_length([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_red_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_gamma_red_end([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_green", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* get_crtc_gamma_green([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_green_length", ExactSpelling = true)]
    public static extern int get_crtc_gamma_green_length([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_green_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_gamma_green_end([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_blue", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* get_crtc_gamma_blue([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_blue_length", ExactSpelling = true)]
    public static extern int get_crtc_gamma_blue_length([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_blue_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_gamma_blue_end([NativeTypeName("const xcb_randr_get_crtc_gamma_reply_t *")] xcb_randr_get_crtc_gamma_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_gamma_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_gamma_reply_t* get_crtc_gamma_reply(xcb_connection_t* c, xcb_randr_get_crtc_gamma_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_sizeof", ExactSpelling = true)]
    public static extern int set_crtc_gamma_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_crtc_gamma_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, [NativeTypeName("uint16_t")] ushort size, [NativeTypeName("const uint16_t *")] ushort* red, [NativeTypeName("const uint16_t *")] ushort* green, [NativeTypeName("const uint16_t *")] ushort* blue);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_crtc_gamma(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, [NativeTypeName("uint16_t")] ushort size, [NativeTypeName("const uint16_t *")] ushort* red, [NativeTypeName("const uint16_t *")] ushort* green, [NativeTypeName("const uint16_t *")] ushort* blue);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_red", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* set_crtc_gamma_red([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_red_length", ExactSpelling = true)]
    public static extern int set_crtc_gamma_red_length([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_red_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_crtc_gamma_red_end([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_green", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* set_crtc_gamma_green([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_green_length", ExactSpelling = true)]
    public static extern int set_crtc_gamma_green_length([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_green_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_crtc_gamma_green_end([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_blue", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* set_crtc_gamma_blue([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_blue_length", ExactSpelling = true)]
    public static extern int set_crtc_gamma_blue_length([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_gamma_blue_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_crtc_gamma_blue_end([NativeTypeName("const xcb_randr_set_crtc_gamma_request_t *")] xcb_randr_set_crtc_gamma_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_sizeof", ExactSpelling = true)]
    public static extern int get_screen_resources_current_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_resources_current_cookie_t get_screen_resources_current(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_resources_current_cookie_t get_screen_resources_current_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_crtcs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_crtc_t *")]
    public static extern uint* get_screen_resources_current_crtcs([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_crtcs_length", ExactSpelling = true)]
    public static extern int get_screen_resources_current_crtcs_length([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_crtcs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_screen_resources_current_crtcs_end([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_outputs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_output_t *")]
    public static extern uint* get_screen_resources_current_outputs([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_outputs_length", ExactSpelling = true)]
    public static extern int get_screen_resources_current_outputs_length([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_outputs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_screen_resources_current_outputs_end([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_modes", ExactSpelling = true)]
    public static extern xcb_randr_mode_info_t* get_screen_resources_current_modes([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_modes_length", ExactSpelling = true)]
    public static extern int get_screen_resources_current_modes_length([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_modes_iterator", ExactSpelling = true)]
    public static extern xcb_randr_mode_info_iterator_t get_screen_resources_current_modes_iterator([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_names", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_screen_resources_current_names([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_names_length", ExactSpelling = true)]
    public static extern int get_screen_resources_current_names_length([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_screen_resources_current_names_end([NativeTypeName("const xcb_randr_get_screen_resources_current_reply_t *")] xcb_randr_get_screen_resources_current_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_screen_resources_current_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_screen_resources_current_reply_t* get_screen_resources_current_reply(xcb_connection_t* c, xcb_randr_get_screen_resources_current_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform_sizeof", ExactSpelling = true)]
    public static extern int set_crtc_transform_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint filter_params_len);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_crtc_transform_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, xcb_render_transform_t transform, [NativeTypeName("uint16_t")] ushort filter_len, [NativeTypeName("const char *")] sbyte* filter_name, [NativeTypeName("uint32_t")] uint filter_params_len, [NativeTypeName("const xcb_render_fixed_t *")] int* filter_params);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_crtc_transform(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, xcb_render_transform_t transform, [NativeTypeName("uint16_t")] ushort filter_len, [NativeTypeName("const char *")] sbyte* filter_name, [NativeTypeName("uint32_t")] uint filter_params_len, [NativeTypeName("const xcb_render_fixed_t *")] int* filter_params);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform_filter_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* set_crtc_transform_filter_name([NativeTypeName("const xcb_randr_set_crtc_transform_request_t *")] xcb_randr_set_crtc_transform_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform_filter_name_length", ExactSpelling = true)]
    public static extern int set_crtc_transform_filter_name_length([NativeTypeName("const xcb_randr_set_crtc_transform_request_t *")] xcb_randr_set_crtc_transform_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform_filter_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_crtc_transform_filter_name_end([NativeTypeName("const xcb_randr_set_crtc_transform_request_t *")] xcb_randr_set_crtc_transform_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform_filter_params", ExactSpelling = true)]
    [return: NativeTypeName("xcb_render_fixed_t *")]
    public static extern int* set_crtc_transform_filter_params([NativeTypeName("const xcb_randr_set_crtc_transform_request_t *")] xcb_randr_set_crtc_transform_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform_filter_params_length", ExactSpelling = true)]
    public static extern int set_crtc_transform_filter_params_length([NativeTypeName("const xcb_randr_set_crtc_transform_request_t *")] xcb_randr_set_crtc_transform_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_crtc_transform_filter_params_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_crtc_transform_filter_params_end([NativeTypeName("const xcb_randr_set_crtc_transform_request_t *")] xcb_randr_set_crtc_transform_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_sizeof", ExactSpelling = true)]
    public static extern int get_crtc_transform_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_transform_cookie_t get_crtc_transform(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_transform_cookie_t get_crtc_transform_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_pending_filter_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* get_crtc_transform_pending_filter_name([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_pending_filter_name_length", ExactSpelling = true)]
    public static extern int get_crtc_transform_pending_filter_name_length([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_pending_filter_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_transform_pending_filter_name_end([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_pending_params", ExactSpelling = true)]
    [return: NativeTypeName("xcb_render_fixed_t *")]
    public static extern int* get_crtc_transform_pending_params([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_pending_params_length", ExactSpelling = true)]
    public static extern int get_crtc_transform_pending_params_length([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_pending_params_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_transform_pending_params_end([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_current_filter_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* get_crtc_transform_current_filter_name([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_current_filter_name_length", ExactSpelling = true)]
    public static extern int get_crtc_transform_current_filter_name_length([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_current_filter_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_transform_current_filter_name_end([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_current_params", ExactSpelling = true)]
    [return: NativeTypeName("xcb_render_fixed_t *")]
    public static extern int* get_crtc_transform_current_params([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_current_params_length", ExactSpelling = true)]
    public static extern int get_crtc_transform_current_params_length([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_current_params_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_crtc_transform_current_params_end([NativeTypeName("const xcb_randr_get_crtc_transform_reply_t *")] xcb_randr_get_crtc_transform_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_crtc_transform_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_crtc_transform_reply_t* get_crtc_transform_reply(xcb_connection_t* c, xcb_randr_get_crtc_transform_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_panning", ExactSpelling = true)]
    public static extern xcb_randr_get_panning_cookie_t get_panning(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_panning_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_panning_cookie_t get_panning_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_panning_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_panning_reply_t* get_panning_reply(xcb_connection_t* c, xcb_randr_get_panning_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_panning", ExactSpelling = true)]
    public static extern xcb_randr_set_panning_cookie_t set_panning(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, [NativeTypeName("xcb_timestamp_t")] uint timestamp, [NativeTypeName("uint16_t")] ushort left, [NativeTypeName("uint16_t")] ushort top, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint16_t")] ushort track_left, [NativeTypeName("uint16_t")] ushort track_top, [NativeTypeName("uint16_t")] ushort track_width, [NativeTypeName("uint16_t")] ushort track_height, [NativeTypeName("int16_t")] short border_left, [NativeTypeName("int16_t")] short border_top, [NativeTypeName("int16_t")] short border_right, [NativeTypeName("int16_t")] short border_bottom);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_panning_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_set_panning_cookie_t set_panning_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_crtc_t")] uint crtc, [NativeTypeName("xcb_timestamp_t")] uint timestamp, [NativeTypeName("uint16_t")] ushort left, [NativeTypeName("uint16_t")] ushort top, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint16_t")] ushort track_left, [NativeTypeName("uint16_t")] ushort track_top, [NativeTypeName("uint16_t")] ushort track_width, [NativeTypeName("uint16_t")] ushort track_height, [NativeTypeName("int16_t")] short border_left, [NativeTypeName("int16_t")] short border_top, [NativeTypeName("int16_t")] short border_right, [NativeTypeName("int16_t")] short border_bottom);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_panning_reply", ExactSpelling = true)]
    public static extern xcb_randr_set_panning_reply_t* set_panning_reply(xcb_connection_t* c, xcb_randr_set_panning_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_output_primary_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_output_primary_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_randr_output_t")] uint output);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_output_primary", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_output_primary(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_randr_output_t")] uint output);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_primary", ExactSpelling = true)]
    public static extern xcb_randr_get_output_primary_cookie_t get_output_primary(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_primary_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_output_primary_cookie_t get_output_primary_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_output_primary_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_output_primary_reply_t* get_output_primary_reply(xcb_connection_t* c, xcb_randr_get_output_primary_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_providers_sizeof", ExactSpelling = true)]
    public static extern int get_providers_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_providers", ExactSpelling = true)]
    public static extern xcb_randr_get_providers_cookie_t get_providers(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_providers_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_providers_cookie_t get_providers_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_providers_providers", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_provider_t *")]
    public static extern uint* get_providers_providers([NativeTypeName("const xcb_randr_get_providers_reply_t *")] xcb_randr_get_providers_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_providers_providers_length", ExactSpelling = true)]
    public static extern int get_providers_providers_length([NativeTypeName("const xcb_randr_get_providers_reply_t *")] xcb_randr_get_providers_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_providers_providers_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_providers_providers_end([NativeTypeName("const xcb_randr_get_providers_reply_t *")] xcb_randr_get_providers_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_providers_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_providers_reply_t* get_providers_reply(xcb_connection_t* c, xcb_randr_get_providers_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_sizeof", ExactSpelling = true)]
    public static extern int get_provider_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info", ExactSpelling = true)]
    public static extern xcb_randr_get_provider_info_cookie_t get_provider_info(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_provider_info_cookie_t get_provider_info_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_crtcs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_crtc_t *")]
    public static extern uint* get_provider_info_crtcs([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_crtcs_length", ExactSpelling = true)]
    public static extern int get_provider_info_crtcs_length([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_crtcs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_provider_info_crtcs_end([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_outputs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_output_t *")]
    public static extern uint* get_provider_info_outputs([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_outputs_length", ExactSpelling = true)]
    public static extern int get_provider_info_outputs_length([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_outputs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_provider_info_outputs_end([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_associated_providers", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_provider_t *")]
    public static extern uint* get_provider_info_associated_providers([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_associated_providers_length", ExactSpelling = true)]
    public static extern int get_provider_info_associated_providers_length([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_associated_providers_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_provider_info_associated_providers_end([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_associated_capability", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* get_provider_info_associated_capability([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_associated_capability_length", ExactSpelling = true)]
    public static extern int get_provider_info_associated_capability_length([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_associated_capability_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_provider_info_associated_capability_end([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* get_provider_info_name([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_name_length", ExactSpelling = true)]
    public static extern int get_provider_info_name_length([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_provider_info_name_end([NativeTypeName("const xcb_randr_get_provider_info_reply_t *")] xcb_randr_get_provider_info_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_info_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_provider_info_reply_t* get_provider_info_reply(xcb_connection_t* c, xcb_randr_get_provider_info_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_provider_offload_sink_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_provider_offload_sink_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_randr_provider_t")] uint sink_provider, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_provider_offload_sink", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_provider_offload_sink(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_randr_provider_t")] uint sink_provider, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_provider_output_source_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_provider_output_source_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_randr_provider_t")] uint source_provider, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_provider_output_source", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_provider_output_source(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_randr_provider_t")] uint source_provider, [NativeTypeName("xcb_timestamp_t")] uint config_timestamp);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_provider_properties_sizeof", ExactSpelling = true)]
    public static extern int list_provider_properties_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_provider_properties", ExactSpelling = true)]
    public static extern xcb_randr_list_provider_properties_cookie_t list_provider_properties(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_provider_properties_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_list_provider_properties_cookie_t list_provider_properties_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_provider_properties_atoms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* list_provider_properties_atoms([NativeTypeName("const xcb_randr_list_provider_properties_reply_t *")] xcb_randr_list_provider_properties_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_provider_properties_atoms_length", ExactSpelling = true)]
    public static extern int list_provider_properties_atoms_length([NativeTypeName("const xcb_randr_list_provider_properties_reply_t *")] xcb_randr_list_provider_properties_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_provider_properties_atoms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t list_provider_properties_atoms_end([NativeTypeName("const xcb_randr_list_provider_properties_reply_t *")] xcb_randr_list_provider_properties_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_list_provider_properties_reply", ExactSpelling = true)]
    public static extern xcb_randr_list_provider_properties_reply_t* list_provider_properties_reply(xcb_connection_t* c, xcb_randr_list_provider_properties_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_provider_property_sizeof", ExactSpelling = true)]
    public static extern int query_provider_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_provider_property", ExactSpelling = true)]
    public static extern xcb_randr_query_provider_property_cookie_t query_provider_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_provider_property_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_query_provider_property_cookie_t query_provider_property_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_provider_property_valid_values", ExactSpelling = true)]
    [return: NativeTypeName("int32_t *")]
    public static extern int* query_provider_property_valid_values([NativeTypeName("const xcb_randr_query_provider_property_reply_t *")] xcb_randr_query_provider_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_provider_property_valid_values_length", ExactSpelling = true)]
    public static extern int query_provider_property_valid_values_length([NativeTypeName("const xcb_randr_query_provider_property_reply_t *")] xcb_randr_query_provider_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_provider_property_valid_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t query_provider_property_valid_values_end([NativeTypeName("const xcb_randr_query_provider_property_reply_t *")] xcb_randr_query_provider_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_query_provider_property_reply", ExactSpelling = true)]
    public static extern xcb_randr_query_provider_property_reply_t* query_provider_property_reply(xcb_connection_t* c, xcb_randr_query_provider_property_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_provider_property_sizeof", ExactSpelling = true)]
    public static extern int configure_provider_property_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint values_len);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_provider_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t configure_provider_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("uint8_t")] byte pending, [NativeTypeName("uint8_t")] byte range, [NativeTypeName("uint32_t")] uint values_len, [NativeTypeName("const int32_t *")] int* values);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_provider_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t configure_provider_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("uint8_t")] byte pending, [NativeTypeName("uint8_t")] byte range, [NativeTypeName("uint32_t")] uint values_len, [NativeTypeName("const int32_t *")] int* values);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_provider_property_values", ExactSpelling = true)]
    [return: NativeTypeName("int32_t *")]
    public static extern int* configure_provider_property_values([NativeTypeName("const xcb_randr_configure_provider_property_request_t *")] xcb_randr_configure_provider_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_provider_property_values_length", ExactSpelling = true)]
    public static extern int configure_provider_property_values_length([NativeTypeName("const xcb_randr_configure_provider_property_request_t *")] xcb_randr_configure_provider_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_configure_provider_property_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t configure_provider_property_values_end([NativeTypeName("const xcb_randr_configure_provider_property_request_t *")] xcb_randr_configure_provider_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_provider_property_sizeof", ExactSpelling = true)]
    public static extern int change_provider_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_provider_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_provider_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const void *")] void* data);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_provider_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_provider_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const void *")] void* data);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_provider_property_data", ExactSpelling = true)]
    public static extern void* change_provider_property_data([NativeTypeName("const xcb_randr_change_provider_property_request_t *")] xcb_randr_change_provider_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_provider_property_data_length", ExactSpelling = true)]
    public static extern int change_provider_property_data_length([NativeTypeName("const xcb_randr_change_provider_property_request_t *")] xcb_randr_change_provider_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_change_provider_property_data_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t change_provider_property_data_end([NativeTypeName("const xcb_randr_change_provider_property_request_t *")] xcb_randr_change_provider_property_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_delete_provider_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_provider_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_delete_provider_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_provider_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_property_sizeof", ExactSpelling = true)]
    public static extern int get_provider_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_property", ExactSpelling = true)]
    public static extern xcb_randr_get_provider_property_cookie_t get_provider_property(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint long_offset, [NativeTypeName("uint32_t")] uint long_length, [NativeTypeName("uint8_t")] byte _delete, [NativeTypeName("uint8_t")] byte pending);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_property_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_provider_property_cookie_t get_provider_property_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_randr_provider_t")] uint provider, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint long_offset, [NativeTypeName("uint32_t")] uint long_length, [NativeTypeName("uint8_t")] byte _delete, [NativeTypeName("uint8_t")] byte pending);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_property_data", ExactSpelling = true)]
    public static extern void* get_provider_property_data([NativeTypeName("const xcb_randr_get_provider_property_reply_t *")] xcb_randr_get_provider_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_property_data_length", ExactSpelling = true)]
    public static extern int get_provider_property_data_length([NativeTypeName("const xcb_randr_get_provider_property_reply_t *")] xcb_randr_get_provider_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_property_data_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_provider_property_data_end([NativeTypeName("const xcb_randr_get_provider_property_reply_t *")] xcb_randr_get_provider_property_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_provider_property_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_provider_property_reply_t* get_provider_property_reply(xcb_connection_t* c, xcb_randr_get_provider_property_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_crtc_change_next", ExactSpelling = true)]
    public static extern void crtc_change_next(xcb_randr_crtc_change_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_crtc_change_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t crtc_change_end(xcb_randr_crtc_change_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_output_change_next", ExactSpelling = true)]
    public static extern void output_change_next(xcb_randr_output_change_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_output_change_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t output_change_end(xcb_randr_output_change_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_output_property_next", ExactSpelling = true)]
    public static extern void output_property_next(xcb_randr_output_property_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_output_property_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t output_property_end(xcb_randr_output_property_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_provider_change_next", ExactSpelling = true)]
    public static extern void provider_change_next(xcb_randr_provider_change_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_provider_change_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t provider_change_end(xcb_randr_provider_change_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_provider_property_next", ExactSpelling = true)]
    public static extern void provider_property_next(xcb_randr_provider_property_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_provider_property_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t provider_property_end(xcb_randr_provider_property_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_resource_change_next", ExactSpelling = true)]
    public static extern void resource_change_next(xcb_randr_resource_change_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_resource_change_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t resource_change_end(xcb_randr_resource_change_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_monitor_info_sizeof", ExactSpelling = true)]
    public static extern int monitor_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_monitor_info_outputs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_randr_output_t *")]
    public static extern uint* monitor_info_outputs([NativeTypeName("const xcb_randr_monitor_info_t *")] xcb_randr_monitor_info_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_monitor_info_outputs_length", ExactSpelling = true)]
    public static extern int monitor_info_outputs_length([NativeTypeName("const xcb_randr_monitor_info_t *")] xcb_randr_monitor_info_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_monitor_info_outputs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t monitor_info_outputs_end([NativeTypeName("const xcb_randr_monitor_info_t *")] xcb_randr_monitor_info_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_monitor_info_next", ExactSpelling = true)]
    public static extern void monitor_info_next(xcb_randr_monitor_info_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_monitor_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t monitor_info_end(xcb_randr_monitor_info_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_monitors_sizeof", ExactSpelling = true)]
    public static extern int get_monitors_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_monitors", ExactSpelling = true)]
    public static extern xcb_randr_get_monitors_cookie_t get_monitors(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint8_t")] byte get_active);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_monitors_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_get_monitors_cookie_t get_monitors_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint8_t")] byte get_active);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_monitors_monitors_length", ExactSpelling = true)]
    public static extern int get_monitors_monitors_length([NativeTypeName("const xcb_randr_get_monitors_reply_t *")] xcb_randr_get_monitors_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_monitors_monitors_iterator", ExactSpelling = true)]
    public static extern xcb_randr_monitor_info_iterator_t get_monitors_monitors_iterator([NativeTypeName("const xcb_randr_get_monitors_reply_t *")] xcb_randr_get_monitors_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_get_monitors_reply", ExactSpelling = true)]
    public static extern xcb_randr_get_monitors_reply_t* get_monitors_reply(xcb_connection_t* c, xcb_randr_get_monitors_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_monitor_sizeof", ExactSpelling = true)]
    public static extern int set_monitor_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_monitor_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_monitor_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, xcb_randr_monitor_info_t* monitorinfo);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_monitor", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_monitor(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, xcb_randr_monitor_info_t* monitorinfo);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_set_monitor_monitorinfo", ExactSpelling = true)]
    public static extern xcb_randr_monitor_info_t* set_monitor_monitorinfo([NativeTypeName("const xcb_randr_set_monitor_request_t *")] xcb_randr_set_monitor_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_delete_monitor_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_monitor_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint name);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_delete_monitor", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_monitor(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint name);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_lease_sizeof", ExactSpelling = true)]
    public static extern int create_lease_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_lease", ExactSpelling = true)]
    public static extern xcb_randr_create_lease_cookie_t create_lease(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_randr_lease_t")] uint lid, [NativeTypeName("uint16_t")] ushort num_crtcs, [NativeTypeName("uint16_t")] ushort num_outputs, [NativeTypeName("const xcb_randr_crtc_t *")] uint* crtcs, [NativeTypeName("const xcb_randr_output_t *")] uint* outputs);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_lease_unchecked", ExactSpelling = true)]
    public static extern xcb_randr_create_lease_cookie_t create_lease_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_randr_lease_t")] uint lid, [NativeTypeName("uint16_t")] ushort num_crtcs, [NativeTypeName("uint16_t")] ushort num_outputs, [NativeTypeName("const xcb_randr_crtc_t *")] uint* crtcs, [NativeTypeName("const xcb_randr_output_t *")] uint* outputs);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_lease_reply", ExactSpelling = true)]
    public static extern xcb_randr_create_lease_reply_t* create_lease_reply(xcb_connection_t* c, xcb_randr_create_lease_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_create_lease_reply_fds", ExactSpelling = true)]
    public static extern int* create_lease_reply_fds(xcb_connection_t* c, xcb_randr_create_lease_reply_t* reply);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_free_lease_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t free_lease_checked(xcb_connection_t* c, [NativeTypeName("xcb_randr_lease_t")] uint lid, [NativeTypeName("uint8_t")] byte terminate);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_free_lease", ExactSpelling = true)]
    public static extern xcb_void_cookie_t free_lease(xcb_connection_t* c, [NativeTypeName("xcb_randr_lease_t")] uint lid, [NativeTypeName("uint8_t")] byte terminate);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_lease_notify_next", ExactSpelling = true)]
    public static extern void lease_notify_next(xcb_randr_lease_notify_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_lease_notify_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t lease_notify_end(xcb_randr_lease_notify_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_notify_data_next", ExactSpelling = true)]
    public static extern void notify_data_next(xcb_randr_notify_data_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_randr_notify_data_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t notify_data_end(xcb_randr_notify_data_iterator_t i);

    [NativeTypeName("#define XCB_RANDR_MAJOR_VERSION 1")]
    public const int XCB_RANDR_MAJOR_VERSION = 1;

    [NativeTypeName("#define XCB_RANDR_MINOR_VERSION 6")]
    public const int XCB_RANDR_MINOR_VERSION = 6;

    [NativeTypeName("#define XCB_RANDR_BAD_OUTPUT 0")]
    public const int XCB_RANDR_BAD_OUTPUT = 0;

    [NativeTypeName("#define XCB_RANDR_BAD_CRTC 1")]
    public const int XCB_RANDR_BAD_CRTC = 1;

    [NativeTypeName("#define XCB_RANDR_BAD_MODE 2")]
    public const int XCB_RANDR_BAD_MODE = 2;

    [NativeTypeName("#define XCB_RANDR_BAD_PROVIDER 3")]
    public const int XCB_RANDR_BAD_PROVIDER = 3;

    [NativeTypeName("#define XCB_RANDR_QUERY_VERSION 0")]
    public const int XCB_RANDR_QUERY_VERSION = 0;

    [NativeTypeName("#define XCB_RANDR_SET_SCREEN_CONFIG 2")]
    public const int XCB_RANDR_SET_SCREEN_CONFIG = 2;

    [NativeTypeName("#define XCB_RANDR_SELECT_INPUT 4")]
    public const int XCB_RANDR_SELECT_INPUT = 4;

    [NativeTypeName("#define XCB_RANDR_GET_SCREEN_INFO 5")]
    public const int XCB_RANDR_GET_SCREEN_INFO = 5;

    [NativeTypeName("#define XCB_RANDR_GET_SCREEN_SIZE_RANGE 6")]
    public const int XCB_RANDR_GET_SCREEN_SIZE_RANGE = 6;

    [NativeTypeName("#define XCB_RANDR_SET_SCREEN_SIZE 7")]
    public const int XCB_RANDR_SET_SCREEN_SIZE = 7;

    [NativeTypeName("#define XCB_RANDR_GET_SCREEN_RESOURCES 8")]
    public const int XCB_RANDR_GET_SCREEN_RESOURCES = 8;

    [NativeTypeName("#define XCB_RANDR_GET_OUTPUT_INFO 9")]
    public const int XCB_RANDR_GET_OUTPUT_INFO = 9;

    [NativeTypeName("#define XCB_RANDR_LIST_OUTPUT_PROPERTIES 10")]
    public const int XCB_RANDR_LIST_OUTPUT_PROPERTIES = 10;

    [NativeTypeName("#define XCB_RANDR_QUERY_OUTPUT_PROPERTY 11")]
    public const int XCB_RANDR_QUERY_OUTPUT_PROPERTY = 11;

    [NativeTypeName("#define XCB_RANDR_CONFIGURE_OUTPUT_PROPERTY 12")]
    public const int XCB_RANDR_CONFIGURE_OUTPUT_PROPERTY = 12;

    [NativeTypeName("#define XCB_RANDR_CHANGE_OUTPUT_PROPERTY 13")]
    public const int XCB_RANDR_CHANGE_OUTPUT_PROPERTY = 13;

    [NativeTypeName("#define XCB_RANDR_DELETE_OUTPUT_PROPERTY 14")]
    public const int XCB_RANDR_DELETE_OUTPUT_PROPERTY = 14;

    [NativeTypeName("#define XCB_RANDR_GET_OUTPUT_PROPERTY 15")]
    public const int XCB_RANDR_GET_OUTPUT_PROPERTY = 15;

    [NativeTypeName("#define XCB_RANDR_CREATE_MODE 16")]
    public const int XCB_RANDR_CREATE_MODE = 16;

    [NativeTypeName("#define XCB_RANDR_DESTROY_MODE 17")]
    public const int XCB_RANDR_DESTROY_MODE = 17;

    [NativeTypeName("#define XCB_RANDR_ADD_OUTPUT_MODE 18")]
    public const int XCB_RANDR_ADD_OUTPUT_MODE = 18;

    [NativeTypeName("#define XCB_RANDR_DELETE_OUTPUT_MODE 19")]
    public const int XCB_RANDR_DELETE_OUTPUT_MODE = 19;

    [NativeTypeName("#define XCB_RANDR_GET_CRTC_INFO 20")]
    public const int XCB_RANDR_GET_CRTC_INFO = 20;

    [NativeTypeName("#define XCB_RANDR_SET_CRTC_CONFIG 21")]
    public const int XCB_RANDR_SET_CRTC_CONFIG = 21;

    [NativeTypeName("#define XCB_RANDR_GET_CRTC_GAMMA_SIZE 22")]
    public const int XCB_RANDR_GET_CRTC_GAMMA_SIZE = 22;

    [NativeTypeName("#define XCB_RANDR_GET_CRTC_GAMMA 23")]
    public const int XCB_RANDR_GET_CRTC_GAMMA = 23;

    [NativeTypeName("#define XCB_RANDR_SET_CRTC_GAMMA 24")]
    public const int XCB_RANDR_SET_CRTC_GAMMA = 24;

    [NativeTypeName("#define XCB_RANDR_GET_SCREEN_RESOURCES_CURRENT 25")]
    public const int XCB_RANDR_GET_SCREEN_RESOURCES_CURRENT = 25;

    [NativeTypeName("#define XCB_RANDR_SET_CRTC_TRANSFORM 26")]
    public const int XCB_RANDR_SET_CRTC_TRANSFORM = 26;

    [NativeTypeName("#define XCB_RANDR_GET_CRTC_TRANSFORM 27")]
    public const int XCB_RANDR_GET_CRTC_TRANSFORM = 27;

    [NativeTypeName("#define XCB_RANDR_GET_PANNING 28")]
    public const int XCB_RANDR_GET_PANNING = 28;

    [NativeTypeName("#define XCB_RANDR_SET_PANNING 29")]
    public const int XCB_RANDR_SET_PANNING = 29;

    [NativeTypeName("#define XCB_RANDR_SET_OUTPUT_PRIMARY 30")]
    public const int XCB_RANDR_SET_OUTPUT_PRIMARY = 30;

    [NativeTypeName("#define XCB_RANDR_GET_OUTPUT_PRIMARY 31")]
    public const int XCB_RANDR_GET_OUTPUT_PRIMARY = 31;

    [NativeTypeName("#define XCB_RANDR_GET_PROVIDERS 32")]
    public const int XCB_RANDR_GET_PROVIDERS = 32;

    [NativeTypeName("#define XCB_RANDR_GET_PROVIDER_INFO 33")]
    public const int XCB_RANDR_GET_PROVIDER_INFO = 33;

    [NativeTypeName("#define XCB_RANDR_SET_PROVIDER_OFFLOAD_SINK 34")]
    public const int XCB_RANDR_SET_PROVIDER_OFFLOAD_SINK = 34;

    [NativeTypeName("#define XCB_RANDR_SET_PROVIDER_OUTPUT_SOURCE 35")]
    public const int XCB_RANDR_SET_PROVIDER_OUTPUT_SOURCE = 35;

    [NativeTypeName("#define XCB_RANDR_LIST_PROVIDER_PROPERTIES 36")]
    public const int XCB_RANDR_LIST_PROVIDER_PROPERTIES = 36;

    [NativeTypeName("#define XCB_RANDR_QUERY_PROVIDER_PROPERTY 37")]
    public const int XCB_RANDR_QUERY_PROVIDER_PROPERTY = 37;

    [NativeTypeName("#define XCB_RANDR_CONFIGURE_PROVIDER_PROPERTY 38")]
    public const int XCB_RANDR_CONFIGURE_PROVIDER_PROPERTY = 38;

    [NativeTypeName("#define XCB_RANDR_CHANGE_PROVIDER_PROPERTY 39")]
    public const int XCB_RANDR_CHANGE_PROVIDER_PROPERTY = 39;

    [NativeTypeName("#define XCB_RANDR_DELETE_PROVIDER_PROPERTY 40")]
    public const int XCB_RANDR_DELETE_PROVIDER_PROPERTY = 40;

    [NativeTypeName("#define XCB_RANDR_GET_PROVIDER_PROPERTY 41")]
    public const int XCB_RANDR_GET_PROVIDER_PROPERTY = 41;

    [NativeTypeName("#define XCB_RANDR_SCREEN_CHANGE_NOTIFY 0")]
    public const int XCB_RANDR_SCREEN_CHANGE_NOTIFY = 0;

    [NativeTypeName("#define XCB_RANDR_GET_MONITORS 42")]
    public const int XCB_RANDR_GET_MONITORS = 42;

    [NativeTypeName("#define XCB_RANDR_SET_MONITOR 43")]
    public const int XCB_RANDR_SET_MONITOR = 43;

    [NativeTypeName("#define XCB_RANDR_DELETE_MONITOR 44")]
    public const int XCB_RANDR_DELETE_MONITOR = 44;

    [NativeTypeName("#define XCB_RANDR_CREATE_LEASE 45")]
    public const int XCB_RANDR_CREATE_LEASE = 45;

    [NativeTypeName("#define XCB_RANDR_FREE_LEASE 46")]
    public const int XCB_RANDR_FREE_LEASE = 46;

    [NativeTypeName("#define XCB_RANDR_NOTIFY 1")]
    public const int XCB_RANDR_NOTIFY = 1;
}

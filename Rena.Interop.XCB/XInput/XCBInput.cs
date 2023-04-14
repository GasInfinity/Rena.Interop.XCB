using System.Runtime.InteropServices;

namespace Rena.Interop.XCB;

public static unsafe partial class XCBInput
{
    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_info", ExactSpelling = true)]
    public static extern void* input_info_info([NativeTypeName("const xcb_input_input_info_t *")] xcb_input_input_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_data", ExactSpelling = true)]
    public static extern void* feedback_state_data([NativeTypeName("const xcb_input_feedback_state_t *")] xcb_input_feedback_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_data", ExactSpelling = true)]
    public static extern void* feedback_ctl_data([NativeTypeName("const xcb_input_feedback_ctl_t *")] xcb_input_feedback_ctl_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_data", ExactSpelling = true)]
    public static extern void* input_state_data([NativeTypeName("const xcb_input_input_state_t *")] xcb_input_input_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data", ExactSpelling = true)]
    public static extern void* device_state_data([NativeTypeName("const xcb_input_device_state_t *")] xcb_input_device_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_data", ExactSpelling = true)]
    public static extern void* device_ctl_data([NativeTypeName("const xcb_input_device_ctl_t *")] xcb_input_device_ctl_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_data", ExactSpelling = true)]
    public static extern void* hierarchy_change_data([NativeTypeName("const xcb_input_hierarchy_change_t *")] xcb_input_hierarchy_change_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data", ExactSpelling = true)]
    public static extern void* device_class_data([NativeTypeName("const xcb_input_device_class_t *")] xcb_input_device_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_class_next", ExactSpelling = true)]
    public static extern void event_class_next(xcb_input_event_class_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_class_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t event_class_end(xcb_input_event_class_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_code_next", ExactSpelling = true)]
    public static extern void key_code_next(xcb_input_key_code_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_code_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_code_end(xcb_input_key_code_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_id_next", ExactSpelling = true)]
    public static extern void device_id_next(xcb_input_device_id_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_id_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_id_end(xcb_input_device_id_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_fp1616_next", ExactSpelling = true)]
    public static extern void fp1616_next(xcb_input_fp1616_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_fp1616_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t fp1616_end(xcb_input_fp1616_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_fp3232_next", ExactSpelling = true)]
    public static extern void fp3232_next(xcb_input_fp3232_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_fp3232_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t fp3232_end(xcb_input_fp3232_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_extension_version_sizeof", ExactSpelling = true)]
    public static extern int get_extension_version_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_extension_version", ExactSpelling = true)]
    public static extern xcb_input_get_extension_version_cookie_t get_extension_version(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_extension_version_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_extension_version_cookie_t get_extension_version_unchecked(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_extension_version_reply", ExactSpelling = true)]
    public static extern xcb_input_get_extension_version_reply_t* get_extension_version_reply(xcb_connection_t* c, xcb_input_get_extension_version_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_info_next", ExactSpelling = true)]
    public static extern void device_info_next(xcb_input_device_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_info_end(xcb_input_device_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_info_next", ExactSpelling = true)]
    public static extern void key_info_next(xcb_input_key_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_info_end(xcb_input_key_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_info_next", ExactSpelling = true)]
    public static extern void button_info_next(xcb_input_button_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t button_info_end(xcb_input_button_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_axis_info_next", ExactSpelling = true)]
    public static extern void axis_info_next(xcb_input_axis_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_axis_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t axis_info_end(xcb_input_axis_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_info_sizeof", ExactSpelling = true)]
    public static extern int valuator_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_info_axes", ExactSpelling = true)]
    public static extern xcb_input_axis_info_t* valuator_info_axes([NativeTypeName("const xcb_input_valuator_info_t *")] xcb_input_valuator_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_info_axes_length", ExactSpelling = true)]
    public static extern int valuator_info_axes_length([NativeTypeName("const xcb_input_valuator_info_t *")] xcb_input_valuator_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_info_axes_iterator", ExactSpelling = true)]
    public static extern xcb_input_axis_info_iterator_t valuator_info_axes_iterator([NativeTypeName("const xcb_input_valuator_info_t *")] xcb_input_valuator_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_info_next", ExactSpelling = true)]
    public static extern void valuator_info_next(xcb_input_valuator_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t valuator_info_end(xcb_input_valuator_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_info_valuator_axes", ExactSpelling = true)]
    public static extern xcb_input_axis_info_t* input_info_info_valuator_axes([NativeTypeName("const xcb_input_input_info_info_t *")] xcb_input_input_info_info_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_info_valuator_axes_length", ExactSpelling = true)]
    public static extern int input_info_info_valuator_axes_length([NativeTypeName("const xcb_input_input_info_t *")] xcb_input_input_info_t* R, [NativeTypeName("const xcb_input_input_info_info_t *")] xcb_input_input_info_info_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_info_valuator_axes_iterator", ExactSpelling = true)]
    public static extern xcb_input_axis_info_iterator_t input_info_info_valuator_axes_iterator([NativeTypeName("const xcb_input_input_info_t *")] xcb_input_input_info_t* R, [NativeTypeName("const xcb_input_input_info_info_t *")] xcb_input_input_info_info_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_info_serialize", ExactSpelling = true)]
    public static extern int input_info_info_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte class_id, [NativeTypeName("const xcb_input_input_info_info_t *")] xcb_input_input_info_info_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_info_unpack", ExactSpelling = true)]
    public static extern int input_info_info_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte class_id, xcb_input_input_info_info_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_info_sizeof", ExactSpelling = true)]
    public static extern int input_info_info_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte class_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_sizeof", ExactSpelling = true)]
    public static extern int input_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_next", ExactSpelling = true)]
    public static extern void input_info_next(xcb_input_input_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t input_info_end(xcb_input_input_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_name_sizeof", ExactSpelling = true)]
    public static extern int device_name_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_name_string", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* device_name_string([NativeTypeName("const xcb_input_device_name_t *")] xcb_input_device_name_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_name_string_length", ExactSpelling = true)]
    public static extern int device_name_string_length([NativeTypeName("const xcb_input_device_name_t *")] xcb_input_device_name_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_name_string_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_name_string_end([NativeTypeName("const xcb_input_device_name_t *")] xcb_input_device_name_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_name_next", ExactSpelling = true)]
    public static extern void device_name_next(xcb_input_device_name_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_name_end(xcb_input_device_name_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_sizeof", ExactSpelling = true)]
    public static extern int list_input_devices_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices", ExactSpelling = true)]
    public static extern xcb_input_list_input_devices_cookie_t list_input_devices(xcb_connection_t* c);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_unchecked", ExactSpelling = true)]
    public static extern xcb_input_list_input_devices_cookie_t list_input_devices_unchecked(xcb_connection_t* c);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_devices", ExactSpelling = true)]
    public static extern xcb_input_device_info_t* list_input_devices_devices([NativeTypeName("const xcb_input_list_input_devices_reply_t *")] xcb_input_list_input_devices_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_devices_length", ExactSpelling = true)]
    public static extern int list_input_devices_devices_length([NativeTypeName("const xcb_input_list_input_devices_reply_t *")] xcb_input_list_input_devices_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_devices_iterator", ExactSpelling = true)]
    public static extern xcb_input_device_info_iterator_t list_input_devices_devices_iterator([NativeTypeName("const xcb_input_list_input_devices_reply_t *")] xcb_input_list_input_devices_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_infos_length", ExactSpelling = true)]
    public static extern int list_input_devices_infos_length([NativeTypeName("const xcb_input_list_input_devices_reply_t *")] xcb_input_list_input_devices_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_infos_iterator", ExactSpelling = true)]
    public static extern xcb_input_input_info_iterator_t list_input_devices_infos_iterator([NativeTypeName("const xcb_input_list_input_devices_reply_t *")] xcb_input_list_input_devices_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_names_length", ExactSpelling = true)]
    public static extern int list_input_devices_names_length([NativeTypeName("const xcb_input_list_input_devices_reply_t *")] xcb_input_list_input_devices_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_names_iterator", ExactSpelling = true)]
    public static extern xcb_str_iterator_t list_input_devices_names_iterator([NativeTypeName("const xcb_input_list_input_devices_reply_t *")] xcb_input_list_input_devices_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_input_devices_reply", ExactSpelling = true)]
    public static extern xcb_input_list_input_devices_reply_t* list_input_devices_reply(xcb_connection_t* c, xcb_input_list_input_devices_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_type_base_next", ExactSpelling = true)]
    public static extern void event_type_base_next(xcb_input_event_type_base_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_type_base_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t event_type_base_end(xcb_input_event_type_base_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_class_info_next", ExactSpelling = true)]
    public static extern void input_class_info_next(xcb_input_input_class_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_class_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t input_class_info_end(xcb_input_input_class_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_open_device_sizeof", ExactSpelling = true)]
    public static extern int open_device_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_open_device", ExactSpelling = true)]
    public static extern xcb_input_open_device_cookie_t open_device(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_open_device_unchecked", ExactSpelling = true)]
    public static extern xcb_input_open_device_cookie_t open_device_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_open_device_class_info", ExactSpelling = true)]
    public static extern xcb_input_input_class_info_t* open_device_class_info([NativeTypeName("const xcb_input_open_device_reply_t *")] xcb_input_open_device_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_open_device_class_info_length", ExactSpelling = true)]
    public static extern int open_device_class_info_length([NativeTypeName("const xcb_input_open_device_reply_t *")] xcb_input_open_device_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_open_device_class_info_iterator", ExactSpelling = true)]
    public static extern xcb_input_input_class_info_iterator_t open_device_class_info_iterator([NativeTypeName("const xcb_input_open_device_reply_t *")] xcb_input_open_device_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_open_device_reply", ExactSpelling = true)]
    public static extern xcb_input_open_device_reply_t* open_device_reply(xcb_connection_t* c, xcb_input_open_device_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_close_device_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t close_device_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_close_device", ExactSpelling = true)]
    public static extern xcb_void_cookie_t close_device(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_mode", ExactSpelling = true)]
    public static extern xcb_input_set_device_mode_cookie_t set_device_mode(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte mode);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_mode_unchecked", ExactSpelling = true)]
    public static extern xcb_input_set_device_mode_cookie_t set_device_mode_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte mode);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_mode_reply", ExactSpelling = true)]
    public static extern xcb_input_set_device_mode_reply_t* set_device_mode_reply(xcb_connection_t* c, xcb_input_set_device_mode_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_select_extension_event_sizeof", ExactSpelling = true)]
    public static extern int select_extension_event_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_select_extension_event_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_extension_event_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_select_extension_event", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_extension_event(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_select_extension_event_classes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_input_event_class_t *")]
    public static extern uint* select_extension_event_classes([NativeTypeName("const xcb_input_select_extension_event_request_t *")] xcb_input_select_extension_event_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_select_extension_event_classes_length", ExactSpelling = true)]
    public static extern int select_extension_event_classes_length([NativeTypeName("const xcb_input_select_extension_event_request_t *")] xcb_input_select_extension_event_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_select_extension_event_classes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t select_extension_event_classes_end([NativeTypeName("const xcb_input_select_extension_event_request_t *")] xcb_input_select_extension_event_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_sizeof", ExactSpelling = true)]
    public static extern int get_selected_extension_events_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events", ExactSpelling = true)]
    public static extern xcb_input_get_selected_extension_events_cookie_t get_selected_extension_events(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_selected_extension_events_cookie_t get_selected_extension_events_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_this_classes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_input_event_class_t *")]
    public static extern uint* get_selected_extension_events_this_classes([NativeTypeName("const xcb_input_get_selected_extension_events_reply_t *")] xcb_input_get_selected_extension_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_this_classes_length", ExactSpelling = true)]
    public static extern int get_selected_extension_events_this_classes_length([NativeTypeName("const xcb_input_get_selected_extension_events_reply_t *")] xcb_input_get_selected_extension_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_this_classes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_selected_extension_events_this_classes_end([NativeTypeName("const xcb_input_get_selected_extension_events_reply_t *")] xcb_input_get_selected_extension_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_all_classes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_input_event_class_t *")]
    public static extern uint* get_selected_extension_events_all_classes([NativeTypeName("const xcb_input_get_selected_extension_events_reply_t *")] xcb_input_get_selected_extension_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_all_classes_length", ExactSpelling = true)]
    public static extern int get_selected_extension_events_all_classes_length([NativeTypeName("const xcb_input_get_selected_extension_events_reply_t *")] xcb_input_get_selected_extension_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_all_classes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_selected_extension_events_all_classes_end([NativeTypeName("const xcb_input_get_selected_extension_events_reply_t *")] xcb_input_get_selected_extension_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_selected_extension_events_reply", ExactSpelling = true)]
    public static extern xcb_input_get_selected_extension_events_reply_t* get_selected_extension_events_reply(xcb_connection_t* c, xcb_input_get_selected_extension_events_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_dont_propagate_list_sizeof", ExactSpelling = true)]
    public static extern int change_device_dont_propagate_list_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_dont_propagate_list_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_device_dont_propagate_list_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_dont_propagate_list", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_device_dont_propagate_list(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_dont_propagate_list_classes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_input_event_class_t *")]
    public static extern uint* change_device_dont_propagate_list_classes([NativeTypeName("const xcb_input_change_device_dont_propagate_list_request_t *")] xcb_input_change_device_dont_propagate_list_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_dont_propagate_list_classes_length", ExactSpelling = true)]
    public static extern int change_device_dont_propagate_list_classes_length([NativeTypeName("const xcb_input_change_device_dont_propagate_list_request_t *")] xcb_input_change_device_dont_propagate_list_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_dont_propagate_list_classes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t change_device_dont_propagate_list_classes_end([NativeTypeName("const xcb_input_change_device_dont_propagate_list_request_t *")] xcb_input_change_device_dont_propagate_list_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_dont_propagate_list_sizeof", ExactSpelling = true)]
    public static extern int get_device_dont_propagate_list_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_dont_propagate_list", ExactSpelling = true)]
    public static extern xcb_input_get_device_dont_propagate_list_cookie_t get_device_dont_propagate_list(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_dont_propagate_list_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_device_dont_propagate_list_cookie_t get_device_dont_propagate_list_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_dont_propagate_list_classes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_input_event_class_t *")]
    public static extern uint* get_device_dont_propagate_list_classes([NativeTypeName("const xcb_input_get_device_dont_propagate_list_reply_t *")] xcb_input_get_device_dont_propagate_list_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_dont_propagate_list_classes_length", ExactSpelling = true)]
    public static extern int get_device_dont_propagate_list_classes_length([NativeTypeName("const xcb_input_get_device_dont_propagate_list_reply_t *")] xcb_input_get_device_dont_propagate_list_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_dont_propagate_list_classes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_device_dont_propagate_list_classes_end([NativeTypeName("const xcb_input_get_device_dont_propagate_list_reply_t *")] xcb_input_get_device_dont_propagate_list_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_dont_propagate_list_reply", ExactSpelling = true)]
    public static extern xcb_input_get_device_dont_propagate_list_reply_t* get_device_dont_propagate_list_reply(xcb_connection_t* c, xcb_input_get_device_dont_propagate_list_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_time_coord_sizeof", ExactSpelling = true)]
    public static extern int device_time_coord_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte num_axes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_time_coord_axisvalues", ExactSpelling = true)]
    [return: NativeTypeName("int32_t *")]
    public static extern int* device_time_coord_axisvalues([NativeTypeName("const xcb_input_device_time_coord_t *")] xcb_input_device_time_coord_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_time_coord_axisvalues_length", ExactSpelling = true)]
    public static extern int device_time_coord_axisvalues_length([NativeTypeName("const xcb_input_device_time_coord_t *")] xcb_input_device_time_coord_t* R, [NativeTypeName("uint8_t")] byte num_axes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_time_coord_axisvalues_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_time_coord_axisvalues_end([NativeTypeName("const xcb_input_device_time_coord_t *")] xcb_input_device_time_coord_t* R, [NativeTypeName("uint8_t")] byte num_axes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_time_coord_next", ExactSpelling = true)]
    public static extern void device_time_coord_next(xcb_input_device_time_coord_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_time_coord_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_time_coord_end(xcb_input_device_time_coord_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_motion_events_sizeof", ExactSpelling = true)]
    public static extern int get_device_motion_events_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_motion_events", ExactSpelling = true)]
    public static extern xcb_input_get_device_motion_events_cookie_t get_device_motion_events(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint start, [NativeTypeName("xcb_timestamp_t")] uint stop, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_motion_events_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_device_motion_events_cookie_t get_device_motion_events_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint start, [NativeTypeName("xcb_timestamp_t")] uint stop, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_motion_events_events_length", ExactSpelling = true)]
    public static extern int get_device_motion_events_events_length([NativeTypeName("const xcb_input_get_device_motion_events_reply_t *")] xcb_input_get_device_motion_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_motion_events_events_iterator", ExactSpelling = true)]
    public static extern xcb_input_device_time_coord_iterator_t get_device_motion_events_events_iterator([NativeTypeName("const xcb_input_get_device_motion_events_reply_t *")] xcb_input_get_device_motion_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_motion_events_reply", ExactSpelling = true)]
    public static extern xcb_input_get_device_motion_events_reply_t* get_device_motion_events_reply(xcb_connection_t* c, xcb_input_get_device_motion_events_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_keyboard_device", ExactSpelling = true)]
    public static extern xcb_input_change_keyboard_device_cookie_t change_keyboard_device(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_keyboard_device_unchecked", ExactSpelling = true)]
    public static extern xcb_input_change_keyboard_device_cookie_t change_keyboard_device_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_keyboard_device_reply", ExactSpelling = true)]
    public static extern xcb_input_change_keyboard_device_reply_t* change_keyboard_device_reply(xcb_connection_t* c, xcb_input_change_keyboard_device_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_pointer_device", ExactSpelling = true)]
    public static extern xcb_input_change_pointer_device_cookie_t change_pointer_device(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte x_axis, [NativeTypeName("uint8_t")] byte y_axis, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_pointer_device_unchecked", ExactSpelling = true)]
    public static extern xcb_input_change_pointer_device_cookie_t change_pointer_device_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte x_axis, [NativeTypeName("uint8_t")] byte y_axis, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_pointer_device_reply", ExactSpelling = true)]
    public static extern xcb_input_change_pointer_device_reply_t* change_pointer_device_reply(xcb_connection_t* c, xcb_input_change_pointer_device_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_sizeof", ExactSpelling = true)]
    public static extern int grab_device_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device", ExactSpelling = true)]
    public static extern xcb_input_grab_device_cookie_t grab_device(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint8_t")] byte this_device_mode, [NativeTypeName("uint8_t")] byte other_device_mode, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_unchecked", ExactSpelling = true)]
    public static extern xcb_input_grab_device_cookie_t grab_device_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint8_t")] byte this_device_mode, [NativeTypeName("uint8_t")] byte other_device_mode, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_reply", ExactSpelling = true)]
    public static extern xcb_input_grab_device_reply_t* grab_device_reply(xcb_connection_t* c, xcb_input_grab_device_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ungrab_device_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t ungrab_device_checked(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ungrab_device", ExactSpelling = true)]
    public static extern xcb_void_cookie_t ungrab_device(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_key_sizeof", ExactSpelling = true)]
    public static extern int grab_device_key_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_key_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t grab_device_key_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("uint8_t")] byte modifier_device, [NativeTypeName("uint8_t")] byte grabbed_device, [NativeTypeName("uint8_t")] byte key, [NativeTypeName("uint8_t")] byte this_device_mode, [NativeTypeName("uint8_t")] byte other_device_mode, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_key", ExactSpelling = true)]
    public static extern xcb_void_cookie_t grab_device_key(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("uint8_t")] byte modifier_device, [NativeTypeName("uint8_t")] byte grabbed_device, [NativeTypeName("uint8_t")] byte key, [NativeTypeName("uint8_t")] byte this_device_mode, [NativeTypeName("uint8_t")] byte other_device_mode, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_key_classes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_input_event_class_t *")]
    public static extern uint* grab_device_key_classes([NativeTypeName("const xcb_input_grab_device_key_request_t *")] xcb_input_grab_device_key_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_key_classes_length", ExactSpelling = true)]
    public static extern int grab_device_key_classes_length([NativeTypeName("const xcb_input_grab_device_key_request_t *")] xcb_input_grab_device_key_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_key_classes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t grab_device_key_classes_end([NativeTypeName("const xcb_input_grab_device_key_request_t *")] xcb_input_grab_device_key_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ungrab_device_key_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t ungrab_device_key_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grabWindow, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("uint8_t")] byte modifier_device, [NativeTypeName("uint8_t")] byte key, [NativeTypeName("uint8_t")] byte grabbed_device);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ungrab_device_key", ExactSpelling = true)]
    public static extern xcb_void_cookie_t ungrab_device_key(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grabWindow, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("uint8_t")] byte modifier_device, [NativeTypeName("uint8_t")] byte key, [NativeTypeName("uint8_t")] byte grabbed_device);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_button_sizeof", ExactSpelling = true)]
    public static extern int grab_device_button_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_button_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t grab_device_button_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint8_t")] byte grabbed_device, [NativeTypeName("uint8_t")] byte modifier_device, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("uint8_t")] byte this_device_mode, [NativeTypeName("uint8_t")] byte other_device_mode, [NativeTypeName("uint8_t")] byte button, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_button", ExactSpelling = true)]
    public static extern xcb_void_cookie_t grab_device_button(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint8_t")] byte grabbed_device, [NativeTypeName("uint8_t")] byte modifier_device, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("uint8_t")] byte this_device_mode, [NativeTypeName("uint8_t")] byte other_device_mode, [NativeTypeName("uint8_t")] byte button, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_button_classes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_input_event_class_t *")]
    public static extern uint* grab_device_button_classes([NativeTypeName("const xcb_input_grab_device_button_request_t *")] xcb_input_grab_device_button_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_button_classes_length", ExactSpelling = true)]
    public static extern int grab_device_button_classes_length([NativeTypeName("const xcb_input_grab_device_button_request_t *")] xcb_input_grab_device_button_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_device_button_classes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t grab_device_button_classes_end([NativeTypeName("const xcb_input_grab_device_button_request_t *")] xcb_input_grab_device_button_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ungrab_device_button_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t ungrab_device_button_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("uint8_t")] byte modifier_device, [NativeTypeName("uint8_t")] byte button, [NativeTypeName("uint8_t")] byte grabbed_device);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ungrab_device_button", ExactSpelling = true)]
    public static extern xcb_void_cookie_t ungrab_device_button(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("uint8_t")] byte modifier_device, [NativeTypeName("uint8_t")] byte button, [NativeTypeName("uint8_t")] byte grabbed_device);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_allow_device_events_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t allow_device_events_checked(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_allow_device_events", ExactSpelling = true)]
    public static extern xcb_void_cookie_t allow_device_events(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_focus", ExactSpelling = true)]
    public static extern xcb_input_get_device_focus_cookie_t get_device_focus(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_focus_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_device_focus_cookie_t get_device_focus_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_focus_reply", ExactSpelling = true)]
    public static extern xcb_input_get_device_focus_reply_t* get_device_focus_reply(xcb_connection_t* c, xcb_input_get_device_focus_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_focus_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_device_focus_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint focus, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint8_t")] byte revert_to, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_focus", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_device_focus(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint focus, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint8_t")] byte revert_to, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_kbd_feedback_state_next", ExactSpelling = true)]
    public static extern void kbd_feedback_state_next(xcb_input_kbd_feedback_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_kbd_feedback_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t kbd_feedback_state_end(xcb_input_kbd_feedback_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ptr_feedback_state_next", ExactSpelling = true)]
    public static extern void ptr_feedback_state_next(xcb_input_ptr_feedback_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ptr_feedback_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t ptr_feedback_state_end(xcb_input_ptr_feedback_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_integer_feedback_state_next", ExactSpelling = true)]
    public static extern void integer_feedback_state_next(xcb_input_integer_feedback_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_integer_feedback_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t integer_feedback_state_end(xcb_input_integer_feedback_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_state_sizeof", ExactSpelling = true)]
    public static extern int string_feedback_state_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_state_keysyms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_keysym_t *")]
    public static extern uint* string_feedback_state_keysyms([NativeTypeName("const xcb_input_string_feedback_state_t *")] xcb_input_string_feedback_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_state_keysyms_length", ExactSpelling = true)]
    public static extern int string_feedback_state_keysyms_length([NativeTypeName("const xcb_input_string_feedback_state_t *")] xcb_input_string_feedback_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_state_keysyms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t string_feedback_state_keysyms_end([NativeTypeName("const xcb_input_string_feedback_state_t *")] xcb_input_string_feedback_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_state_next", ExactSpelling = true)]
    public static extern void string_feedback_state_next(xcb_input_string_feedback_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t string_feedback_state_end(xcb_input_string_feedback_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_bell_feedback_state_next", ExactSpelling = true)]
    public static extern void bell_feedback_state_next(xcb_input_bell_feedback_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_bell_feedback_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t bell_feedback_state_end(xcb_input_bell_feedback_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_led_feedback_state_next", ExactSpelling = true)]
    public static extern void led_feedback_state_next(xcb_input_led_feedback_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_led_feedback_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t led_feedback_state_end(xcb_input_led_feedback_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_data_string_keysyms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_keysym_t *")]
    public static extern uint* feedback_state_data_string_keysyms([NativeTypeName("const xcb_input_feedback_state_data_t *")] xcb_input_feedback_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_data_string_keysyms_length", ExactSpelling = true)]
    public static extern int feedback_state_data_string_keysyms_length([NativeTypeName("const xcb_input_feedback_state_t *")] xcb_input_feedback_state_t* R, [NativeTypeName("const xcb_input_feedback_state_data_t *")] xcb_input_feedback_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_data_string_keysyms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t feedback_state_data_string_keysyms_end([NativeTypeName("const xcb_input_feedback_state_t *")] xcb_input_feedback_state_t* R, [NativeTypeName("const xcb_input_feedback_state_data_t *")] xcb_input_feedback_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_data_serialize", ExactSpelling = true)]
    public static extern int feedback_state_data_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte class_id, [NativeTypeName("const xcb_input_feedback_state_data_t *")] xcb_input_feedback_state_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_data_unpack", ExactSpelling = true)]
    public static extern int feedback_state_data_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte class_id, xcb_input_feedback_state_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_data_sizeof", ExactSpelling = true)]
    public static extern int feedback_state_data_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte class_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_sizeof", ExactSpelling = true)]
    public static extern int feedback_state_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_next", ExactSpelling = true)]
    public static extern void feedback_state_next(xcb_input_feedback_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t feedback_state_end(xcb_input_feedback_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_feedback_control_sizeof", ExactSpelling = true)]
    public static extern int get_feedback_control_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_feedback_control", ExactSpelling = true)]
    public static extern xcb_input_get_feedback_control_cookie_t get_feedback_control(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_feedback_control_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_feedback_control_cookie_t get_feedback_control_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_feedback_control_feedbacks_length", ExactSpelling = true)]
    public static extern int get_feedback_control_feedbacks_length([NativeTypeName("const xcb_input_get_feedback_control_reply_t *")] xcb_input_get_feedback_control_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_feedback_control_feedbacks_iterator", ExactSpelling = true)]
    public static extern xcb_input_feedback_state_iterator_t get_feedback_control_feedbacks_iterator([NativeTypeName("const xcb_input_get_feedback_control_reply_t *")] xcb_input_get_feedback_control_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_feedback_control_reply", ExactSpelling = true)]
    public static extern xcb_input_get_feedback_control_reply_t* get_feedback_control_reply(xcb_connection_t* c, xcb_input_get_feedback_control_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_kbd_feedback_ctl_next", ExactSpelling = true)]
    public static extern void kbd_feedback_ctl_next(xcb_input_kbd_feedback_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_kbd_feedback_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t kbd_feedback_ctl_end(xcb_input_kbd_feedback_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ptr_feedback_ctl_next", ExactSpelling = true)]
    public static extern void ptr_feedback_ctl_next(xcb_input_ptr_feedback_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_ptr_feedback_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t ptr_feedback_ctl_end(xcb_input_ptr_feedback_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_integer_feedback_ctl_next", ExactSpelling = true)]
    public static extern void integer_feedback_ctl_next(xcb_input_integer_feedback_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_integer_feedback_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t integer_feedback_ctl_end(xcb_input_integer_feedback_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_ctl_sizeof", ExactSpelling = true)]
    public static extern int string_feedback_ctl_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_ctl_keysyms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_keysym_t *")]
    public static extern uint* string_feedback_ctl_keysyms([NativeTypeName("const xcb_input_string_feedback_ctl_t *")] xcb_input_string_feedback_ctl_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_ctl_keysyms_length", ExactSpelling = true)]
    public static extern int string_feedback_ctl_keysyms_length([NativeTypeName("const xcb_input_string_feedback_ctl_t *")] xcb_input_string_feedback_ctl_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_ctl_keysyms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t string_feedback_ctl_keysyms_end([NativeTypeName("const xcb_input_string_feedback_ctl_t *")] xcb_input_string_feedback_ctl_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_ctl_next", ExactSpelling = true)]
    public static extern void string_feedback_ctl_next(xcb_input_string_feedback_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_string_feedback_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t string_feedback_ctl_end(xcb_input_string_feedback_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_bell_feedback_ctl_next", ExactSpelling = true)]
    public static extern void bell_feedback_ctl_next(xcb_input_bell_feedback_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_bell_feedback_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t bell_feedback_ctl_end(xcb_input_bell_feedback_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_led_feedback_ctl_next", ExactSpelling = true)]
    public static extern void led_feedback_ctl_next(xcb_input_led_feedback_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_led_feedback_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t led_feedback_ctl_end(xcb_input_led_feedback_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_data_string_keysyms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_keysym_t *")]
    public static extern uint* feedback_ctl_data_string_keysyms([NativeTypeName("const xcb_input_feedback_ctl_data_t *")] xcb_input_feedback_ctl_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_data_string_keysyms_length", ExactSpelling = true)]
    public static extern int feedback_ctl_data_string_keysyms_length([NativeTypeName("const xcb_input_feedback_ctl_t *")] xcb_input_feedback_ctl_t* R, [NativeTypeName("const xcb_input_feedback_ctl_data_t *")] xcb_input_feedback_ctl_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_data_string_keysyms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t feedback_ctl_data_string_keysyms_end([NativeTypeName("const xcb_input_feedback_ctl_t *")] xcb_input_feedback_ctl_t* R, [NativeTypeName("const xcb_input_feedback_ctl_data_t *")] xcb_input_feedback_ctl_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_data_serialize", ExactSpelling = true)]
    public static extern int feedback_ctl_data_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte class_id, [NativeTypeName("const xcb_input_feedback_ctl_data_t *")] xcb_input_feedback_ctl_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_data_unpack", ExactSpelling = true)]
    public static extern int feedback_ctl_data_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte class_id, xcb_input_feedback_ctl_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_data_sizeof", ExactSpelling = true)]
    public static extern int feedback_ctl_data_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte class_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_sizeof", ExactSpelling = true)]
    public static extern int feedback_ctl_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_next", ExactSpelling = true)]
    public static extern void feedback_ctl_next(xcb_input_feedback_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_feedback_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t feedback_ctl_end(xcb_input_feedback_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_feedback_control_sizeof", ExactSpelling = true)]
    public static extern int change_feedback_control_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_feedback_control_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_feedback_control_checked(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint mask, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte feedback_id, xcb_input_feedback_ctl_t* feedback);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_feedback_control", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_feedback_control(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint mask, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte feedback_id, xcb_input_feedback_ctl_t* feedback);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_feedback_control_feedback", ExactSpelling = true)]
    public static extern xcb_input_feedback_ctl_t* change_feedback_control_feedback([NativeTypeName("const xcb_input_change_feedback_control_request_t *")] xcb_input_change_feedback_control_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_key_mapping_sizeof", ExactSpelling = true)]
    public static extern int get_device_key_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_key_mapping", ExactSpelling = true)]
    public static extern xcb_input_get_device_key_mapping_cookie_t get_device_key_mapping(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("xcb_input_key_code_t")] byte first_keycode, [NativeTypeName("uint8_t")] byte count);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_key_mapping_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_device_key_mapping_cookie_t get_device_key_mapping_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("xcb_input_key_code_t")] byte first_keycode, [NativeTypeName("uint8_t")] byte count);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_key_mapping_keysyms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_keysym_t *")]
    public static extern uint* get_device_key_mapping_keysyms([NativeTypeName("const xcb_input_get_device_key_mapping_reply_t *")] xcb_input_get_device_key_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_key_mapping_keysyms_length", ExactSpelling = true)]
    public static extern int get_device_key_mapping_keysyms_length([NativeTypeName("const xcb_input_get_device_key_mapping_reply_t *")] xcb_input_get_device_key_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_key_mapping_keysyms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_device_key_mapping_keysyms_end([NativeTypeName("const xcb_input_get_device_key_mapping_reply_t *")] xcb_input_get_device_key_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_key_mapping_reply", ExactSpelling = true)]
    public static extern xcb_input_get_device_key_mapping_reply_t* get_device_key_mapping_reply(xcb_connection_t* c, xcb_input_get_device_key_mapping_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_key_mapping_sizeof", ExactSpelling = true)]
    public static extern int change_device_key_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_key_mapping_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_device_key_mapping_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("xcb_input_key_code_t")] byte first_keycode, [NativeTypeName("uint8_t")] byte keysyms_per_keycode, [NativeTypeName("uint8_t")] byte keycode_count, [NativeTypeName("const xcb_keysym_t *")] uint* keysyms);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_key_mapping", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_device_key_mapping(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("xcb_input_key_code_t")] byte first_keycode, [NativeTypeName("uint8_t")] byte keysyms_per_keycode, [NativeTypeName("uint8_t")] byte keycode_count, [NativeTypeName("const xcb_keysym_t *")] uint* keysyms);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_key_mapping_keysyms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_keysym_t *")]
    public static extern uint* change_device_key_mapping_keysyms([NativeTypeName("const xcb_input_change_device_key_mapping_request_t *")] xcb_input_change_device_key_mapping_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_key_mapping_keysyms_length", ExactSpelling = true)]
    public static extern int change_device_key_mapping_keysyms_length([NativeTypeName("const xcb_input_change_device_key_mapping_request_t *")] xcb_input_change_device_key_mapping_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_key_mapping_keysyms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t change_device_key_mapping_keysyms_end([NativeTypeName("const xcb_input_change_device_key_mapping_request_t *")] xcb_input_change_device_key_mapping_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_modifier_mapping_sizeof", ExactSpelling = true)]
    public static extern int get_device_modifier_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_modifier_mapping", ExactSpelling = true)]
    public static extern xcb_input_get_device_modifier_mapping_cookie_t get_device_modifier_mapping(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_modifier_mapping_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_device_modifier_mapping_cookie_t get_device_modifier_mapping_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_modifier_mapping_keymaps", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_device_modifier_mapping_keymaps([NativeTypeName("const xcb_input_get_device_modifier_mapping_reply_t *")] xcb_input_get_device_modifier_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_modifier_mapping_keymaps_length", ExactSpelling = true)]
    public static extern int get_device_modifier_mapping_keymaps_length([NativeTypeName("const xcb_input_get_device_modifier_mapping_reply_t *")] xcb_input_get_device_modifier_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_modifier_mapping_keymaps_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_device_modifier_mapping_keymaps_end([NativeTypeName("const xcb_input_get_device_modifier_mapping_reply_t *")] xcb_input_get_device_modifier_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_modifier_mapping_reply", ExactSpelling = true)]
    public static extern xcb_input_get_device_modifier_mapping_reply_t* get_device_modifier_mapping_reply(xcb_connection_t* c, xcb_input_get_device_modifier_mapping_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_modifier_mapping_sizeof", ExactSpelling = true)]
    public static extern int set_device_modifier_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_modifier_mapping", ExactSpelling = true)]
    public static extern xcb_input_set_device_modifier_mapping_cookie_t set_device_modifier_mapping(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte keycodes_per_modifier, [NativeTypeName("const uint8_t *")] byte* keymaps);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_modifier_mapping_unchecked", ExactSpelling = true)]
    public static extern xcb_input_set_device_modifier_mapping_cookie_t set_device_modifier_mapping_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte keycodes_per_modifier, [NativeTypeName("const uint8_t *")] byte* keymaps);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_modifier_mapping_reply", ExactSpelling = true)]
    public static extern xcb_input_set_device_modifier_mapping_reply_t* set_device_modifier_mapping_reply(xcb_connection_t* c, xcb_input_set_device_modifier_mapping_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_button_mapping_sizeof", ExactSpelling = true)]
    public static extern int get_device_button_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_button_mapping", ExactSpelling = true)]
    public static extern xcb_input_get_device_button_mapping_cookie_t get_device_button_mapping(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_button_mapping_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_device_button_mapping_cookie_t get_device_button_mapping_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_button_mapping_map", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_device_button_mapping_map([NativeTypeName("const xcb_input_get_device_button_mapping_reply_t *")] xcb_input_get_device_button_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_button_mapping_map_length", ExactSpelling = true)]
    public static extern int get_device_button_mapping_map_length([NativeTypeName("const xcb_input_get_device_button_mapping_reply_t *")] xcb_input_get_device_button_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_button_mapping_map_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_device_button_mapping_map_end([NativeTypeName("const xcb_input_get_device_button_mapping_reply_t *")] xcb_input_get_device_button_mapping_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_button_mapping_reply", ExactSpelling = true)]
    public static extern xcb_input_get_device_button_mapping_reply_t* get_device_button_mapping_reply(xcb_connection_t* c, xcb_input_get_device_button_mapping_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_button_mapping_sizeof", ExactSpelling = true)]
    public static extern int set_device_button_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_button_mapping", ExactSpelling = true)]
    public static extern xcb_input_set_device_button_mapping_cookie_t set_device_button_mapping(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte map_size, [NativeTypeName("const uint8_t *")] byte* map);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_button_mapping_unchecked", ExactSpelling = true)]
    public static extern xcb_input_set_device_button_mapping_cookie_t set_device_button_mapping_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte map_size, [NativeTypeName("const uint8_t *")] byte* map);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_button_mapping_reply", ExactSpelling = true)]
    public static extern xcb_input_set_device_button_mapping_reply_t* set_device_button_mapping_reply(xcb_connection_t* c, xcb_input_set_device_button_mapping_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_state_next", ExactSpelling = true)]
    public static extern void key_state_next(xcb_input_key_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_state_end(xcb_input_key_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_state_next", ExactSpelling = true)]
    public static extern void button_state_next(xcb_input_button_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t button_state_end(xcb_input_button_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_state_sizeof", ExactSpelling = true)]
    public static extern int valuator_state_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_state_valuators", ExactSpelling = true)]
    [return: NativeTypeName("int32_t *")]
    public static extern int* valuator_state_valuators([NativeTypeName("const xcb_input_valuator_state_t *")] xcb_input_valuator_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_state_valuators_length", ExactSpelling = true)]
    public static extern int valuator_state_valuators_length([NativeTypeName("const xcb_input_valuator_state_t *")] xcb_input_valuator_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_state_valuators_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t valuator_state_valuators_end([NativeTypeName("const xcb_input_valuator_state_t *")] xcb_input_valuator_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_state_next", ExactSpelling = true)]
    public static extern void valuator_state_next(xcb_input_valuator_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t valuator_state_end(xcb_input_valuator_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_data_valuator_valuators", ExactSpelling = true)]
    [return: NativeTypeName("int32_t *")]
    public static extern int* input_state_data_valuator_valuators([NativeTypeName("const xcb_input_input_state_data_t *")] xcb_input_input_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_data_valuator_valuators_length", ExactSpelling = true)]
    public static extern int input_state_data_valuator_valuators_length([NativeTypeName("const xcb_input_input_state_t *")] xcb_input_input_state_t* R, [NativeTypeName("const xcb_input_input_state_data_t *")] xcb_input_input_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_data_valuator_valuators_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t input_state_data_valuator_valuators_end([NativeTypeName("const xcb_input_input_state_t *")] xcb_input_input_state_t* R, [NativeTypeName("const xcb_input_input_state_data_t *")] xcb_input_input_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_data_serialize", ExactSpelling = true)]
    public static extern int input_state_data_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte class_id, [NativeTypeName("const xcb_input_input_state_data_t *")] xcb_input_input_state_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_data_unpack", ExactSpelling = true)]
    public static extern int input_state_data_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte class_id, xcb_input_input_state_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_data_sizeof", ExactSpelling = true)]
    public static extern int input_state_data_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte class_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_sizeof", ExactSpelling = true)]
    public static extern int input_state_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_next", ExactSpelling = true)]
    public static extern void input_state_next(xcb_input_input_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_input_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t input_state_end(xcb_input_input_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_query_device_state_sizeof", ExactSpelling = true)]
    public static extern int query_device_state_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_query_device_state", ExactSpelling = true)]
    public static extern xcb_input_query_device_state_cookie_t query_device_state(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_query_device_state_unchecked", ExactSpelling = true)]
    public static extern xcb_input_query_device_state_cookie_t query_device_state_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_query_device_state_classes_length", ExactSpelling = true)]
    public static extern int query_device_state_classes_length([NativeTypeName("const xcb_input_query_device_state_reply_t *")] xcb_input_query_device_state_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_query_device_state_classes_iterator", ExactSpelling = true)]
    public static extern xcb_input_input_state_iterator_t query_device_state_classes_iterator([NativeTypeName("const xcb_input_query_device_state_reply_t *")] xcb_input_query_device_state_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_query_device_state_reply", ExactSpelling = true)]
    public static extern xcb_input_query_device_state_reply_t* query_device_state_reply(xcb_connection_t* c, xcb_input_query_device_state_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_bell_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t device_bell_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte feedback_id, [NativeTypeName("uint8_t")] byte feedback_class, [NativeTypeName("int8_t")] sbyte percent);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_bell", ExactSpelling = true)]
    public static extern xcb_void_cookie_t device_bell(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte feedback_id, [NativeTypeName("uint8_t")] byte feedback_class, [NativeTypeName("int8_t")] sbyte percent);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_valuators_sizeof", ExactSpelling = true)]
    public static extern int set_device_valuators_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_valuators", ExactSpelling = true)]
    public static extern xcb_input_set_device_valuators_cookie_t set_device_valuators(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte first_valuator, [NativeTypeName("uint8_t")] byte num_valuators, [NativeTypeName("const int32_t *")] int* valuators);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_valuators_unchecked", ExactSpelling = true)]
    public static extern xcb_input_set_device_valuators_cookie_t set_device_valuators_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte first_valuator, [NativeTypeName("uint8_t")] byte num_valuators, [NativeTypeName("const int32_t *")] int* valuators);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_set_device_valuators_reply", ExactSpelling = true)]
    public static extern xcb_input_set_device_valuators_reply_t* set_device_valuators_reply(xcb_connection_t* c, xcb_input_set_device_valuators_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_sizeof", ExactSpelling = true)]
    public static extern int device_resolution_state_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_values", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_resolution_state_resolution_values([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_values_length", ExactSpelling = true)]
    public static extern int device_resolution_state_resolution_values_length([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_resolution_state_resolution_values_end([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_min", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_resolution_state_resolution_min([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_min_length", ExactSpelling = true)]
    public static extern int device_resolution_state_resolution_min_length([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_min_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_resolution_state_resolution_min_end([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_max", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_resolution_state_resolution_max([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_max_length", ExactSpelling = true)]
    public static extern int device_resolution_state_resolution_max_length([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_resolution_max_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_resolution_state_resolution_max_end([NativeTypeName("const xcb_input_device_resolution_state_t *")] xcb_input_device_resolution_state_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_next", ExactSpelling = true)]
    public static extern void device_resolution_state_next(xcb_input_device_resolution_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_resolution_state_end(xcb_input_device_resolution_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_abs_calib_state_next", ExactSpelling = true)]
    public static extern void device_abs_calib_state_next(xcb_input_device_abs_calib_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_abs_calib_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_abs_calib_state_end(xcb_input_device_abs_calib_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_abs_area_state_next", ExactSpelling = true)]
    public static extern void device_abs_area_state_next(xcb_input_device_abs_area_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_abs_area_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_abs_area_state_end(xcb_input_device_abs_area_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_core_state_next", ExactSpelling = true)]
    public static extern void device_core_state_next(xcb_input_device_core_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_core_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_core_state_end(xcb_input_device_core_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_enable_state_next", ExactSpelling = true)]
    public static extern void device_enable_state_next(xcb_input_device_enable_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_enable_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_enable_state_end(xcb_input_device_enable_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_values", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_state_data_resolution_resolution_values([NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_values_length", ExactSpelling = true)]
    public static extern int device_state_data_resolution_resolution_values_length([NativeTypeName("const xcb_input_device_state_t *")] xcb_input_device_state_t* R, [NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_state_data_resolution_resolution_values_end([NativeTypeName("const xcb_input_device_state_t *")] xcb_input_device_state_t* R, [NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_min", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_state_data_resolution_resolution_min([NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_min_length", ExactSpelling = true)]
    public static extern int device_state_data_resolution_resolution_min_length([NativeTypeName("const xcb_input_device_state_t *")] xcb_input_device_state_t* R, [NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_min_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_state_data_resolution_resolution_min_end([NativeTypeName("const xcb_input_device_state_t *")] xcb_input_device_state_t* R, [NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_max", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_state_data_resolution_resolution_max([NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_max_length", ExactSpelling = true)]
    public static extern int device_state_data_resolution_resolution_max_length([NativeTypeName("const xcb_input_device_state_t *")] xcb_input_device_state_t* R, [NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_resolution_resolution_max_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_state_data_resolution_resolution_max_end([NativeTypeName("const xcb_input_device_state_t *")] xcb_input_device_state_t* R, [NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_serialize", ExactSpelling = true)]
    public static extern int device_state_data_serialize(void** _buffer, [NativeTypeName("uint16_t")] ushort control_id, [NativeTypeName("const xcb_input_device_state_data_t *")] xcb_input_device_state_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_unpack", ExactSpelling = true)]
    public static extern int device_state_data_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort control_id, xcb_input_device_state_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_data_sizeof", ExactSpelling = true)]
    public static extern int device_state_data_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort control_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_sizeof", ExactSpelling = true)]
    public static extern int device_state_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_next", ExactSpelling = true)]
    public static extern void device_state_next(xcb_input_device_state_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_state_end(xcb_input_device_state_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_control_sizeof", ExactSpelling = true)]
    public static extern int get_device_control_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_control", ExactSpelling = true)]
    public static extern xcb_input_get_device_control_cookie_t get_device_control(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort control_id, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_control_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_device_control_cookie_t get_device_control_unchecked(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort control_id, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_control_control", ExactSpelling = true)]
    public static extern xcb_input_device_state_t* get_device_control_control([NativeTypeName("const xcb_input_get_device_control_reply_t *")] xcb_input_get_device_control_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_control_reply", ExactSpelling = true)]
    public static extern xcb_input_get_device_control_reply_t* get_device_control_reply(xcb_connection_t* c, xcb_input_get_device_control_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_ctl_sizeof", ExactSpelling = true)]
    public static extern int device_resolution_ctl_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_ctl_resolution_values", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_resolution_ctl_resolution_values([NativeTypeName("const xcb_input_device_resolution_ctl_t *")] xcb_input_device_resolution_ctl_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_ctl_resolution_values_length", ExactSpelling = true)]
    public static extern int device_resolution_ctl_resolution_values_length([NativeTypeName("const xcb_input_device_resolution_ctl_t *")] xcb_input_device_resolution_ctl_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_ctl_resolution_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_resolution_ctl_resolution_values_end([NativeTypeName("const xcb_input_device_resolution_ctl_t *")] xcb_input_device_resolution_ctl_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_ctl_next", ExactSpelling = true)]
    public static extern void device_resolution_ctl_next(xcb_input_device_resolution_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_resolution_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_resolution_ctl_end(xcb_input_device_resolution_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_abs_calib_ctl_next", ExactSpelling = true)]
    public static extern void device_abs_calib_ctl_next(xcb_input_device_abs_calib_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_abs_calib_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_abs_calib_ctl_end(xcb_input_device_abs_calib_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_abs_area_ctrl_next", ExactSpelling = true)]
    public static extern void device_abs_area_ctrl_next(xcb_input_device_abs_area_ctrl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_abs_area_ctrl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_abs_area_ctrl_end(xcb_input_device_abs_area_ctrl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_core_ctrl_next", ExactSpelling = true)]
    public static extern void device_core_ctrl_next(xcb_input_device_core_ctrl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_core_ctrl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_core_ctrl_end(xcb_input_device_core_ctrl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_enable_ctrl_next", ExactSpelling = true)]
    public static extern void device_enable_ctrl_next(xcb_input_device_enable_ctrl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_enable_ctrl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_enable_ctrl_end(xcb_input_device_enable_ctrl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_data_resolution_resolution_values", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_ctl_data_resolution_resolution_values([NativeTypeName("const xcb_input_device_ctl_data_t *")] xcb_input_device_ctl_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_data_resolution_resolution_values_length", ExactSpelling = true)]
    public static extern int device_ctl_data_resolution_resolution_values_length([NativeTypeName("const xcb_input_device_ctl_t *")] xcb_input_device_ctl_t* R, [NativeTypeName("const xcb_input_device_ctl_data_t *")] xcb_input_device_ctl_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_data_resolution_resolution_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_ctl_data_resolution_resolution_values_end([NativeTypeName("const xcb_input_device_ctl_t *")] xcb_input_device_ctl_t* R, [NativeTypeName("const xcb_input_device_ctl_data_t *")] xcb_input_device_ctl_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_data_serialize", ExactSpelling = true)]
    public static extern int device_ctl_data_serialize(void** _buffer, [NativeTypeName("uint16_t")] ushort control_id, [NativeTypeName("const xcb_input_device_ctl_data_t *")] xcb_input_device_ctl_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_data_unpack", ExactSpelling = true)]
    public static extern int device_ctl_data_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort control_id, xcb_input_device_ctl_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_data_sizeof", ExactSpelling = true)]
    public static extern int device_ctl_data_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort control_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_sizeof", ExactSpelling = true)]
    public static extern int device_ctl_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_next", ExactSpelling = true)]
    public static extern void device_ctl_next(xcb_input_device_ctl_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_ctl_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_ctl_end(xcb_input_device_ctl_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_control_sizeof", ExactSpelling = true)]
    public static extern int change_device_control_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_control", ExactSpelling = true)]
    public static extern xcb_input_change_device_control_cookie_t change_device_control(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort control_id, [NativeTypeName("uint8_t")] byte device_id, xcb_input_device_ctl_t* control);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_control_unchecked", ExactSpelling = true)]
    public static extern xcb_input_change_device_control_cookie_t change_device_control_unchecked(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort control_id, [NativeTypeName("uint8_t")] byte device_id, xcb_input_device_ctl_t* control);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_control_reply", ExactSpelling = true)]
    public static extern xcb_input_change_device_control_reply_t* change_device_control_reply(xcb_connection_t* c, xcb_input_change_device_control_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_device_properties_sizeof", ExactSpelling = true)]
    public static extern int list_device_properties_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_device_properties", ExactSpelling = true)]
    public static extern xcb_input_list_device_properties_cookie_t list_device_properties(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_device_properties_unchecked", ExactSpelling = true)]
    public static extern xcb_input_list_device_properties_cookie_t list_device_properties_unchecked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_device_properties_atoms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* list_device_properties_atoms([NativeTypeName("const xcb_input_list_device_properties_reply_t *")] xcb_input_list_device_properties_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_device_properties_atoms_length", ExactSpelling = true)]
    public static extern int list_device_properties_atoms_length([NativeTypeName("const xcb_input_list_device_properties_reply_t *")] xcb_input_list_device_properties_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_device_properties_atoms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t list_device_properties_atoms_end([NativeTypeName("const xcb_input_list_device_properties_reply_t *")] xcb_input_list_device_properties_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_list_device_properties_reply", ExactSpelling = true)]
    public static extern xcb_input_list_device_properties_reply_t* list_device_properties_reply(xcb_connection_t* c, xcb_input_list_device_properties_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_8", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* change_device_property_items_data_8([NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_8_length", ExactSpelling = true)]
    public static extern int change_device_property_items_data_8_length([NativeTypeName("const xcb_input_change_device_property_request_t *")] xcb_input_change_device_property_request_t* R, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_8_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t change_device_property_items_data_8_end([NativeTypeName("const xcb_input_change_device_property_request_t *")] xcb_input_change_device_property_request_t* R, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_16", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* change_device_property_items_data_16([NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_16_length", ExactSpelling = true)]
    public static extern int change_device_property_items_data_16_length([NativeTypeName("const xcb_input_change_device_property_request_t *")] xcb_input_change_device_property_request_t* R, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_16_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t change_device_property_items_data_16_end([NativeTypeName("const xcb_input_change_device_property_request_t *")] xcb_input_change_device_property_request_t* R, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_32", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* change_device_property_items_data_32([NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_32_length", ExactSpelling = true)]
    public static extern int change_device_property_items_data_32_length([NativeTypeName("const xcb_input_change_device_property_request_t *")] xcb_input_change_device_property_request_t* R, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_data_32_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t change_device_property_items_data_32_end([NativeTypeName("const xcb_input_change_device_property_request_t *")] xcb_input_change_device_property_request_t* R, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_serialize", ExactSpelling = true)]
    public static extern int change_device_property_items_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_unpack", ExactSpelling = true)]
    public static extern int change_device_property_items_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format, xcb_input_change_device_property_items_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items_sizeof", ExactSpelling = true)]
    public static extern int change_device_property_items_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_sizeof", ExactSpelling = true)]
    public static extern int change_device_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_device_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const void *")] void* items);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_device_property(xcb_connection_t* c, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const void *")] void* items);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_aux_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_device_property_aux_checked(xcb_connection_t* c, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* items);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_aux", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_device_property_aux(xcb_connection_t* c, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const xcb_input_change_device_property_items_t *")] xcb_input_change_device_property_items_t* items);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_change_device_property_items", ExactSpelling = true)]
    public static extern void* change_device_property_items([NativeTypeName("const xcb_input_change_device_property_request_t *")] xcb_input_change_device_property_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_delete_device_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_device_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_delete_device_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_device_property(xcb_connection_t* c, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("uint8_t")] byte device_id);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_8", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_device_property_items_data_8([NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_8_length", ExactSpelling = true)]
    public static extern int get_device_property_items_data_8_length([NativeTypeName("const xcb_input_get_device_property_reply_t *")] xcb_input_get_device_property_reply_t* R, [NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_8_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_device_property_items_data_8_end([NativeTypeName("const xcb_input_get_device_property_reply_t *")] xcb_input_get_device_property_reply_t* R, [NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_16", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* get_device_property_items_data_16([NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_16_length", ExactSpelling = true)]
    public static extern int get_device_property_items_data_16_length([NativeTypeName("const xcb_input_get_device_property_reply_t *")] xcb_input_get_device_property_reply_t* R, [NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_16_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_device_property_items_data_16_end([NativeTypeName("const xcb_input_get_device_property_reply_t *")] xcb_input_get_device_property_reply_t* R, [NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_32", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* get_device_property_items_data_32([NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_32_length", ExactSpelling = true)]
    public static extern int get_device_property_items_data_32_length([NativeTypeName("const xcb_input_get_device_property_reply_t *")] xcb_input_get_device_property_reply_t* R, [NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_data_32_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_device_property_items_data_32_end([NativeTypeName("const xcb_input_get_device_property_reply_t *")] xcb_input_get_device_property_reply_t* R, [NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_serialize", ExactSpelling = true)]
    public static extern int get_device_property_items_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("const xcb_input_get_device_property_items_t *")] xcb_input_get_device_property_items_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_unpack", ExactSpelling = true)]
    public static extern int get_device_property_items_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format, xcb_input_get_device_property_items_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items_sizeof", ExactSpelling = true)]
    public static extern int get_device_property_items_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_sizeof", ExactSpelling = true)]
    public static extern int get_device_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property", ExactSpelling = true)]
    public static extern xcb_input_get_device_property_cookie_t get_device_property(xcb_connection_t* c, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint len, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte _delete);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_unchecked", ExactSpelling = true)]
    public static extern xcb_input_get_device_property_cookie_t get_device_property_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint len, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte _delete);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_items", ExactSpelling = true)]
    public static extern void* get_device_property_items([NativeTypeName("const xcb_input_get_device_property_reply_t *")] xcb_input_get_device_property_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_get_device_property_reply", ExactSpelling = true)]
    public static extern xcb_input_get_device_property_reply_t* get_device_property_reply(xcb_connection_t* c, xcb_input_get_device_property_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_group_info_next", ExactSpelling = true)]
    public static extern void group_info_next(xcb_input_group_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_group_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t group_info_end(xcb_input_group_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_modifier_info_next", ExactSpelling = true)]
    public static extern void modifier_info_next(xcb_input_modifier_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_modifier_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t modifier_info_end(xcb_input_modifier_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_pointer_sizeof", ExactSpelling = true)]
    public static extern int xi_query_pointer_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_pointer", ExactSpelling = true)]
    public static extern xcb_input_xi_query_pointer_cookie_t xi_query_pointer(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_pointer_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_query_pointer_cookie_t xi_query_pointer_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_pointer_buttons", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* xi_query_pointer_buttons([NativeTypeName("const xcb_input_xi_query_pointer_reply_t *")] xcb_input_xi_query_pointer_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_pointer_buttons_length", ExactSpelling = true)]
    public static extern int xi_query_pointer_buttons_length([NativeTypeName("const xcb_input_xi_query_pointer_reply_t *")] xcb_input_xi_query_pointer_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_pointer_buttons_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_query_pointer_buttons_end([NativeTypeName("const xcb_input_xi_query_pointer_reply_t *")] xcb_input_xi_query_pointer_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_pointer_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_query_pointer_reply_t* xi_query_pointer_reply(xcb_connection_t* c, xcb_input_xi_query_pointer_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_warp_pointer_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_warp_pointer_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint src_win, [NativeTypeName("xcb_window_t")] uint dst_win, [NativeTypeName("xcb_input_fp1616_t")] int src_x, [NativeTypeName("xcb_input_fp1616_t")] int src_y, [NativeTypeName("uint16_t")] ushort src_width, [NativeTypeName("uint16_t")] ushort src_height, [NativeTypeName("xcb_input_fp1616_t")] int dst_x, [NativeTypeName("xcb_input_fp1616_t")] int dst_y, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_warp_pointer", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_warp_pointer(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint src_win, [NativeTypeName("xcb_window_t")] uint dst_win, [NativeTypeName("xcb_input_fp1616_t")] int src_x, [NativeTypeName("xcb_input_fp1616_t")] int src_y, [NativeTypeName("uint16_t")] ushort src_width, [NativeTypeName("uint16_t")] ushort src_height, [NativeTypeName("xcb_input_fp1616_t")] int dst_x, [NativeTypeName("xcb_input_fp1616_t")] int dst_y, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_cursor_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_change_cursor_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_cursor", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_change_cursor(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_add_master_sizeof", ExactSpelling = true)]
    public static extern int add_master_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_add_master_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* add_master_name([NativeTypeName("const xcb_input_add_master_t *")] xcb_input_add_master_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_add_master_name_length", ExactSpelling = true)]
    public static extern int add_master_name_length([NativeTypeName("const xcb_input_add_master_t *")] xcb_input_add_master_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_add_master_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t add_master_name_end([NativeTypeName("const xcb_input_add_master_t *")] xcb_input_add_master_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_add_master_next", ExactSpelling = true)]
    public static extern void add_master_next(xcb_input_add_master_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_add_master_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t add_master_end(xcb_input_add_master_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_remove_master_next", ExactSpelling = true)]
    public static extern void remove_master_next(xcb_input_remove_master_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_remove_master_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t remove_master_end(xcb_input_remove_master_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_attach_slave_next", ExactSpelling = true)]
    public static extern void attach_slave_next(xcb_input_attach_slave_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_attach_slave_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t attach_slave_end(xcb_input_attach_slave_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_detach_slave_next", ExactSpelling = true)]
    public static extern void detach_slave_next(xcb_input_detach_slave_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_detach_slave_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t detach_slave_end(xcb_input_detach_slave_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_data_add_master_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* hierarchy_change_data_add_master_name([NativeTypeName("const xcb_input_hierarchy_change_data_t *")] xcb_input_hierarchy_change_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_data_add_master_name_length", ExactSpelling = true)]
    public static extern int hierarchy_change_data_add_master_name_length([NativeTypeName("const xcb_input_hierarchy_change_t *")] xcb_input_hierarchy_change_t* R, [NativeTypeName("const xcb_input_hierarchy_change_data_t *")] xcb_input_hierarchy_change_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_data_add_master_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t hierarchy_change_data_add_master_name_end([NativeTypeName("const xcb_input_hierarchy_change_t *")] xcb_input_hierarchy_change_t* R, [NativeTypeName("const xcb_input_hierarchy_change_data_t *")] xcb_input_hierarchy_change_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_data_serialize", ExactSpelling = true)]
    public static extern int hierarchy_change_data_serialize(void** _buffer, [NativeTypeName("uint16_t")] ushort type, [NativeTypeName("const xcb_input_hierarchy_change_data_t *")] xcb_input_hierarchy_change_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_data_unpack", ExactSpelling = true)]
    public static extern int hierarchy_change_data_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort type, xcb_input_hierarchy_change_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_data_sizeof", ExactSpelling = true)]
    public static extern int hierarchy_change_data_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort type);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_sizeof", ExactSpelling = true)]
    public static extern int hierarchy_change_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_next", ExactSpelling = true)]
    public static extern void hierarchy_change_next(xcb_input_hierarchy_change_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_change_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t hierarchy_change_end(xcb_input_hierarchy_change_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_hierarchy_sizeof", ExactSpelling = true)]
    public static extern int xi_change_hierarchy_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_hierarchy_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_change_hierarchy_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte num_changes, [NativeTypeName("const xcb_input_hierarchy_change_t *")] xcb_input_hierarchy_change_t* changes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_hierarchy", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_change_hierarchy(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte num_changes, [NativeTypeName("const xcb_input_hierarchy_change_t *")] xcb_input_hierarchy_change_t* changes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_hierarchy_changes_length", ExactSpelling = true)]
    public static extern int xi_change_hierarchy_changes_length([NativeTypeName("const xcb_input_xi_change_hierarchy_request_t *")] xcb_input_xi_change_hierarchy_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_hierarchy_changes_iterator", ExactSpelling = true)]
    public static extern xcb_input_hierarchy_change_iterator_t xi_change_hierarchy_changes_iterator([NativeTypeName("const xcb_input_xi_change_hierarchy_request_t *")] xcb_input_xi_change_hierarchy_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_set_client_pointer_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_set_client_pointer_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_set_client_pointer", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_set_client_pointer(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_client_pointer", ExactSpelling = true)]
    public static extern xcb_input_xi_get_client_pointer_cookie_t xi_get_client_pointer(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_client_pointer_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_get_client_pointer_cookie_t xi_get_client_pointer_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_client_pointer_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_get_client_pointer_reply_t* xi_get_client_pointer_reply(xcb_connection_t* c, xcb_input_xi_get_client_pointer_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_mask_sizeof", ExactSpelling = true)]
    public static extern int event_mask_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_mask_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* event_mask_mask([NativeTypeName("const xcb_input_event_mask_t *")] xcb_input_event_mask_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_mask_mask_length", ExactSpelling = true)]
    public static extern int event_mask_mask_length([NativeTypeName("const xcb_input_event_mask_t *")] xcb_input_event_mask_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_mask_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t event_mask_mask_end([NativeTypeName("const xcb_input_event_mask_t *")] xcb_input_event_mask_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_mask_next", ExactSpelling = true)]
    public static extern void event_mask_next(xcb_input_event_mask_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t event_mask_end(xcb_input_event_mask_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_select_events_sizeof", ExactSpelling = true)]
    public static extern int xi_select_events_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_select_events_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_select_events_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort num_mask, [NativeTypeName("const xcb_input_event_mask_t *")] xcb_input_event_mask_t* masks);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_select_events", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_select_events(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort num_mask, [NativeTypeName("const xcb_input_event_mask_t *")] xcb_input_event_mask_t* masks);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_select_events_masks_length", ExactSpelling = true)]
    public static extern int xi_select_events_masks_length([NativeTypeName("const xcb_input_xi_select_events_request_t *")] xcb_input_xi_select_events_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_select_events_masks_iterator", ExactSpelling = true)]
    public static extern xcb_input_event_mask_iterator_t xi_select_events_masks_iterator([NativeTypeName("const xcb_input_xi_select_events_request_t *")] xcb_input_xi_select_events_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_version", ExactSpelling = true)]
    public static extern xcb_input_xi_query_version_cookie_t xi_query_version(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort major_version, [NativeTypeName("uint16_t")] ushort minor_version);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_version_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_query_version_cookie_t xi_query_version_unchecked(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort major_version, [NativeTypeName("uint16_t")] ushort minor_version);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_version_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_query_version_reply_t* xi_query_version_reply(xcb_connection_t* c, xcb_input_xi_query_version_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_sizeof", ExactSpelling = true)]
    public static extern int button_class_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_state", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* button_class_state([NativeTypeName("const xcb_input_button_class_t *")] xcb_input_button_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_state_length", ExactSpelling = true)]
    public static extern int button_class_state_length([NativeTypeName("const xcb_input_button_class_t *")] xcb_input_button_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t button_class_state_end([NativeTypeName("const xcb_input_button_class_t *")] xcb_input_button_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_labels", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* button_class_labels([NativeTypeName("const xcb_input_button_class_t *")] xcb_input_button_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_labels_length", ExactSpelling = true)]
    public static extern int button_class_labels_length([NativeTypeName("const xcb_input_button_class_t *")] xcb_input_button_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_labels_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t button_class_labels_end([NativeTypeName("const xcb_input_button_class_t *")] xcb_input_button_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_next", ExactSpelling = true)]
    public static extern void button_class_next(xcb_input_button_class_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_class_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t button_class_end(xcb_input_button_class_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_class_sizeof", ExactSpelling = true)]
    public static extern int key_class_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_class_keys", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* key_class_keys([NativeTypeName("const xcb_input_key_class_t *")] xcb_input_key_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_class_keys_length", ExactSpelling = true)]
    public static extern int key_class_keys_length([NativeTypeName("const xcb_input_key_class_t *")] xcb_input_key_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_class_keys_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_class_keys_end([NativeTypeName("const xcb_input_key_class_t *")] xcb_input_key_class_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_class_next", ExactSpelling = true)]
    public static extern void key_class_next(xcb_input_key_class_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_class_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_class_end(xcb_input_key_class_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_scroll_class_next", ExactSpelling = true)]
    public static extern void scroll_class_next(xcb_input_scroll_class_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_scroll_class_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t scroll_class_end(xcb_input_scroll_class_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_class_next", ExactSpelling = true)]
    public static extern void touch_class_next(xcb_input_touch_class_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_class_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t touch_class_end(xcb_input_touch_class_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_gesture_class_next", ExactSpelling = true)]
    public static extern void gesture_class_next(xcb_input_gesture_class_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_gesture_class_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t gesture_class_end(xcb_input_gesture_class_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_class_next", ExactSpelling = true)]
    public static extern void valuator_class_next(xcb_input_valuator_class_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_valuator_class_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t valuator_class_end(xcb_input_valuator_class_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_key_keys", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_class_data_key_keys([NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_key_keys_length", ExactSpelling = true)]
    public static extern int device_class_data_key_keys_length([NativeTypeName("const xcb_input_device_class_t *")] xcb_input_device_class_t* R, [NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_key_keys_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_class_data_key_keys_end([NativeTypeName("const xcb_input_device_class_t *")] xcb_input_device_class_t* R, [NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_button_state", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* device_class_data_button_state([NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_button_state_length", ExactSpelling = true)]
    public static extern int device_class_data_button_state_length([NativeTypeName("const xcb_input_device_class_t *")] xcb_input_device_class_t* R, [NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_button_state_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_class_data_button_state_end([NativeTypeName("const xcb_input_device_class_t *")] xcb_input_device_class_t* R, [NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_button_labels", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* device_class_data_button_labels([NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_button_labels_length", ExactSpelling = true)]
    public static extern int device_class_data_button_labels_length([NativeTypeName("const xcb_input_device_class_t *")] xcb_input_device_class_t* R, [NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_button_labels_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_class_data_button_labels_end([NativeTypeName("const xcb_input_device_class_t *")] xcb_input_device_class_t* R, [NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_serialize", ExactSpelling = true)]
    public static extern int device_class_data_serialize(void** _buffer, [NativeTypeName("uint16_t")] ushort type, [NativeTypeName("const xcb_input_device_class_data_t *")] xcb_input_device_class_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_unpack", ExactSpelling = true)]
    public static extern int device_class_data_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort type, xcb_input_device_class_data_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_data_sizeof", ExactSpelling = true)]
    public static extern int device_class_data_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort type);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_sizeof", ExactSpelling = true)]
    public static extern int device_class_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_next", ExactSpelling = true)]
    public static extern void device_class_next(xcb_input_device_class_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_class_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_class_end(xcb_input_device_class_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_device_info_sizeof", ExactSpelling = true)]
    public static extern int xi_device_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_device_info_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* xi_device_info_name([NativeTypeName("const xcb_input_xi_device_info_t *")] xcb_input_xi_device_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_device_info_name_length", ExactSpelling = true)]
    public static extern int xi_device_info_name_length([NativeTypeName("const xcb_input_xi_device_info_t *")] xcb_input_xi_device_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_device_info_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_device_info_name_end([NativeTypeName("const xcb_input_xi_device_info_t *")] xcb_input_xi_device_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_device_info_classes_length", ExactSpelling = true)]
    public static extern int xi_device_info_classes_length([NativeTypeName("const xcb_input_xi_device_info_t *")] xcb_input_xi_device_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_device_info_classes_iterator", ExactSpelling = true)]
    public static extern xcb_input_device_class_iterator_t xi_device_info_classes_iterator([NativeTypeName("const xcb_input_xi_device_info_t *")] xcb_input_xi_device_info_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_device_info_next", ExactSpelling = true)]
    public static extern void xi_device_info_next(xcb_input_xi_device_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_device_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_device_info_end(xcb_input_xi_device_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_device_sizeof", ExactSpelling = true)]
    public static extern int xi_query_device_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_device", ExactSpelling = true)]
    public static extern xcb_input_xi_query_device_cookie_t xi_query_device(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_device_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_query_device_cookie_t xi_query_device_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_device_infos_length", ExactSpelling = true)]
    public static extern int xi_query_device_infos_length([NativeTypeName("const xcb_input_xi_query_device_reply_t *")] xcb_input_xi_query_device_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_device_infos_iterator", ExactSpelling = true)]
    public static extern xcb_input_xi_device_info_iterator_t xi_query_device_infos_iterator([NativeTypeName("const xcb_input_xi_query_device_reply_t *")] xcb_input_xi_query_device_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_query_device_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_query_device_reply_t* xi_query_device_reply(xcb_connection_t* c, xcb_input_xi_query_device_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_set_focus_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_set_focus_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_set_focus", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_set_focus(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_focus", ExactSpelling = true)]
    public static extern xcb_input_xi_get_focus_cookie_t xi_get_focus(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_focus_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_get_focus_cookie_t xi_get_focus_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_focus_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_get_focus_reply_t* xi_get_focus_reply(xcb_connection_t* c, xcb_input_xi_get_focus_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_grab_device_sizeof", ExactSpelling = true)]
    public static extern int xi_grab_device_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_grab_device", ExactSpelling = true)]
    public static extern xcb_input_xi_grab_device_cookie_t xi_grab_device(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte paired_device_mode, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("uint16_t")] ushort mask_len, [NativeTypeName("const uint32_t *")] uint* mask);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_grab_device_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_grab_device_cookie_t xi_grab_device_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte paired_device_mode, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("uint16_t")] ushort mask_len, [NativeTypeName("const uint32_t *")] uint* mask);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_grab_device_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_grab_device_reply_t* xi_grab_device_reply(xcb_connection_t* c, xcb_input_xi_grab_device_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_ungrab_device_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_ungrab_device_checked(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_ungrab_device", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_ungrab_device(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_allow_events_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_allow_events_checked(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte event_mode, [NativeTypeName("uint32_t")] uint touchid, [NativeTypeName("xcb_window_t")] uint grab_window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_allow_events", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_allow_events(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte event_mode, [NativeTypeName("uint32_t")] uint touchid, [NativeTypeName("xcb_window_t")] uint grab_window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_modifier_info_next", ExactSpelling = true)]
    public static extern void grab_modifier_info_next(xcb_input_grab_modifier_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_grab_modifier_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t grab_modifier_info_end(xcb_input_grab_modifier_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_grab_device_sizeof", ExactSpelling = true)]
    public static extern int xi_passive_grab_device_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_grab_device", ExactSpelling = true)]
    public static extern xcb_input_xi_passive_grab_device_cookie_t xi_passive_grab_device(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("uint32_t")] uint detail, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint16_t")] ushort num_modifiers, [NativeTypeName("uint16_t")] ushort mask_len, [NativeTypeName("uint8_t")] byte grab_type, [NativeTypeName("uint8_t")] byte grab_mode, [NativeTypeName("uint8_t")] byte paired_device_mode, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("const uint32_t *")] uint* mask, [NativeTypeName("const uint32_t *")] uint* modifiers);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_grab_device_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_passive_grab_device_cookie_t xi_passive_grab_device_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("uint32_t")] uint detail, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint16_t")] ushort num_modifiers, [NativeTypeName("uint16_t")] ushort mask_len, [NativeTypeName("uint8_t")] byte grab_type, [NativeTypeName("uint8_t")] byte grab_mode, [NativeTypeName("uint8_t")] byte paired_device_mode, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("const uint32_t *")] uint* mask, [NativeTypeName("const uint32_t *")] uint* modifiers);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_grab_device_modifiers", ExactSpelling = true)]
    public static extern xcb_input_grab_modifier_info_t* xi_passive_grab_device_modifiers([NativeTypeName("const xcb_input_xi_passive_grab_device_reply_t *")] xcb_input_xi_passive_grab_device_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_grab_device_modifiers_length", ExactSpelling = true)]
    public static extern int xi_passive_grab_device_modifiers_length([NativeTypeName("const xcb_input_xi_passive_grab_device_reply_t *")] xcb_input_xi_passive_grab_device_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_grab_device_modifiers_iterator", ExactSpelling = true)]
    public static extern xcb_input_grab_modifier_info_iterator_t xi_passive_grab_device_modifiers_iterator([NativeTypeName("const xcb_input_xi_passive_grab_device_reply_t *")] xcb_input_xi_passive_grab_device_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_grab_device_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_passive_grab_device_reply_t* xi_passive_grab_device_reply(xcb_connection_t* c, xcb_input_xi_passive_grab_device_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_ungrab_device_sizeof", ExactSpelling = true)]
    public static extern int xi_passive_ungrab_device_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_ungrab_device_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_passive_ungrab_device_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint32_t")] uint detail, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint16_t")] ushort num_modifiers, [NativeTypeName("uint8_t")] byte grab_type, [NativeTypeName("const uint32_t *")] uint* modifiers);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_ungrab_device", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_passive_ungrab_device(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint32_t")] uint detail, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint16_t")] ushort num_modifiers, [NativeTypeName("uint8_t")] byte grab_type, [NativeTypeName("const uint32_t *")] uint* modifiers);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_ungrab_device_modifiers", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* xi_passive_ungrab_device_modifiers([NativeTypeName("const xcb_input_xi_passive_ungrab_device_request_t *")] xcb_input_xi_passive_ungrab_device_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_ungrab_device_modifiers_length", ExactSpelling = true)]
    public static extern int xi_passive_ungrab_device_modifiers_length([NativeTypeName("const xcb_input_xi_passive_ungrab_device_request_t *")] xcb_input_xi_passive_ungrab_device_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_passive_ungrab_device_modifiers_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_passive_ungrab_device_modifiers_end([NativeTypeName("const xcb_input_xi_passive_ungrab_device_request_t *")] xcb_input_xi_passive_ungrab_device_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_list_properties_sizeof", ExactSpelling = true)]
    public static extern int xi_list_properties_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_list_properties", ExactSpelling = true)]
    public static extern xcb_input_xi_list_properties_cookie_t xi_list_properties(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_list_properties_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_list_properties_cookie_t xi_list_properties_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_list_properties_properties", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* xi_list_properties_properties([NativeTypeName("const xcb_input_xi_list_properties_reply_t *")] xcb_input_xi_list_properties_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_list_properties_properties_length", ExactSpelling = true)]
    public static extern int xi_list_properties_properties_length([NativeTypeName("const xcb_input_xi_list_properties_reply_t *")] xcb_input_xi_list_properties_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_list_properties_properties_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_list_properties_properties_end([NativeTypeName("const xcb_input_xi_list_properties_reply_t *")] xcb_input_xi_list_properties_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_list_properties_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_list_properties_reply_t* xi_list_properties_reply(xcb_connection_t* c, xcb_input_xi_list_properties_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_8", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* xi_change_property_items_data_8([NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_8_length", ExactSpelling = true)]
    public static extern int xi_change_property_items_data_8_length([NativeTypeName("const xcb_input_xi_change_property_request_t *")] xcb_input_xi_change_property_request_t* R, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_8_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_change_property_items_data_8_end([NativeTypeName("const xcb_input_xi_change_property_request_t *")] xcb_input_xi_change_property_request_t* R, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_16", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* xi_change_property_items_data_16([NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_16_length", ExactSpelling = true)]
    public static extern int xi_change_property_items_data_16_length([NativeTypeName("const xcb_input_xi_change_property_request_t *")] xcb_input_xi_change_property_request_t* R, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_16_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_change_property_items_data_16_end([NativeTypeName("const xcb_input_xi_change_property_request_t *")] xcb_input_xi_change_property_request_t* R, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_32", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* xi_change_property_items_data_32([NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_32_length", ExactSpelling = true)]
    public static extern int xi_change_property_items_data_32_length([NativeTypeName("const xcb_input_xi_change_property_request_t *")] xcb_input_xi_change_property_request_t* R, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_data_32_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_change_property_items_data_32_end([NativeTypeName("const xcb_input_xi_change_property_request_t *")] xcb_input_xi_change_property_request_t* R, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_serialize", ExactSpelling = true)]
    public static extern int xi_change_property_items_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_unpack", ExactSpelling = true)]
    public static extern int xi_change_property_items_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format, xcb_input_xi_change_property_items_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items_sizeof", ExactSpelling = true)]
    public static extern int xi_change_property_items_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_sizeof", ExactSpelling = true)]
    public static extern int xi_change_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_change_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const void *")] void* items);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_change_property(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const void *")] void* items);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_aux_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_change_property_aux_checked(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* items);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_aux", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_change_property_aux(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("const xcb_input_xi_change_property_items_t *")] xcb_input_xi_change_property_items_t* items);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_change_property_items", ExactSpelling = true)]
    public static extern void* xi_change_property_items([NativeTypeName("const xcb_input_xi_change_property_request_t *")] xcb_input_xi_change_property_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_delete_property_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_delete_property_checked(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_delete_property", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_delete_property(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("xcb_atom_t")] uint property);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_8", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* xi_get_property_items_data_8([NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_8_length", ExactSpelling = true)]
    public static extern int xi_get_property_items_data_8_length([NativeTypeName("const xcb_input_xi_get_property_reply_t *")] xcb_input_xi_get_property_reply_t* R, [NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_8_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_get_property_items_data_8_end([NativeTypeName("const xcb_input_xi_get_property_reply_t *")] xcb_input_xi_get_property_reply_t* R, [NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_16", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* xi_get_property_items_data_16([NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_16_length", ExactSpelling = true)]
    public static extern int xi_get_property_items_data_16_length([NativeTypeName("const xcb_input_xi_get_property_reply_t *")] xcb_input_xi_get_property_reply_t* R, [NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_16_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_get_property_items_data_16_end([NativeTypeName("const xcb_input_xi_get_property_reply_t *")] xcb_input_xi_get_property_reply_t* R, [NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_32", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* xi_get_property_items_data_32([NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_32_length", ExactSpelling = true)]
    public static extern int xi_get_property_items_data_32_length([NativeTypeName("const xcb_input_xi_get_property_reply_t *")] xcb_input_xi_get_property_reply_t* R, [NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_data_32_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t xi_get_property_items_data_32_end([NativeTypeName("const xcb_input_xi_get_property_reply_t *")] xcb_input_xi_get_property_reply_t* R, [NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* S);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_serialize", ExactSpelling = true)]
    public static extern int xi_get_property_items_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("const xcb_input_xi_get_property_items_t *")] xcb_input_xi_get_property_items_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_unpack", ExactSpelling = true)]
    public static extern int xi_get_property_items_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format, xcb_input_xi_get_property_items_t* _aux);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items_sizeof", ExactSpelling = true)]
    public static extern int xi_get_property_items_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint num_items, [NativeTypeName("uint8_t")] byte format);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_sizeof", ExactSpelling = true)]
    public static extern int xi_get_property_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property", ExactSpelling = true)]
    public static extern xcb_input_xi_get_property_cookie_t xi_get_property(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte _delete, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint len);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_get_property_cookie_t xi_get_property_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_input_device_id_t")] ushort deviceid, [NativeTypeName("uint8_t")] byte _delete, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint len);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_items", ExactSpelling = true)]
    public static extern void* xi_get_property_items([NativeTypeName("const xcb_input_xi_get_property_reply_t *")] xcb_input_xi_get_property_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_property_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_get_property_reply_t* xi_get_property_reply(xcb_connection_t* c, xcb_input_xi_get_property_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_selected_events_sizeof", ExactSpelling = true)]
    public static extern int xi_get_selected_events_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_selected_events", ExactSpelling = true)]
    public static extern xcb_input_xi_get_selected_events_cookie_t xi_get_selected_events(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_selected_events_unchecked", ExactSpelling = true)]
    public static extern xcb_input_xi_get_selected_events_cookie_t xi_get_selected_events_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_selected_events_masks_length", ExactSpelling = true)]
    public static extern int xi_get_selected_events_masks_length([NativeTypeName("const xcb_input_xi_get_selected_events_reply_t *")] xcb_input_xi_get_selected_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_selected_events_masks_iterator", ExactSpelling = true)]
    public static extern xcb_input_event_mask_iterator_t xi_get_selected_events_masks_iterator([NativeTypeName("const xcb_input_xi_get_selected_events_reply_t *")] xcb_input_xi_get_selected_events_reply_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_get_selected_events_reply", ExactSpelling = true)]
    public static extern xcb_input_xi_get_selected_events_reply_t* xi_get_selected_events_reply(xcb_connection_t* c, xcb_input_xi_get_selected_events_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_barrier_release_pointer_info_next", ExactSpelling = true)]
    public static extern void barrier_release_pointer_info_next(xcb_input_barrier_release_pointer_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_barrier_release_pointer_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t barrier_release_pointer_info_end(xcb_input_barrier_release_pointer_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_barrier_release_pointer_sizeof", ExactSpelling = true)]
    public static extern int xi_barrier_release_pointer_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_barrier_release_pointer_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_barrier_release_pointer_checked(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint num_barriers, [NativeTypeName("const xcb_input_barrier_release_pointer_info_t *")] xcb_input_barrier_release_pointer_info_t* barriers);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_barrier_release_pointer", ExactSpelling = true)]
    public static extern xcb_void_cookie_t xi_barrier_release_pointer(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint num_barriers, [NativeTypeName("const xcb_input_barrier_release_pointer_info_t *")] xcb_input_barrier_release_pointer_info_t* barriers);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_barrier_release_pointer_barriers", ExactSpelling = true)]
    public static extern xcb_input_barrier_release_pointer_info_t* xi_barrier_release_pointer_barriers([NativeTypeName("const xcb_input_xi_barrier_release_pointer_request_t *")] xcb_input_xi_barrier_release_pointer_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_barrier_release_pointer_barriers_length", ExactSpelling = true)]
    public static extern int xi_barrier_release_pointer_barriers_length([NativeTypeName("const xcb_input_xi_barrier_release_pointer_request_t *")] xcb_input_xi_barrier_release_pointer_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_xi_barrier_release_pointer_barriers_iterator", ExactSpelling = true)]
    public static extern xcb_input_barrier_release_pointer_info_iterator_t xi_barrier_release_pointer_barriers_iterator([NativeTypeName("const xcb_input_xi_barrier_release_pointer_request_t *")] xcb_input_xi_barrier_release_pointer_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_changed_sizeof", ExactSpelling = true)]
    public static extern int device_changed_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_changed_classes_length", ExactSpelling = true)]
    public static extern int device_changed_classes_length([NativeTypeName("const xcb_input_device_changed_event_t *")] xcb_input_device_changed_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_device_changed_classes_iterator", ExactSpelling = true)]
    public static extern xcb_input_device_class_iterator_t device_changed_classes_iterator([NativeTypeName("const xcb_input_device_changed_event_t *")] xcb_input_device_changed_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_sizeof", ExactSpelling = true)]
    public static extern int key_press_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_button_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* key_press_button_mask([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_button_mask_length", ExactSpelling = true)]
    public static extern int key_press_button_mask_length([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_button_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_press_button_mask_end([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_valuator_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* key_press_valuator_mask([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_valuator_mask_length", ExactSpelling = true)]
    public static extern int key_press_valuator_mask_length([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_valuator_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_press_valuator_mask_end([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_axisvalues", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* key_press_axisvalues([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_axisvalues_length", ExactSpelling = true)]
    public static extern int key_press_axisvalues_length([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_press_axisvalues_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t key_press_axisvalues_iterator([NativeTypeName("const xcb_input_key_press_event_t *")] xcb_input_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_key_release_sizeof", ExactSpelling = true)]
    public static extern int key_release_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_sizeof", ExactSpelling = true)]
    public static extern int button_press_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_button_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* button_press_button_mask([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_button_mask_length", ExactSpelling = true)]
    public static extern int button_press_button_mask_length([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_button_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t button_press_button_mask_end([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_valuator_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* button_press_valuator_mask([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_valuator_mask_length", ExactSpelling = true)]
    public static extern int button_press_valuator_mask_length([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_valuator_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t button_press_valuator_mask_end([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_axisvalues", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* button_press_axisvalues([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_axisvalues_length", ExactSpelling = true)]
    public static extern int button_press_axisvalues_length([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_press_axisvalues_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t button_press_axisvalues_iterator([NativeTypeName("const xcb_input_button_press_event_t *")] xcb_input_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_button_release_sizeof", ExactSpelling = true)]
    public static extern int button_release_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_motion_sizeof", ExactSpelling = true)]
    public static extern int motion_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_enter_sizeof", ExactSpelling = true)]
    public static extern int enter_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_enter_buttons", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* enter_buttons([NativeTypeName("const xcb_input_enter_event_t *")] xcb_input_enter_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_enter_buttons_length", ExactSpelling = true)]
    public static extern int enter_buttons_length([NativeTypeName("const xcb_input_enter_event_t *")] xcb_input_enter_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_enter_buttons_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t enter_buttons_end([NativeTypeName("const xcb_input_enter_event_t *")] xcb_input_enter_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_leave_sizeof", ExactSpelling = true)]
    public static extern int leave_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_focus_in_sizeof", ExactSpelling = true)]
    public static extern int focus_in_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_focus_out_sizeof", ExactSpelling = true)]
    public static extern int focus_out_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_info_next", ExactSpelling = true)]
    public static extern void hierarchy_info_next(xcb_input_hierarchy_info_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t hierarchy_info_end(xcb_input_hierarchy_info_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_sizeof", ExactSpelling = true)]
    public static extern int hierarchy_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_infos", ExactSpelling = true)]
    public static extern xcb_input_hierarchy_info_t* hierarchy_infos([NativeTypeName("const xcb_input_hierarchy_event_t *")] xcb_input_hierarchy_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_infos_length", ExactSpelling = true)]
    public static extern int hierarchy_infos_length([NativeTypeName("const xcb_input_hierarchy_event_t *")] xcb_input_hierarchy_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_hierarchy_infos_iterator", ExactSpelling = true)]
    public static extern xcb_input_hierarchy_info_iterator_t hierarchy_infos_iterator([NativeTypeName("const xcb_input_hierarchy_event_t *")] xcb_input_hierarchy_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_sizeof", ExactSpelling = true)]
    public static extern int raw_key_press_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_valuator_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* raw_key_press_valuator_mask([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_valuator_mask_length", ExactSpelling = true)]
    public static extern int raw_key_press_valuator_mask_length([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_valuator_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t raw_key_press_valuator_mask_end([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_axisvalues", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* raw_key_press_axisvalues([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_axisvalues_length", ExactSpelling = true)]
    public static extern int raw_key_press_axisvalues_length([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_axisvalues_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t raw_key_press_axisvalues_iterator([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_axisvalues_raw", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* raw_key_press_axisvalues_raw([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_axisvalues_raw_length", ExactSpelling = true)]
    public static extern int raw_key_press_axisvalues_raw_length([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_press_axisvalues_raw_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t raw_key_press_axisvalues_raw_iterator([NativeTypeName("const xcb_input_raw_key_press_event_t *")] xcb_input_raw_key_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_key_release_sizeof", ExactSpelling = true)]
    public static extern int raw_key_release_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_sizeof", ExactSpelling = true)]
    public static extern int raw_button_press_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_valuator_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* raw_button_press_valuator_mask([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_valuator_mask_length", ExactSpelling = true)]
    public static extern int raw_button_press_valuator_mask_length([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_valuator_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t raw_button_press_valuator_mask_end([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_axisvalues", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* raw_button_press_axisvalues([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_axisvalues_length", ExactSpelling = true)]
    public static extern int raw_button_press_axisvalues_length([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_axisvalues_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t raw_button_press_axisvalues_iterator([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_axisvalues_raw", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* raw_button_press_axisvalues_raw([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_axisvalues_raw_length", ExactSpelling = true)]
    public static extern int raw_button_press_axisvalues_raw_length([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_press_axisvalues_raw_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t raw_button_press_axisvalues_raw_iterator([NativeTypeName("const xcb_input_raw_button_press_event_t *")] xcb_input_raw_button_press_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_button_release_sizeof", ExactSpelling = true)]
    public static extern int raw_button_release_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_motion_sizeof", ExactSpelling = true)]
    public static extern int raw_motion_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_sizeof", ExactSpelling = true)]
    public static extern int touch_begin_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_button_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* touch_begin_button_mask([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_button_mask_length", ExactSpelling = true)]
    public static extern int touch_begin_button_mask_length([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_button_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t touch_begin_button_mask_end([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_valuator_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* touch_begin_valuator_mask([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_valuator_mask_length", ExactSpelling = true)]
    public static extern int touch_begin_valuator_mask_length([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_valuator_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t touch_begin_valuator_mask_end([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_axisvalues", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* touch_begin_axisvalues([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_axisvalues_length", ExactSpelling = true)]
    public static extern int touch_begin_axisvalues_length([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_begin_axisvalues_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t touch_begin_axisvalues_iterator([NativeTypeName("const xcb_input_touch_begin_event_t *")] xcb_input_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_update_sizeof", ExactSpelling = true)]
    public static extern int touch_update_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_touch_end_sizeof", ExactSpelling = true)]
    public static extern int touch_end_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_sizeof", ExactSpelling = true)]
    public static extern int raw_touch_begin_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_valuator_mask", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* raw_touch_begin_valuator_mask([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_valuator_mask_length", ExactSpelling = true)]
    public static extern int raw_touch_begin_valuator_mask_length([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_valuator_mask_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t raw_touch_begin_valuator_mask_end([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_axisvalues", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* raw_touch_begin_axisvalues([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_axisvalues_length", ExactSpelling = true)]
    public static extern int raw_touch_begin_axisvalues_length([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_axisvalues_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t raw_touch_begin_axisvalues_iterator([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_axisvalues_raw", ExactSpelling = true)]
    public static extern xcb_input_fp3232_t* raw_touch_begin_axisvalues_raw([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_axisvalues_raw_length", ExactSpelling = true)]
    public static extern int raw_touch_begin_axisvalues_raw_length([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_begin_axisvalues_raw_iterator", ExactSpelling = true)]
    public static extern xcb_input_fp3232_iterator_t raw_touch_begin_axisvalues_raw_iterator([NativeTypeName("const xcb_input_raw_touch_begin_event_t *")] xcb_input_raw_touch_begin_event_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_update_sizeof", ExactSpelling = true)]
    public static extern int raw_touch_update_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_raw_touch_end_sizeof", ExactSpelling = true)]
    public static extern int raw_touch_end_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_for_send_next", ExactSpelling = true)]
    public static extern void event_for_send_next(xcb_input_event_for_send_iterator_t* i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_event_for_send_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t event_for_send_end(xcb_input_event_for_send_iterator_t i);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event_sizeof", ExactSpelling = true)]
    public static extern int send_extension_event_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t send_extension_event_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint destination, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte propagate, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint8_t")] byte num_events, [NativeTypeName("const xcb_input_event_for_send_t *")] xcb_input_event_for_send_t* events, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event", ExactSpelling = true)]
    public static extern xcb_void_cookie_t send_extension_event(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint destination, [NativeTypeName("uint8_t")] byte device_id, [NativeTypeName("uint8_t")] byte propagate, [NativeTypeName("uint16_t")] ushort num_classes, [NativeTypeName("uint8_t")] byte num_events, [NativeTypeName("const xcb_input_event_for_send_t *")] xcb_input_event_for_send_t* events, [NativeTypeName("const xcb_input_event_class_t *")] uint* classes);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event_events", ExactSpelling = true)]
    public static extern xcb_input_event_for_send_t* send_extension_event_events([NativeTypeName("const xcb_input_send_extension_event_request_t *")] xcb_input_send_extension_event_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event_events_length", ExactSpelling = true)]
    public static extern int send_extension_event_events_length([NativeTypeName("const xcb_input_send_extension_event_request_t *")] xcb_input_send_extension_event_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event_events_iterator", ExactSpelling = true)]
    public static extern xcb_input_event_for_send_iterator_t send_extension_event_events_iterator([NativeTypeName("const xcb_input_send_extension_event_request_t *")] xcb_input_send_extension_event_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event_classes", ExactSpelling = true)]
    [return: NativeTypeName("xcb_input_event_class_t *")]
    public static extern uint* send_extension_event_classes([NativeTypeName("const xcb_input_send_extension_event_request_t *")] xcb_input_send_extension_event_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event_classes_length", ExactSpelling = true)]
    public static extern int send_extension_event_classes_length([NativeTypeName("const xcb_input_send_extension_event_request_t *")] xcb_input_send_extension_event_request_t* R);

    [DllImport("xcb-xinput", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_input_send_extension_event_classes_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t send_extension_event_classes_end([NativeTypeName("const xcb_input_send_extension_event_request_t *")] xcb_input_send_extension_event_request_t* R);

    [NativeTypeName("#define XCB_INPUT_MAJOR_VERSION 2")]
    public const int XCB_INPUT_MAJOR_VERSION = 2;

    [NativeTypeName("#define XCB_INPUT_MINOR_VERSION 4")]
    public const int XCB_INPUT_MINOR_VERSION = 4;

    [NativeTypeName("#define XCB_INPUT_GET_EXTENSION_VERSION 1")]
    public const int XCB_INPUT_GET_EXTENSION_VERSION = 1;

    [NativeTypeName("#define XCB_INPUT_LIST_INPUT_DEVICES 2")]
    public const int XCB_INPUT_LIST_INPUT_DEVICES = 2;

    [NativeTypeName("#define XCB_INPUT_OPEN_DEVICE 3")]
    public const int XCB_INPUT_OPEN_DEVICE = 3;

    [NativeTypeName("#define XCB_INPUT_CLOSE_DEVICE 4")]
    public const int XCB_INPUT_CLOSE_DEVICE = 4;

    [NativeTypeName("#define XCB_INPUT_SET_DEVICE_MODE 5")]
    public const int XCB_INPUT_SET_DEVICE_MODE = 5;

    [NativeTypeName("#define XCB_INPUT_SELECT_EXTENSION_EVENT 6")]
    public const int XCB_INPUT_SELECT_EXTENSION_EVENT = 6;

    [NativeTypeName("#define XCB_INPUT_GET_SELECTED_EXTENSION_EVENTS 7")]
    public const int XCB_INPUT_GET_SELECTED_EXTENSION_EVENTS = 7;

    [NativeTypeName("#define XCB_INPUT_CHANGE_DEVICE_DONT_PROPAGATE_LIST 8")]
    public const int XCB_INPUT_CHANGE_DEVICE_DONT_PROPAGATE_LIST = 8;

    [NativeTypeName("#define XCB_INPUT_GET_DEVICE_DONT_PROPAGATE_LIST 9")]
    public const int XCB_INPUT_GET_DEVICE_DONT_PROPAGATE_LIST = 9;

    [NativeTypeName("#define XCB_INPUT_GET_DEVICE_MOTION_EVENTS 10")]
    public const int XCB_INPUT_GET_DEVICE_MOTION_EVENTS = 10;

    [NativeTypeName("#define XCB_INPUT_CHANGE_KEYBOARD_DEVICE 11")]
    public const int XCB_INPUT_CHANGE_KEYBOARD_DEVICE = 11;

    [NativeTypeName("#define XCB_INPUT_CHANGE_POINTER_DEVICE 12")]
    public const int XCB_INPUT_CHANGE_POINTER_DEVICE = 12;

    [NativeTypeName("#define XCB_INPUT_GRAB_DEVICE 13")]
    public const int XCB_INPUT_GRAB_DEVICE = 13;

    [NativeTypeName("#define XCB_INPUT_UNGRAB_DEVICE 14")]
    public const int XCB_INPUT_UNGRAB_DEVICE = 14;

    [NativeTypeName("#define XCB_INPUT_GRAB_DEVICE_KEY 15")]
    public const int XCB_INPUT_GRAB_DEVICE_KEY = 15;

    [NativeTypeName("#define XCB_INPUT_UNGRAB_DEVICE_KEY 16")]
    public const int XCB_INPUT_UNGRAB_DEVICE_KEY = 16;

    [NativeTypeName("#define XCB_INPUT_GRAB_DEVICE_BUTTON 17")]
    public const int XCB_INPUT_GRAB_DEVICE_BUTTON = 17;

    [NativeTypeName("#define XCB_INPUT_UNGRAB_DEVICE_BUTTON 18")]
    public const int XCB_INPUT_UNGRAB_DEVICE_BUTTON = 18;

    [NativeTypeName("#define XCB_INPUT_ALLOW_DEVICE_EVENTS 19")]
    public const int XCB_INPUT_ALLOW_DEVICE_EVENTS = 19;

    [NativeTypeName("#define XCB_INPUT_GET_DEVICE_FOCUS 20")]
    public const int XCB_INPUT_GET_DEVICE_FOCUS = 20;

    [NativeTypeName("#define XCB_INPUT_SET_DEVICE_FOCUS 21")]
    public const int XCB_INPUT_SET_DEVICE_FOCUS = 21;

    [NativeTypeName("#define XCB_INPUT_GET_FEEDBACK_CONTROL 22")]
    public const int XCB_INPUT_GET_FEEDBACK_CONTROL = 22;

    [NativeTypeName("#define XCB_INPUT_CHANGE_FEEDBACK_CONTROL 23")]
    public const int XCB_INPUT_CHANGE_FEEDBACK_CONTROL = 23;

    [NativeTypeName("#define XCB_INPUT_GET_DEVICE_KEY_MAPPING 24")]
    public const int XCB_INPUT_GET_DEVICE_KEY_MAPPING = 24;

    [NativeTypeName("#define XCB_INPUT_CHANGE_DEVICE_KEY_MAPPING 25")]
    public const int XCB_INPUT_CHANGE_DEVICE_KEY_MAPPING = 25;

    [NativeTypeName("#define XCB_INPUT_GET_DEVICE_MODIFIER_MAPPING 26")]
    public const int XCB_INPUT_GET_DEVICE_MODIFIER_MAPPING = 26;

    [NativeTypeName("#define XCB_INPUT_SET_DEVICE_MODIFIER_MAPPING 27")]
    public const int XCB_INPUT_SET_DEVICE_MODIFIER_MAPPING = 27;

    [NativeTypeName("#define XCB_INPUT_GET_DEVICE_BUTTON_MAPPING 28")]
    public const int XCB_INPUT_GET_DEVICE_BUTTON_MAPPING = 28;

    [NativeTypeName("#define XCB_INPUT_SET_DEVICE_BUTTON_MAPPING 29")]
    public const int XCB_INPUT_SET_DEVICE_BUTTON_MAPPING = 29;

    [NativeTypeName("#define XCB_INPUT_QUERY_DEVICE_STATE 30")]
    public const int XCB_INPUT_QUERY_DEVICE_STATE = 30;

    [NativeTypeName("#define XCB_INPUT_DEVICE_BELL 32")]
    public const int XCB_INPUT_DEVICE_BELL = 32;

    [NativeTypeName("#define XCB_INPUT_SET_DEVICE_VALUATORS 33")]
    public const int XCB_INPUT_SET_DEVICE_VALUATORS = 33;

    [NativeTypeName("#define XCB_INPUT_GET_DEVICE_CONTROL 34")]
    public const int XCB_INPUT_GET_DEVICE_CONTROL = 34;

    [NativeTypeName("#define XCB_INPUT_CHANGE_DEVICE_CONTROL 35")]
    public const int XCB_INPUT_CHANGE_DEVICE_CONTROL = 35;

    [NativeTypeName("#define XCB_INPUT_LIST_DEVICE_PROPERTIES 36")]
    public const int XCB_INPUT_LIST_DEVICE_PROPERTIES = 36;

    [NativeTypeName("#define XCB_INPUT_CHANGE_DEVICE_PROPERTY 37")]
    public const int XCB_INPUT_CHANGE_DEVICE_PROPERTY = 37;

    [NativeTypeName("#define XCB_INPUT_DELETE_DEVICE_PROPERTY 38")]
    public const int XCB_INPUT_DELETE_DEVICE_PROPERTY = 38;

    [NativeTypeName("#define XCB_INPUT_GET_DEVICE_PROPERTY 39")]
    public const int XCB_INPUT_GET_DEVICE_PROPERTY = 39;

    [NativeTypeName("#define XCB_INPUT_XI_QUERY_POINTER 40")]
    public const int XCB_INPUT_XI_QUERY_POINTER = 40;

    [NativeTypeName("#define XCB_INPUT_XI_WARP_POINTER 41")]
    public const int XCB_INPUT_XI_WARP_POINTER = 41;

    [NativeTypeName("#define XCB_INPUT_XI_CHANGE_CURSOR 42")]
    public const int XCB_INPUT_XI_CHANGE_CURSOR = 42;

    [NativeTypeName("#define XCB_INPUT_XI_CHANGE_HIERARCHY 43")]
    public const int XCB_INPUT_XI_CHANGE_HIERARCHY = 43;

    [NativeTypeName("#define XCB_INPUT_XI_SET_CLIENT_POINTER 44")]
    public const int XCB_INPUT_XI_SET_CLIENT_POINTER = 44;

    [NativeTypeName("#define XCB_INPUT_XI_GET_CLIENT_POINTER 45")]
    public const int XCB_INPUT_XI_GET_CLIENT_POINTER = 45;

    [NativeTypeName("#define XCB_INPUT_XI_SELECT_EVENTS 46")]
    public const int XCB_INPUT_XI_SELECT_EVENTS = 46;

    [NativeTypeName("#define XCB_INPUT_XI_QUERY_VERSION 47")]
    public const int XCB_INPUT_XI_QUERY_VERSION = 47;

    [NativeTypeName("#define XCB_INPUT_XI_QUERY_DEVICE 48")]
    public const int XCB_INPUT_XI_QUERY_DEVICE = 48;

    [NativeTypeName("#define XCB_INPUT_XI_SET_FOCUS 49")]
    public const int XCB_INPUT_XI_SET_FOCUS = 49;

    [NativeTypeName("#define XCB_INPUT_XI_GET_FOCUS 50")]
    public const int XCB_INPUT_XI_GET_FOCUS = 50;

    [NativeTypeName("#define XCB_INPUT_XI_GRAB_DEVICE 51")]
    public const int XCB_INPUT_XI_GRAB_DEVICE = 51;

    [NativeTypeName("#define XCB_INPUT_XI_UNGRAB_DEVICE 52")]
    public const int XCB_INPUT_XI_UNGRAB_DEVICE = 52;

    [NativeTypeName("#define XCB_INPUT_XI_ALLOW_EVENTS 53")]
    public const int XCB_INPUT_XI_ALLOW_EVENTS = 53;

    [NativeTypeName("#define XCB_INPUT_XI_PASSIVE_GRAB_DEVICE 54")]
    public const int XCB_INPUT_XI_PASSIVE_GRAB_DEVICE = 54;

    [NativeTypeName("#define XCB_INPUT_XI_PASSIVE_UNGRAB_DEVICE 55")]
    public const int XCB_INPUT_XI_PASSIVE_UNGRAB_DEVICE = 55;

    [NativeTypeName("#define XCB_INPUT_XI_LIST_PROPERTIES 56")]
    public const int XCB_INPUT_XI_LIST_PROPERTIES = 56;

    [NativeTypeName("#define XCB_INPUT_XI_CHANGE_PROPERTY 57")]
    public const int XCB_INPUT_XI_CHANGE_PROPERTY = 57;

    [NativeTypeName("#define XCB_INPUT_XI_DELETE_PROPERTY 58")]
    public const int XCB_INPUT_XI_DELETE_PROPERTY = 58;

    [NativeTypeName("#define XCB_INPUT_XI_GET_PROPERTY 59")]
    public const int XCB_INPUT_XI_GET_PROPERTY = 59;

    [NativeTypeName("#define XCB_INPUT_XI_GET_SELECTED_EVENTS 60")]
    public const int XCB_INPUT_XI_GET_SELECTED_EVENTS = 60;

    [NativeTypeName("#define XCB_INPUT_XI_BARRIER_RELEASE_POINTER 61")]
    public const int XCB_INPUT_XI_BARRIER_RELEASE_POINTER = 61;

    [NativeTypeName("#define XCB_INPUT_DEVICE_VALUATOR 0")]
    public const int XCB_INPUT_DEVICE_VALUATOR = 0;

    [NativeTypeName("#define XCB_INPUT_DEVICE_KEY_PRESS 1")]
    public const int XCB_INPUT_DEVICE_KEY_PRESS = 1;

    [NativeTypeName("#define XCB_INPUT_DEVICE_KEY_RELEASE 2")]
    public const int XCB_INPUT_DEVICE_KEY_RELEASE = 2;

    [NativeTypeName("#define XCB_INPUT_DEVICE_BUTTON_PRESS 3")]
    public const int XCB_INPUT_DEVICE_BUTTON_PRESS = 3;

    [NativeTypeName("#define XCB_INPUT_DEVICE_BUTTON_RELEASE 4")]
    public const int XCB_INPUT_DEVICE_BUTTON_RELEASE = 4;

    [NativeTypeName("#define XCB_INPUT_DEVICE_MOTION_NOTIFY 5")]
    public const int XCB_INPUT_DEVICE_MOTION_NOTIFY = 5;

    [NativeTypeName("#define XCB_INPUT_DEVICE_FOCUS_IN 6")]
    public const int XCB_INPUT_DEVICE_FOCUS_IN = 6;

    [NativeTypeName("#define XCB_INPUT_DEVICE_FOCUS_OUT 7")]
    public const int XCB_INPUT_DEVICE_FOCUS_OUT = 7;

    [NativeTypeName("#define XCB_INPUT_PROXIMITY_IN 8")]
    public const int XCB_INPUT_PROXIMITY_IN = 8;

    [NativeTypeName("#define XCB_INPUT_PROXIMITY_OUT 9")]
    public const int XCB_INPUT_PROXIMITY_OUT = 9;

    [NativeTypeName("#define XCB_INPUT_DEVICE_STATE_NOTIFY 10")]
    public const int XCB_INPUT_DEVICE_STATE_NOTIFY = 10;

    [NativeTypeName("#define XCB_INPUT_DEVICE_MAPPING_NOTIFY 11")]
    public const int XCB_INPUT_DEVICE_MAPPING_NOTIFY = 11;

    [NativeTypeName("#define XCB_INPUT_CHANGE_DEVICE_NOTIFY 12")]
    public const int XCB_INPUT_CHANGE_DEVICE_NOTIFY = 12;

    [NativeTypeName("#define XCB_INPUT_DEVICE_KEY_STATE_NOTIFY 13")]
    public const int XCB_INPUT_DEVICE_KEY_STATE_NOTIFY = 13;

    [NativeTypeName("#define XCB_INPUT_DEVICE_BUTTON_STATE_NOTIFY 14")]
    public const int XCB_INPUT_DEVICE_BUTTON_STATE_NOTIFY = 14;

    [NativeTypeName("#define XCB_INPUT_DEVICE_PRESENCE_NOTIFY 15")]
    public const int XCB_INPUT_DEVICE_PRESENCE_NOTIFY = 15;

    [NativeTypeName("#define XCB_INPUT_DEVICE_PROPERTY_NOTIFY 16")]
    public const int XCB_INPUT_DEVICE_PROPERTY_NOTIFY = 16;

    [NativeTypeName("#define XCB_INPUT_DEVICE_CHANGED 1")]
    public const int XCB_INPUT_DEVICE_CHANGED = 1;

    [NativeTypeName("#define XCB_INPUT_KEY_PRESS 2")]
    public const int XCB_INPUT_KEY_PRESS = 2;

    [NativeTypeName("#define XCB_INPUT_KEY_RELEASE 3")]
    public const int XCB_INPUT_KEY_RELEASE = 3;

    [NativeTypeName("#define XCB_INPUT_BUTTON_PRESS 4")]
    public const int XCB_INPUT_BUTTON_PRESS = 4;

    [NativeTypeName("#define XCB_INPUT_BUTTON_RELEASE 5")]
    public const int XCB_INPUT_BUTTON_RELEASE = 5;

    [NativeTypeName("#define XCB_INPUT_MOTION 6")]
    public const int XCB_INPUT_MOTION = 6;

    [NativeTypeName("#define XCB_INPUT_ENTER 7")]
    public const int XCB_INPUT_ENTER = 7;

    [NativeTypeName("#define XCB_INPUT_LEAVE 8")]
    public const int XCB_INPUT_LEAVE = 8;

    [NativeTypeName("#define XCB_INPUT_FOCUS_IN 9")]
    public const int XCB_INPUT_FOCUS_IN = 9;

    [NativeTypeName("#define XCB_INPUT_FOCUS_OUT 10")]
    public const int XCB_INPUT_FOCUS_OUT = 10;

    [NativeTypeName("#define XCB_INPUT_HIERARCHY 11")]
    public const int XCB_INPUT_HIERARCHY = 11;

    [NativeTypeName("#define XCB_INPUT_PROPERTY 12")]
    public const int XCB_INPUT_PROPERTY = 12;

    [NativeTypeName("#define XCB_INPUT_RAW_KEY_PRESS 13")]
    public const int XCB_INPUT_RAW_KEY_PRESS = 13;

    [NativeTypeName("#define XCB_INPUT_RAW_KEY_RELEASE 14")]
    public const int XCB_INPUT_RAW_KEY_RELEASE = 14;

    [NativeTypeName("#define XCB_INPUT_RAW_BUTTON_PRESS 15")]
    public const int XCB_INPUT_RAW_BUTTON_PRESS = 15;

    [NativeTypeName("#define XCB_INPUT_RAW_BUTTON_RELEASE 16")]
    public const int XCB_INPUT_RAW_BUTTON_RELEASE = 16;

    [NativeTypeName("#define XCB_INPUT_RAW_MOTION 17")]
    public const int XCB_INPUT_RAW_MOTION = 17;

    [NativeTypeName("#define XCB_INPUT_TOUCH_BEGIN 18")]
    public const int XCB_INPUT_TOUCH_BEGIN = 18;

    [NativeTypeName("#define XCB_INPUT_TOUCH_UPDATE 19")]
    public const int XCB_INPUT_TOUCH_UPDATE = 19;

    [NativeTypeName("#define XCB_INPUT_TOUCH_END 20")]
    public const int XCB_INPUT_TOUCH_END = 20;

    [NativeTypeName("#define XCB_INPUT_TOUCH_OWNERSHIP 21")]
    public const int XCB_INPUT_TOUCH_OWNERSHIP = 21;

    [NativeTypeName("#define XCB_INPUT_RAW_TOUCH_BEGIN 22")]
    public const int XCB_INPUT_RAW_TOUCH_BEGIN = 22;

    [NativeTypeName("#define XCB_INPUT_RAW_TOUCH_UPDATE 23")]
    public const int XCB_INPUT_RAW_TOUCH_UPDATE = 23;

    [NativeTypeName("#define XCB_INPUT_RAW_TOUCH_END 24")]
    public const int XCB_INPUT_RAW_TOUCH_END = 24;

    [NativeTypeName("#define XCB_INPUT_BARRIER_HIT 25")]
    public const int XCB_INPUT_BARRIER_HIT = 25;

    [NativeTypeName("#define XCB_INPUT_BARRIER_LEAVE 26")]
    public const int XCB_INPUT_BARRIER_LEAVE = 26;

    [NativeTypeName("#define XCB_INPUT_GESTURE_PINCH_BEGIN 27")]
    public const int XCB_INPUT_GESTURE_PINCH_BEGIN = 27;

    [NativeTypeName("#define XCB_INPUT_GESTURE_PINCH_UPDATE 28")]
    public const int XCB_INPUT_GESTURE_PINCH_UPDATE = 28;

    [NativeTypeName("#define XCB_INPUT_GESTURE_PINCH_END 29")]
    public const int XCB_INPUT_GESTURE_PINCH_END = 29;

    [NativeTypeName("#define XCB_INPUT_GESTURE_SWIPE_BEGIN 30")]
    public const int XCB_INPUT_GESTURE_SWIPE_BEGIN = 30;

    [NativeTypeName("#define XCB_INPUT_GESTURE_SWIPE_UPDATE 31")]
    public const int XCB_INPUT_GESTURE_SWIPE_UPDATE = 31;

    [NativeTypeName("#define XCB_INPUT_GESTURE_SWIPE_END 32")]
    public const int XCB_INPUT_GESTURE_SWIPE_END = 32;

    [NativeTypeName("#define XCB_INPUT_SEND_EXTENSION_EVENT 31")]
    public const int XCB_INPUT_SEND_EXTENSION_EVENT = 31;

    [NativeTypeName("#define XCB_INPUT_DEVICE 0")]
    public const int XCB_INPUT_DEVICE = 0;

    [NativeTypeName("#define XCB_INPUT_EVENT 1")]
    public const int XCB_INPUT_EVENT = 1;

    [NativeTypeName("#define XCB_INPUT_MODE 2")]
    public const int XCB_INPUT_MODE = 2;

    [NativeTypeName("#define XCB_INPUT_DEVICE_BUSY 3")]
    public const int XCB_INPUT_DEVICE_BUSY = 3;

    [NativeTypeName("#define XCB_INPUT_CLASS 4")]
    public const int XCB_INPUT_CLASS = 4;
}

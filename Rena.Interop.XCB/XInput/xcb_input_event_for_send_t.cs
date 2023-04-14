using System.Runtime.InteropServices;

namespace Rena.Interop.XCB;

[StructLayout(LayoutKind.Explicit)]
public partial struct xcb_input_event_for_send_t
{
    [FieldOffset(0)]
    public xcb_input_device_valuator_event_t device_valuator;

    [FieldOffset(0)]
    public xcb_input_device_key_press_event_t device_key_press;

    [FieldOffset(0)]
    [NativeTypeName("xcb_input_device_key_release_event_t")]
    public xcb_input_device_key_press_event_t device_key_release;

    [FieldOffset(0)]
    [NativeTypeName("xcb_input_device_button_press_event_t")]
    public xcb_input_device_key_press_event_t device_button_press;

    [FieldOffset(0)]
    [NativeTypeName("xcb_input_device_button_release_event_t")]
    public xcb_input_device_key_press_event_t device_button_release;

    [FieldOffset(0)]
    [NativeTypeName("xcb_input_device_motion_notify_event_t")]
    public xcb_input_device_key_press_event_t device_motion_notify;

    [FieldOffset(0)]
    public xcb_input_device_focus_in_event_t device_focus_in;

    [FieldOffset(0)]
    [NativeTypeName("xcb_input_device_focus_out_event_t")]
    public xcb_input_device_focus_in_event_t device_focus_out;

    [FieldOffset(0)]
    [NativeTypeName("xcb_input_proximity_in_event_t")]
    public xcb_input_device_key_press_event_t proximity_in;

    [FieldOffset(0)]
    [NativeTypeName("xcb_input_proximity_out_event_t")]
    public xcb_input_device_key_press_event_t proximity_out;

    [FieldOffset(0)]
    public xcb_input_device_state_notify_event_t device_state_notify;

    [FieldOffset(0)]
    public xcb_input_device_mapping_notify_event_t device_mapping_notify;

    [FieldOffset(0)]
    public xcb_input_change_device_notify_event_t change_device_notify;

    [FieldOffset(0)]
    public xcb_input_device_key_state_notify_event_t device_key_state_notify;

    [FieldOffset(0)]
    public xcb_input_device_button_state_notify_event_t device_button_state_notify;

    [FieldOffset(0)]
    public xcb_input_device_presence_notify_event_t device_presence_notify;

    [FieldOffset(0)]
    public xcb_raw_generic_event_t event_header;
}

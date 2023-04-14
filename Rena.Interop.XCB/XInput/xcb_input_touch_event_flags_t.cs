namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_touch_event_flags_t : uint
{
    XCB_INPUT_TOUCH_EVENT_FLAGS_TOUCH_PENDING_END = 65536,
    XCB_INPUT_TOUCH_EVENT_FLAGS_TOUCH_EMULATING_POINTER = 131072,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_input_notify_mode_t : uint
{
    XCB_INPUT_NOTIFY_MODE_NORMAL = 0,
    XCB_INPUT_NOTIFY_MODE_GRAB = 1,
    XCB_INPUT_NOTIFY_MODE_UNGRAB = 2,
    XCB_INPUT_NOTIFY_MODE_WHILE_GRABBED = 3,
    XCB_INPUT_NOTIFY_MODE_PASSIVE_GRAB = 4,
    XCB_INPUT_NOTIFY_MODE_PASSIVE_UNGRAB = 5,
}

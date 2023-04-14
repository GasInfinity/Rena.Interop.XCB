namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_notify_mode_t : uint
{
    XCB_NOTIFY_MODE_NORMAL = 0,
    XCB_NOTIFY_MODE_GRAB = 1,
    XCB_NOTIFY_MODE_UNGRAB = 2,
    XCB_NOTIFY_MODE_WHILE_GRABBED = 3,
}

namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_grab_mode_t : uint
{
    XCB_GRAB_MODE_SYNC = 0,
    XCB_GRAB_MODE_ASYNC = 1,
}

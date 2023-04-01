namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_allow_t : uint
{
    XCB_ALLOW_ASYNC_POINTER = 0,
    XCB_ALLOW_SYNC_POINTER = 1,
    XCB_ALLOW_REPLAY_POINTER = 2,
    XCB_ALLOW_ASYNC_KEYBOARD = 3,
    XCB_ALLOW_SYNC_KEYBOARD = 4,
    XCB_ALLOW_REPLAY_KEYBOARD = 5,
    XCB_ALLOW_ASYNC_BOTH = 6,
    XCB_ALLOW_SYNC_BOTH = 7,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_close_down_t : uint
{
    XCB_CLOSE_DOWN_DESTROY_ALL = 0,
    XCB_CLOSE_DOWN_RETAIN_PERMANENT = 1,
    XCB_CLOSE_DOWN_RETAIN_TEMPORARY = 2,
}

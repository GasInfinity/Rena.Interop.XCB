namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_prop_mode_t : uint
{
    XCB_PROP_MODE_REPLACE = 0,
    XCB_PROP_MODE_PREPEND = 1,
    XCB_PROP_MODE_APPEND = 2,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_groups_wrap_t : uint
{
    XCB_XKB_GROUPS_WRAP_WRAP_INTO_RANGE = 0,
    XCB_XKB_GROUPS_WRAP_CLAMP_INTO_RANGE = 64,
    XCB_XKB_GROUPS_WRAP_REDIRECT_INTO_RANGE = 128,
}

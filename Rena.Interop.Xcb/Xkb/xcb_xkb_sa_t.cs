namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_sa_t : uint
{
    XCB_XKB_SA_CLEAR_LOCKS = 1,
    XCB_XKB_SA_LATCH_TO_LOCK = 2,
    XCB_XKB_SA_USE_MOD_MAP_MODS = 4,
    XCB_XKB_SA_GROUP_ABSOLUTE = 4,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_sa_iso_lock_flag_t : uint
{
    XCB_XKB_SA_ISO_LOCK_FLAG_NO_LOCK = 1,
    XCB_XKB_SA_ISO_LOCK_FLAG_NO_UNLOCK = 2,
    XCB_XKB_SA_ISO_LOCK_FLAG_USE_MOD_MAP_MODS = 4,
    XCB_XKB_SA_ISO_LOCK_FLAG_GROUP_ABSOLUTE = 4,
    XCB_XKB_SA_ISO_LOCK_FLAG_ISO_DFLT_IS_GROUP = 8,
}

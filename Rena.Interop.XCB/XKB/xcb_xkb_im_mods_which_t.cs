namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_im_mods_which_t : uint
{
    XCB_XKB_IM_MODS_WHICH_USE_COMPAT = 16,
    XCB_XKB_IM_MODS_WHICH_USE_EFFECTIVE = 8,
    XCB_XKB_IM_MODS_WHICH_USE_LOCKED = 4,
    XCB_XKB_IM_MODS_WHICH_USE_LATCHED = 2,
    XCB_XKB_IM_MODS_WHICH_USE_BASE = 1,
}

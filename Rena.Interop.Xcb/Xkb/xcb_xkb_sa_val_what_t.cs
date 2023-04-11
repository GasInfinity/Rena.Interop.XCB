namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_sa_val_what_t : uint
{
    XCB_XKB_SA_VAL_WHAT_IGNORE_VAL = 0,
    XCB_XKB_SA_VAL_WHAT_SET_VAL_MIN = 1,
    XCB_XKB_SA_VAL_WHAT_SET_VAL_CENTER = 2,
    XCB_XKB_SA_VAL_WHAT_SET_VAL_MAX = 3,
    XCB_XKB_SA_VAL_WHAT_SET_VAL_RELATIVE = 4,
    XCB_XKB_SA_VAL_WHAT_SET_VAL_ABSOLUTE = 5,
}

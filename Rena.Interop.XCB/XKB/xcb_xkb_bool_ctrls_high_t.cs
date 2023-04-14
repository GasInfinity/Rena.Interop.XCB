namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_bool_ctrls_high_t : uint
{
    XCB_XKB_BOOL_CTRLS_HIGH_ACCESS_X_FEEDBACK = 1,
    XCB_XKB_BOOL_CTRLS_HIGH_AUDIBLE_BELL = 2,
    XCB_XKB_BOOL_CTRLS_HIGH_OVERLAY_1 = 4,
    XCB_XKB_BOOL_CTRLS_HIGH_OVERLAY_2 = 8,
    XCB_XKB_BOOL_CTRLS_HIGH_IGNORE_GROUP_LOCK = 16,
}

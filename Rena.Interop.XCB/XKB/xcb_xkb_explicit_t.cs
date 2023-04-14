namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_explicit_t : uint
{
    XCB_XKB_EXPLICIT_V_MOD_MAP = 128,
    XCB_XKB_EXPLICIT_BEHAVIOR = 64,
    XCB_XKB_EXPLICIT_AUTO_REPEAT = 32,
    XCB_XKB_EXPLICIT_INTERPRET = 16,
    XCB_XKB_EXPLICIT_KEY_TYPE_4 = 8,
    XCB_XKB_EXPLICIT_KEY_TYPE_3 = 4,
    XCB_XKB_EXPLICIT_KEY_TYPE_2 = 2,
    XCB_XKB_EXPLICIT_KEY_TYPE_1 = 1,
}

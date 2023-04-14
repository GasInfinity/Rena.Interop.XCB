namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_xi_feature_t : uint
{
    XCB_XKB_XI_FEATURE_KEYBOARDS = 1,
    XCB_XKB_XI_FEATURE_BUTTON_ACTIONS = 2,
    XCB_XKB_XI_FEATURE_INDICATOR_NAMES = 4,
    XCB_XKB_XI_FEATURE_INDICATOR_MAPS = 8,
    XCB_XKB_XI_FEATURE_INDICATOR_STATE = 16,
}

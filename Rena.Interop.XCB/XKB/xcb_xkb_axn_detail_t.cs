namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_axn_detail_t : uint
{
    XCB_XKB_AXN_DETAIL_SK_PRESS = 1,
    XCB_XKB_AXN_DETAIL_SK_ACCEPT = 2,
    XCB_XKB_AXN_DETAIL_SK_REJECT = 4,
    XCB_XKB_AXN_DETAIL_SK_RELEASE = 8,
    XCB_XKB_AXN_DETAIL_BK_ACCEPT = 16,
    XCB_XKB_AXN_DETAIL_BK_REJECT = 32,
    XCB_XKB_AXN_DETAIL_AXK_WARNING = 64,
}

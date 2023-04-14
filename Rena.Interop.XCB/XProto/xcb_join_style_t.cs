namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_join_style_t : uint
{
    XCB_JOIN_STYLE_MITER = 0,
    XCB_JOIN_STYLE_ROUND = 1,
    XCB_JOIN_STYLE_BEVEL = 2,
}

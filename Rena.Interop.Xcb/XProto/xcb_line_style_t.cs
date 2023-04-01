namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_line_style_t : uint
{
    XCB_LINE_STYLE_SOLID = 0,
    XCB_LINE_STYLE_ON_OFF_DASH = 1,
    XCB_LINE_STYLE_DOUBLE_DASH = 2,
}

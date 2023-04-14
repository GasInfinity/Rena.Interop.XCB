namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_fill_style_t : uint
{
    XCB_FILL_STYLE_SOLID = 0,
    XCB_FILL_STYLE_TILED = 1,
    XCB_FILL_STYLE_STIPPLED = 2,
    XCB_FILL_STYLE_OPAQUE_STIPPLED = 3,
}

namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_render_sub_pixel_t : uint
{
    XCB_RENDER_SUB_PIXEL_UNKNOWN = 0,
    XCB_RENDER_SUB_PIXEL_HORIZONTAL_RGB = 1,
    XCB_RENDER_SUB_PIXEL_HORIZONTAL_BGR = 2,
    XCB_RENDER_SUB_PIXEL_VERTICAL_RGB = 3,
    XCB_RENDER_SUB_PIXEL_VERTICAL_BGR = 4,
    XCB_RENDER_SUB_PIXEL_NONE = 5,
}

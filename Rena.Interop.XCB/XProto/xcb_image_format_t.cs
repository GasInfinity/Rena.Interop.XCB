namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_image_format_t : uint
{
    XCB_IMAGE_FORMAT_XY_BITMAP = 0,
    XCB_IMAGE_FORMAT_XY_PIXMAP = 1,
    XCB_IMAGE_FORMAT_Z_PIXMAP = 2,
}

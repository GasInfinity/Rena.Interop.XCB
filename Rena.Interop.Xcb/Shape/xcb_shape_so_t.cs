namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_shape_so_t : uint
{
    XCB_SHAPE_SO_SET = 0,
    XCB_SHAPE_SO_UNION = 1,
    XCB_SHAPE_SO_INTERSECT = 2,
    XCB_SHAPE_SO_SUBTRACT = 3,
    XCB_SHAPE_SO_INVERT = 4,
}

namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_poly_shape_t : uint
{
    XCB_POLY_SHAPE_COMPLEX = 0,
    XCB_POLY_SHAPE_NONCONVEX = 1,
    XCB_POLY_SHAPE_CONVEX = 2,
}

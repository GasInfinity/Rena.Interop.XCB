namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_query_shape_of_t : uint
{
    XCB_QUERY_SHAPE_OF_LARGEST_CURSOR = 0,
    XCB_QUERY_SHAPE_OF_FASTEST_TILE = 1,
    XCB_QUERY_SHAPE_OF_FASTEST_STIPPLE = 2,
}

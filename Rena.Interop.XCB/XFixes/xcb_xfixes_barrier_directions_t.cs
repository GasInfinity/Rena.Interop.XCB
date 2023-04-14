namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xfixes_barrier_directions_t : uint
{
    XCB_XFIXES_BARRIER_DIRECTIONS_POSITIVE_X = 1,
    XCB_XFIXES_BARRIER_DIRECTIONS_POSITIVE_Y = 2,
    XCB_XFIXES_BARRIER_DIRECTIONS_NEGATIVE_X = 4,
    XCB_XFIXES_BARRIER_DIRECTIONS_NEGATIVE_Y = 8,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_visibility_t : uint
{
    XCB_VISIBILITY_UNOBSCURED = 0,
    XCB_VISIBILITY_PARTIALLY_OBSCURED = 1,
    XCB_VISIBILITY_FULLY_OBSCURED = 2,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_exposures_t : uint
{
    XCB_EXPOSURES_NOT_ALLOWED = 0,
    XCB_EXPOSURES_ALLOWED = 1,
    XCB_EXPOSURES_DEFAULT = 2,
}

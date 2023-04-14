namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_blanking_t : uint
{
    XCB_BLANKING_NOT_PREFERRED = 0,
    XCB_BLANKING_PREFERRED = 1,
    XCB_BLANKING_DEFAULT = 2,
}

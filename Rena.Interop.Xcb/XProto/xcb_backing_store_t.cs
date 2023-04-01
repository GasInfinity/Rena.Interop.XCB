namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_backing_store_t : uint
{
    XCB_BACKING_STORE_NOT_USEFUL = 0,
    XCB_BACKING_STORE_WHEN_MAPPED = 1,
    XCB_BACKING_STORE_ALWAYS = 2,
}

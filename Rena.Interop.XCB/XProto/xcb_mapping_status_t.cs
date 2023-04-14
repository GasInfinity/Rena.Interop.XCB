namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_mapping_status_t : uint
{
    XCB_MAPPING_STATUS_SUCCESS = 0,
    XCB_MAPPING_STATUS_BUSY = 1,
    XCB_MAPPING_STATUS_FAILURE = 2,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_randr_notify_t : uint
{
    XCB_RANDR_NOTIFY_CRTC_CHANGE = 0,
    XCB_RANDR_NOTIFY_OUTPUT_CHANGE = 1,
    XCB_RANDR_NOTIFY_OUTPUT_PROPERTY = 2,
    XCB_RANDR_NOTIFY_PROVIDER_CHANGE = 3,
    XCB_RANDR_NOTIFY_PROVIDER_PROPERTY = 4,
    XCB_RANDR_NOTIFY_RESOURCE_CHANGE = 5,
    XCB_RANDR_NOTIFY_LEASE = 6,
}
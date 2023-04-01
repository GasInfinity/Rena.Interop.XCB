namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_randr_connection_t : uint
{
    XCB_RANDR_CONNECTION_CONNECTED = 0,
    XCB_RANDR_CONNECTION_DISCONNECTED = 1,
    XCB_RANDR_CONNECTION_UNKNOWN = 2,
}

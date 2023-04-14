namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_resource_change_t
{
    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad0[20];
}

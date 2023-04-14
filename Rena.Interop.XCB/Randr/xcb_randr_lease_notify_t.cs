namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_lease_notify_t
{
    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_randr_lease_t")]
    public uint lease;

    [NativeTypeName("uint8_t")]
    public byte created;

    [NativeTypeName("uint8_t[15]")]
    public fixed byte pad0[15];
}

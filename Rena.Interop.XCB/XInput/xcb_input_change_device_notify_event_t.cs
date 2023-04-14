namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_change_device_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint8_t")]
    public byte request;

    [NativeTypeName("uint8_t[23]")]
    public fixed byte pad0[23];
}

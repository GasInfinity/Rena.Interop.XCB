namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_get_device_motion_events_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte xi_reply_type;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint32_t")]
    public uint num_events;

    [NativeTypeName("uint8_t")]
    public byte num_axes;

    [NativeTypeName("uint8_t")]
    public byte device_mode;

    [NativeTypeName("uint8_t[18]")]
    public fixed byte pad0[18];
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_device_property_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte state;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("uint8_t[19]")]
    public fixed byte pad0[19];

    [NativeTypeName("uint8_t")]
    public byte device_id;
}

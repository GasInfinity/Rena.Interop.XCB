namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_property_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte extension;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort event_type;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("uint8_t")]
    public byte what;

    [NativeTypeName("uint8_t[11]")]
    public fixed byte pad0[11];

    [NativeTypeName("uint32_t")]
    public uint full_sequence;
}

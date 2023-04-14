namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_hierarchy_event_t
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

    [NativeTypeName("uint32_t")]
    public uint flags;

    [NativeTypeName("uint16_t")]
    public ushort num_infos;

    [NativeTypeName("uint8_t[10]")]
    public fixed byte pad0[10];

    [NativeTypeName("uint32_t")]
    public uint full_sequence;
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_indicator_map_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte xkbType;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];

    [NativeTypeName("uint32_t")]
    public uint state;

    [NativeTypeName("uint32_t")]
    public uint mapChanged;

    [NativeTypeName("uint8_t[12]")]
    public fixed byte pad1[12];
}

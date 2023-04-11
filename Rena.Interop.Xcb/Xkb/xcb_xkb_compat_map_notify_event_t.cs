namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_compat_map_notify_event_t
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

    [NativeTypeName("uint8_t")]
    public byte changedGroups;

    [NativeTypeName("uint16_t")]
    public ushort firstSI;

    [NativeTypeName("uint16_t")]
    public ushort nSI;

    [NativeTypeName("uint16_t")]
    public ushort nTotalSI;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte pad0[16];
}

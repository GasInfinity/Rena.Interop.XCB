namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_bell_notify_event_t
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
    public byte bellClass;

    [NativeTypeName("uint8_t")]
    public byte bellID;

    [NativeTypeName("uint8_t")]
    public byte percent;

    [NativeTypeName("uint16_t")]
    public ushort pitch;

    [NativeTypeName("uint16_t")]
    public ushort duration;

    [NativeTypeName("xcb_atom_t")]
    public uint name;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint8_t")]
    public byte eventOnly;

    [NativeTypeName("uint8_t[7]")]
    public fixed byte pad0[7];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_access_x_notify_event_t
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

    [NativeTypeName("xcb_keycode_t")]
    public byte keycode;

    [NativeTypeName("uint16_t")]
    public ushort detailt;

    [NativeTypeName("uint16_t")]
    public ushort slowKeysDelay;

    [NativeTypeName("uint16_t")]
    public ushort debounceDelay;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte pad0[16];
}

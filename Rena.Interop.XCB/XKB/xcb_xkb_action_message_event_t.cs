namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_action_message_event_t
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

    [NativeTypeName("uint8_t")]
    public byte press;

    [NativeTypeName("uint8_t")]
    public byte keyEventFollows;

    [NativeTypeName("uint8_t")]
    public byte mods;

    [NativeTypeName("uint8_t")]
    public byte group;

    [NativeTypeName("xcb_xkb_string8_t[8]")]
    public fixed sbyte message[8];

    [NativeTypeName("uint8_t[10]")]
    public fixed byte pad0[10];
}

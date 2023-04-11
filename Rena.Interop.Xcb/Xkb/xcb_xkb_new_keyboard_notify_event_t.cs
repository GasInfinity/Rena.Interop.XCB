namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_new_keyboard_notify_event_t
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
    public byte oldDeviceID;

    [NativeTypeName("xcb_keycode_t")]
    public byte minKeyCode;

    [NativeTypeName("xcb_keycode_t")]
    public byte maxKeyCode;

    [NativeTypeName("xcb_keycode_t")]
    public byte oldMinKeyCode;

    [NativeTypeName("xcb_keycode_t")]
    public byte oldMaxKeyCode;

    [NativeTypeName("uint8_t")]
    public byte requestMajor;

    [NativeTypeName("uint8_t")]
    public byte requestMinor;

    [NativeTypeName("uint16_t")]
    public ushort changed;

    [NativeTypeName("uint8_t[14]")]
    public fixed byte pad0[14];
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_get_kbd_by_name_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_keycode_t")]
    public byte minKeyCode;

    [NativeTypeName("xcb_keycode_t")]
    public byte maxKeyCode;

    [NativeTypeName("uint8_t")]
    public byte loaded;

    [NativeTypeName("uint8_t")]
    public byte newKeyboard;

    [NativeTypeName("uint16_t")]
    public ushort found;

    [NativeTypeName("uint16_t")]
    public ushort reported;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte pad0[16];
}

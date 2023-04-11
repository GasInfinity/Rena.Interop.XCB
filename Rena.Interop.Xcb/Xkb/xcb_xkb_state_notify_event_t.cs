namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_state_notify_event_t
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
    public byte mods;

    [NativeTypeName("uint8_t")]
    public byte baseMods;

    [NativeTypeName("uint8_t")]
    public byte latchedMods;

    [NativeTypeName("uint8_t")]
    public byte lockedMods;

    [NativeTypeName("uint8_t")]
    public byte group;

    [NativeTypeName("int16_t")]
    public short baseGroup;

    [NativeTypeName("int16_t")]
    public short latchedGroup;

    [NativeTypeName("uint8_t")]
    public byte lockedGroup;

    [NativeTypeName("uint8_t")]
    public byte compatState;

    [NativeTypeName("uint8_t")]
    public byte grabMods;

    [NativeTypeName("uint8_t")]
    public byte compatGrabMods;

    [NativeTypeName("uint8_t")]
    public byte lookupMods;

    [NativeTypeName("uint8_t")]
    public byte compatLoockupMods;

    [NativeTypeName("uint16_t")]
    public ushort ptrBtnState;

    [NativeTypeName("uint16_t")]
    public ushort changed;

    [NativeTypeName("xcb_keycode_t")]
    public byte keycode;

    [NativeTypeName("uint8_t")]
    public byte eventType;

    [NativeTypeName("uint8_t")]
    public byte requestMajor;

    [NativeTypeName("uint8_t")]
    public byte requestMinor;
}

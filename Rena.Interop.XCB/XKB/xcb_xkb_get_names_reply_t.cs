namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_get_names_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint32_t")]
    public uint which;

    [NativeTypeName("xcb_keycode_t")]
    public byte minKeyCode;

    [NativeTypeName("xcb_keycode_t")]
    public byte maxKeyCode;

    [NativeTypeName("uint8_t")]
    public byte nTypes;

    [NativeTypeName("uint8_t")]
    public byte groupNames;

    [NativeTypeName("uint16_t")]
    public ushort virtualMods;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKey;

    [NativeTypeName("uint8_t")]
    public byte nKeys;

    [NativeTypeName("uint32_t")]
    public uint indicators;

    [NativeTypeName("uint8_t")]
    public byte nRadioGroups;

    [NativeTypeName("uint8_t")]
    public byte nKeyAliases;

    [NativeTypeName("uint16_t")]
    public ushort nKTLevels;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad0[4];
}

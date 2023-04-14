namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_get_map_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("xcb_keycode_t")]
    public byte minKeyCode;

    [NativeTypeName("xcb_keycode_t")]
    public byte maxKeyCode;

    [NativeTypeName("uint16_t")]
    public ushort present;

    [NativeTypeName("uint8_t")]
    public byte firstType;

    [NativeTypeName("uint8_t")]
    public byte nTypes;

    [NativeTypeName("uint8_t")]
    public byte totalTypes;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeySym;

    [NativeTypeName("uint16_t")]
    public ushort totalSyms;

    [NativeTypeName("uint8_t")]
    public byte nKeySyms;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyAction;

    [NativeTypeName("uint16_t")]
    public ushort totalActions;

    [NativeTypeName("uint8_t")]
    public byte nKeyActions;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyBehavior;

    [NativeTypeName("uint8_t")]
    public byte nKeyBehaviors;

    [NativeTypeName("uint8_t")]
    public byte totalKeyBehaviors;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyExplicit;

    [NativeTypeName("uint8_t")]
    public byte nKeyExplicit;

    [NativeTypeName("uint8_t")]
    public byte totalKeyExplicit;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstModMapKey;

    [NativeTypeName("uint8_t")]
    public byte nModMapKeys;

    [NativeTypeName("uint8_t")]
    public byte totalModMapKeys;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstVModMapKey;

    [NativeTypeName("uint8_t")]
    public byte nVModMapKeys;

    [NativeTypeName("uint8_t")]
    public byte totalVModMapKeys;

    [NativeTypeName("uint8_t")]
    public byte pad1;

    [NativeTypeName("uint16_t")]
    public ushort virtualMods;
}

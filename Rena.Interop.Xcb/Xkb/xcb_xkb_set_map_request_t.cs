namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_set_map_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("uint16_t")]
    public ushort present;

    [NativeTypeName("uint16_t")]
    public ushort flags;

    [NativeTypeName("xcb_keycode_t")]
    public byte minKeyCode;

    [NativeTypeName("xcb_keycode_t")]
    public byte maxKeyCode;

    [NativeTypeName("uint8_t")]
    public byte firstType;

    [NativeTypeName("uint8_t")]
    public byte nTypes;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeySym;

    [NativeTypeName("uint8_t")]
    public byte nKeySyms;

    [NativeTypeName("uint16_t")]
    public ushort totalSyms;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyAction;

    [NativeTypeName("uint8_t")]
    public byte nKeyActions;

    [NativeTypeName("uint16_t")]
    public ushort totalActions;

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

    [NativeTypeName("uint16_t")]
    public ushort virtualMods;
}

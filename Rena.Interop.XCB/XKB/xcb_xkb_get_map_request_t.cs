namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_get_map_request_t
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
    public ushort full;

    [NativeTypeName("uint16_t")]
    public ushort partial;

    [NativeTypeName("uint8_t")]
    public byte firstType;

    [NativeTypeName("uint8_t")]
    public byte nTypes;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeySym;

    [NativeTypeName("uint8_t")]
    public byte nKeySyms;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyAction;

    [NativeTypeName("uint8_t")]
    public byte nKeyActions;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyBehavior;

    [NativeTypeName("uint8_t")]
    public byte nKeyBehaviors;

    [NativeTypeName("uint16_t")]
    public ushort virtualMods;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyExplicit;

    [NativeTypeName("uint8_t")]
    public byte nKeyExplicit;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstModMapKey;

    [NativeTypeName("uint8_t")]
    public byte nModMapKeys;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstVModMapKey;

    [NativeTypeName("uint8_t")]
    public byte nVModMapKeys;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

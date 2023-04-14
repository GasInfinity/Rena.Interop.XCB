namespace Rena.Interop.XCB;

public partial struct xcb_xkb_set_names_request_t
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
    public ushort virtualMods;

    [NativeTypeName("uint32_t")]
    public uint which;

    [NativeTypeName("uint8_t")]
    public byte firstType;

    [NativeTypeName("uint8_t")]
    public byte nTypes;

    [NativeTypeName("uint8_t")]
    public byte firstKTLevelt;

    [NativeTypeName("uint8_t")]
    public byte nKTLevels;

    [NativeTypeName("uint32_t")]
    public uint indicators;

    [NativeTypeName("uint8_t")]
    public byte groupNames;

    [NativeTypeName("uint8_t")]
    public byte nRadioGroups;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKey;

    [NativeTypeName("uint8_t")]
    public byte nKeys;

    [NativeTypeName("uint8_t")]
    public byte nKeyAliases;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort totalKTLevelNames;
}

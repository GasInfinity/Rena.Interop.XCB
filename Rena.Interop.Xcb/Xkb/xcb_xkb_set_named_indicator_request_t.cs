namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_set_named_indicator_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("xcb_xkb_led_class_spec_t")]
    public ushort ledClass;

    [NativeTypeName("xcb_xkb_id_spec_t")]
    public ushort ledID;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("xcb_atom_t")]
    public uint indicator;

    [NativeTypeName("uint8_t")]
    public byte setState;

    [NativeTypeName("uint8_t")]
    public byte on;

    [NativeTypeName("uint8_t")]
    public byte setMap;

    [NativeTypeName("uint8_t")]
    public byte createMap;

    [NativeTypeName("uint8_t")]
    public byte pad1;

    [NativeTypeName("uint8_t")]
    public byte map_flags;

    [NativeTypeName("uint8_t")]
    public byte map_whichGroups;

    [NativeTypeName("uint8_t")]
    public byte map_groups;

    [NativeTypeName("uint8_t")]
    public byte map_whichMods;

    [NativeTypeName("uint8_t")]
    public byte map_realMods;

    [NativeTypeName("uint16_t")]
    public ushort map_vmods;

    [NativeTypeName("uint32_t")]
    public uint map_ctrls;
}

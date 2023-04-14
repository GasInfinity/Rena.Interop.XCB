namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_get_named_indicator_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_atom_t")]
    public uint indicator;

    [NativeTypeName("uint8_t")]
    public byte found;

    [NativeTypeName("uint8_t")]
    public byte on;

    [NativeTypeName("uint8_t")]
    public byte realIndicator;

    [NativeTypeName("uint8_t")]
    public byte ndx;

    [NativeTypeName("uint8_t")]
    public byte map_flags;

    [NativeTypeName("uint8_t")]
    public byte map_whichGroups;

    [NativeTypeName("uint8_t")]
    public byte map_groups;

    [NativeTypeName("uint8_t")]
    public byte map_whichMods;

    [NativeTypeName("uint8_t")]
    public byte map_mods;

    [NativeTypeName("uint8_t")]
    public byte map_realMods;

    [NativeTypeName("uint16_t")]
    public ushort map_vmod;

    [NativeTypeName("uint32_t")]
    public uint map_ctrls;

    [NativeTypeName("uint8_t")]
    public byte supported;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

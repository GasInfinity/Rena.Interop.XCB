namespace Rena.Interop.XCB;

public partial struct xcb_xkb_indicator_map_t
{
    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint8_t")]
    public byte whichGroups;

    [NativeTypeName("uint8_t")]
    public byte groups;

    [NativeTypeName("uint8_t")]
    public byte whichMods;

    [NativeTypeName("uint8_t")]
    public byte mods;

    [NativeTypeName("uint8_t")]
    public byte realMods;

    [NativeTypeName("uint16_t")]
    public ushort vmods;

    [NativeTypeName("uint32_t")]
    public uint ctrls;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_kt_map_entry_t
{
    [NativeTypeName("uint8_t")]
    public byte active;

    [NativeTypeName("uint8_t")]
    public byte mods_mask;

    [NativeTypeName("uint8_t")]
    public byte level;

    [NativeTypeName("uint8_t")]
    public byte mods_mods;

    [NativeTypeName("uint16_t")]
    public ushort mods_vmods;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

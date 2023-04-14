namespace Rena.Interop.XCB;

public partial struct xcb_xkb_key_type_t
{
    [NativeTypeName("uint8_t")]
    public byte mods_mask;

    [NativeTypeName("uint8_t")]
    public byte mods_mods;

    [NativeTypeName("uint16_t")]
    public ushort mods_vmods;

    [NativeTypeName("uint8_t")]
    public byte numLevels;

    [NativeTypeName("uint8_t")]
    public byte nMapEntries;

    [NativeTypeName("uint8_t")]
    public byte hasPreserve;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

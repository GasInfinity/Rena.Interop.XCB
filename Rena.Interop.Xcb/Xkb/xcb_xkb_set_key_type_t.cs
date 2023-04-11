namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_set_key_type_t
{
    [NativeTypeName("uint8_t")]
    public byte mask;

    [NativeTypeName("uint8_t")]
    public byte realMods;

    [NativeTypeName("uint16_t")]
    public ushort virtualMods;

    [NativeTypeName("uint8_t")]
    public byte numLevels;

    [NativeTypeName("uint8_t")]
    public byte nMapEntries;

    [NativeTypeName("uint8_t")]
    public byte preserve;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

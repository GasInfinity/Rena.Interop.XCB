namespace Rena.Interop.XCB;

public partial struct xcb_xkb_mod_def_t
{
    [NativeTypeName("uint8_t")]
    public byte mask;

    [NativeTypeName("uint8_t")]
    public byte realMods;

    [NativeTypeName("uint16_t")]
    public ushort vmods;
}

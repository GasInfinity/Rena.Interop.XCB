namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_kt_set_map_entry_t
{
    [NativeTypeName("uint8_t")]
    public byte level;

    [NativeTypeName("uint8_t")]
    public byte realMods;

    [NativeTypeName("uint16_t")]
    public ushort virtualMods;
}

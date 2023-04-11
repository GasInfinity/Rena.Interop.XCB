namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_listing_t
{
    [NativeTypeName("uint16_t")]
    public ushort flags;

    [NativeTypeName("uint16_t")]
    public ushort length;
}

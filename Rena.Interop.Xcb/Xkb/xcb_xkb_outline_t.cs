namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_outline_t
{
    [NativeTypeName("uint8_t")]
    public byte nPoints;

    [NativeTypeName("uint8_t")]
    public byte cornerRadius;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

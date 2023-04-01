namespace Rena.Interop.Xcb;

public partial struct xcb_point_t
{
    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;
}

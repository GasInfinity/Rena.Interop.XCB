namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_shape_t
{
    [NativeTypeName("xcb_atom_t")]
    public uint name;

    [NativeTypeName("uint8_t")]
    public byte nOutlines;

    [NativeTypeName("uint8_t")]
    public byte primaryNdx;

    [NativeTypeName("uint8_t")]
    public byte approxNdx;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

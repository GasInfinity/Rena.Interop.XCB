namespace Rena.Interop.Xcb;

public partial struct xcb_fontprop_t
{
    [NativeTypeName("xcb_atom_t")]
    public uint name;

    [NativeTypeName("uint32_t")]
    public uint value;
}

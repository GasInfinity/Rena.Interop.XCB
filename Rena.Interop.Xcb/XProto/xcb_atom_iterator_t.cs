namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_atom_iterator_t
{
    [NativeTypeName("xcb_atom_t *")]
    public uint* data;

    public int rem;

    public int index;
}

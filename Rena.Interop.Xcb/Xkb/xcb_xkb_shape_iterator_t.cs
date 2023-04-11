namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_shape_iterator_t
{
    public xcb_xkb_shape_t* data;

    public int rem;

    public int index;
}

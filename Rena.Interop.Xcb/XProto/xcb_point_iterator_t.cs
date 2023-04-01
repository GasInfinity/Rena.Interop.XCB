namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_point_iterator_t
{
    public xcb_point_t* data;

    public int rem;

    public int index;
}

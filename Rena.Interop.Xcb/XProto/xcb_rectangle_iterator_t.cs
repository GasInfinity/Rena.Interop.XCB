namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_rectangle_iterator_t
{
    public xcb_rectangle_t* data;

    public int rem;

    public int index;
}

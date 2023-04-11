namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_row_iterator_t
{
    public xcb_xkb_row_t* data;

    public int rem;

    public int index;
}

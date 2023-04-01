namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_visualtype_iterator_t
{
    public xcb_visualtype_t* data;

    public int rem;

    public int index;
}

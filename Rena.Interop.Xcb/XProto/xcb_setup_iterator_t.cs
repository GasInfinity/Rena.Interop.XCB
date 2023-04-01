namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_setup_iterator_t
{
    public xcb_setup_t* data;

    public int rem;

    public int index;
}

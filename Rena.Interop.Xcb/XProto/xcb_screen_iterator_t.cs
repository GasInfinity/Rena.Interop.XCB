namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_screen_iterator_t
{
    public xcb_screen_t* data;

    public int rem;

    public int index;
}

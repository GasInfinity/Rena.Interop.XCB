namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_rgb_iterator_t
{
    public xcb_rgb_t* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_depth_iterator_t
{
    public xcb_depth_t* data;

    public int rem;

    public int index;
}

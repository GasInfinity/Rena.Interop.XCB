namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_transform_iterator_t
{
    public xcb_render_transform_t* data;

    public int rem;

    public int index;
}

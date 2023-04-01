namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_triangle_iterator_t
{
    public xcb_render_triangle_t* data;

    public int rem;

    public int index;
}

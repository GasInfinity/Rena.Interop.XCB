namespace Rena.Interop.XCB;

public unsafe partial struct xcb_render_glyphinfo_iterator_t
{
    public xcb_render_glyphinfo_t* data;

    public int rem;

    public int index;
}

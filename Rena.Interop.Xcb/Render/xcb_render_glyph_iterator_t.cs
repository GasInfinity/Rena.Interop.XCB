namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_glyph_iterator_t
{
    [NativeTypeName("xcb_render_glyph_t *")]
    public uint* data;

    public int rem;

    public int index;
}

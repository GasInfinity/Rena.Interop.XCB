namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_glyphset_iterator_t
{
    [NativeTypeName("xcb_render_glyphset_t *")]
    public uint* data;

    public int rem;

    public int index;
}

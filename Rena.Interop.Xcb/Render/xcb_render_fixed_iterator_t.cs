namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_fixed_iterator_t
{
    [NativeTypeName("xcb_render_fixed_t *")]
    public int* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_render_pictformat_iterator_t
{
    [NativeTypeName("xcb_render_pictformat_t *")]
    public uint* data;

    public int rem;

    public int index;
}

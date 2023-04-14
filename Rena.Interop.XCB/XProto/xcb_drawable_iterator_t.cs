namespace Rena.Interop.XCB;

public unsafe partial struct xcb_drawable_iterator_t
{
    [NativeTypeName("xcb_drawable_t *")]
    public uint* data;

    public int rem;

    public int index;
}

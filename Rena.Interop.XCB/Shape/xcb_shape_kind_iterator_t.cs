namespace Rena.Interop.XCB;

public unsafe partial struct xcb_shape_kind_iterator_t
{
    [NativeTypeName("xcb_shape_kind_t *")]
    public byte* data;

    public int rem;

    public int index;
}

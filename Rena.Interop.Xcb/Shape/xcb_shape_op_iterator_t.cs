namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_shape_op_iterator_t
{
    [NativeTypeName("xcb_shape_op_t *")]
    public byte* data;

    public int rem;

    public int index;
}

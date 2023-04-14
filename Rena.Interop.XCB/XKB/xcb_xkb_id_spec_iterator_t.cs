namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_id_spec_iterator_t
{
    [NativeTypeName("xcb_xkb_id_spec_t *")]
    public ushort* data;

    public int rem;

    public int index;
}

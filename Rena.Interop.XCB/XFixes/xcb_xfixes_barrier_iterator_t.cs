namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xfixes_barrier_iterator_t
{
    [NativeTypeName("xcb_xfixes_barrier_t *")]
    public uint* data;

    public int rem;

    public int index;
}

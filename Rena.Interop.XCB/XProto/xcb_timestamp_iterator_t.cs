namespace Rena.Interop.XCB;

public unsafe partial struct xcb_timestamp_iterator_t
{
    [NativeTypeName("xcb_timestamp_t *")]
    public uint* data;

    public int rem;

    public int index;
}

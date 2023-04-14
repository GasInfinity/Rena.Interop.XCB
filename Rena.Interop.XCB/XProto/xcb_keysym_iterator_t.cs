namespace Rena.Interop.XCB;

public unsafe partial struct xcb_keysym_iterator_t
{
    [NativeTypeName("xcb_keysym_t *")]
    public uint* data;

    public int rem;

    public int index;
}

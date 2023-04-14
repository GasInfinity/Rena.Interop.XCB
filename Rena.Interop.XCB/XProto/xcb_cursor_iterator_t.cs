namespace Rena.Interop.XCB;

public unsafe partial struct xcb_cursor_iterator_t
{
    [NativeTypeName("xcb_cursor_t *")]
    public uint* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_fontable_iterator_t
{
    [NativeTypeName("xcb_fontable_t *")]
    public uint* data;

    public int rem;

    public int index;
}

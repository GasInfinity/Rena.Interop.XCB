namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_window_iterator_t
{
    [NativeTypeName("xcb_window_t *")]
    public uint* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_visualid_iterator_t
{
    [NativeTypeName("xcb_visualid_t *")]
    public uint* data;

    public int rem;

    public int index;
}

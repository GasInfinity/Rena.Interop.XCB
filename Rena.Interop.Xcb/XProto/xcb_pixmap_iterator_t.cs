namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_pixmap_iterator_t
{
    [NativeTypeName("xcb_pixmap_t *")]
    public uint* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_font_iterator_t
{
    [NativeTypeName("xcb_font_t *")]
    public uint* data;

    public int rem;

    public int index;
}

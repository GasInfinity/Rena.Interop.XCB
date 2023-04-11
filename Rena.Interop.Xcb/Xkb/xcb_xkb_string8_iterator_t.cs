namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_string8_iterator_t
{
    [NativeTypeName("xcb_xkb_string8_t *")]
    public sbyte* data;

    public int rem;

    public int index;
}

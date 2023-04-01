namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_gcontext_iterator_t
{
    [NativeTypeName("xcb_gcontext_t *")]
    public uint* data;

    public int rem;

    public int index;
}

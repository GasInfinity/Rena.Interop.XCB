namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_device_spec_iterator_t
{
    [NativeTypeName("xcb_xkb_device_spec_t *")]
    public ushort* data;

    public int rem;

    public int index;
}

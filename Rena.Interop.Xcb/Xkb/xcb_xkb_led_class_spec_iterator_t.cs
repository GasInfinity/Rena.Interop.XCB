namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_led_class_spec_iterator_t
{
    [NativeTypeName("xcb_xkb_led_class_spec_t *")]
    public ushort* data;

    public int rem;

    public int index;
}

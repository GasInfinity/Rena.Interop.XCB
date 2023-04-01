namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_event_class_iterator_t
{
    [NativeTypeName("xcb_input_event_class_t *")]
    public uint* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_event_type_base_iterator_t
{
    [NativeTypeName("xcb_input_event_type_base_t *")]
    public byte* data;

    public int rem;

    public int index;
}

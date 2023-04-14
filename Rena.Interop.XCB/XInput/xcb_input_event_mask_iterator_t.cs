namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_event_mask_iterator_t
{
    public xcb_input_event_mask_t* data;

    public int rem;

    public int index;
}

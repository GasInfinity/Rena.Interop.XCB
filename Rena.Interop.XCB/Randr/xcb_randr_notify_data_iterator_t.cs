namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_notify_data_iterator_t
{
    public xcb_randr_notify_data_t* data;

    public int rem;

    public int index;
}

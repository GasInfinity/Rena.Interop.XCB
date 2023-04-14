namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_resource_change_iterator_t
{
    public xcb_randr_resource_change_t* data;

    public int rem;

    public int index;
}

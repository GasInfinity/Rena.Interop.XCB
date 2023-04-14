namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_provider_property_iterator_t
{
    public xcb_randr_provider_property_t* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_output_property_iterator_t
{
    public xcb_randr_output_property_t* data;

    public int rem;

    public int index;
}

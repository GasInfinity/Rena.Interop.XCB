namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_provider_change_iterator_t
{
    public xcb_randr_provider_change_t* data;

    public int rem;

    public int index;
}

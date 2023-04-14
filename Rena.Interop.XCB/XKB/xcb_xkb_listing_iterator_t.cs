namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_listing_iterator_t
{
    public xcb_xkb_listing_t* data;

    public int rem;

    public int index;
}

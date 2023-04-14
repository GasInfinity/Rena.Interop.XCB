namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_key_iterator_t
{
    public xcb_xkb_key_t* data;

    public int rem;

    public int index;
}

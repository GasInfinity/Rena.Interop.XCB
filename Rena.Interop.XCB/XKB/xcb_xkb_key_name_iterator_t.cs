namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_key_name_iterator_t
{
    public xcb_xkb_key_name_t* data;

    public int rem;

    public int index;
}

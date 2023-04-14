namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_overlay_key_iterator_t
{
    public xcb_xkb_overlay_key_t* data;

    public int rem;

    public int index;
}

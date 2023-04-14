namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_overlay_row_iterator_t
{
    public xcb_xkb_overlay_row_t* data;

    public int rem;

    public int index;
}

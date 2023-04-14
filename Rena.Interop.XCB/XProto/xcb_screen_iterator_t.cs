namespace Rena.Interop.XCB;

public unsafe partial struct xcb_screen_iterator_t
{
    public xcb_screen_t* data;

    public int rem;

    public int index;
}

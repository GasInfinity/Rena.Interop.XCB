namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_action_iterator_t
{
    public xcb_xkb_action_t* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_timecoord_iterator_t
{
    public xcb_timecoord_t* data;

    public int rem;

    public int index;
}

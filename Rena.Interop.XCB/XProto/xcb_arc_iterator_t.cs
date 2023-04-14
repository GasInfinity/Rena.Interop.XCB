namespace Rena.Interop.XCB;

public unsafe partial struct xcb_arc_iterator_t
{
    public xcb_arc_t* data;

    public int rem;

    public int index;
}

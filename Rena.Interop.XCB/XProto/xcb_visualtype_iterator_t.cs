namespace Rena.Interop.XCB;

public unsafe partial struct xcb_visualtype_iterator_t
{
    public xcb_visualtype_t* data;

    public int rem;

    public int index;
}

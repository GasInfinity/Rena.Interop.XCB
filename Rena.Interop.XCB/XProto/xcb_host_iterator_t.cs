namespace Rena.Interop.XCB;

public unsafe partial struct xcb_host_iterator_t
{
    public xcb_host_t* data;

    public int rem;

    public int index;
}

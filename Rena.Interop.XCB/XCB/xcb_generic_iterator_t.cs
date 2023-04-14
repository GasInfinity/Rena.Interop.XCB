namespace Rena.Interop.XCB;

public unsafe partial struct xcb_generic_iterator_t
{
    public void* data;

    public int rem;

    public int index;
}

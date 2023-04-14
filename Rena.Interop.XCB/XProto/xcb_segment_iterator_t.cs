namespace Rena.Interop.XCB;

public unsafe partial struct xcb_segment_iterator_t
{
    public xcb_segment_t* data;

    public int rem;

    public int index;
}

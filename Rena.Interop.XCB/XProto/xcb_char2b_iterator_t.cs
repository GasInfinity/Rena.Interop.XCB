namespace Rena.Interop.XCB;

public unsafe partial struct xcb_char2b_iterator_t
{
    public xcb_char2b_t* data;

    public int rem;

    public int index;
}

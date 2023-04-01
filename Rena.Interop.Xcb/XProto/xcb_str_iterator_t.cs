namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_str_iterator_t
{
    public xcb_str_t* data;

    public int rem;

    public int index;
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_format_iterator_t
{
    public xcb_format_t* data;

    public int rem;

    public int index;
}

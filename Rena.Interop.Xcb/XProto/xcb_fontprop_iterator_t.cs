namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_fontprop_iterator_t
{
    public xcb_fontprop_t* data;

    public int rem;

    public int index;
}

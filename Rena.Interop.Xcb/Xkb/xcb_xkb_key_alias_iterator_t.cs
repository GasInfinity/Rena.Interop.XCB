namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_key_alias_iterator_t
{
    public xcb_xkb_key_alias_t* data;

    public int rem;

    public int index;
}

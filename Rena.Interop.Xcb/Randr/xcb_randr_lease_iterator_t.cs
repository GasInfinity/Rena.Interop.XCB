namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_lease_iterator_t
{
    [NativeTypeName("xcb_randr_lease_t *")]
    public uint* data;

    public int rem;

    public int index;
}

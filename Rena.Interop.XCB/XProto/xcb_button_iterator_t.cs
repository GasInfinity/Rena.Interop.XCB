namespace Rena.Interop.XCB;

public unsafe partial struct xcb_button_iterator_t
{
    [NativeTypeName("xcb_button_t *")]
    public byte* data;

    public int rem;

    public int index;
}

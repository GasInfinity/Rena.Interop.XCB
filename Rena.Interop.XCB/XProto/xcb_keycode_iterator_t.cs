namespace Rena.Interop.XCB;

public unsafe partial struct xcb_keycode_iterator_t
{
    [NativeTypeName("xcb_keycode_t *")]
    public byte* data;

    public int rem;

    public int index;
}

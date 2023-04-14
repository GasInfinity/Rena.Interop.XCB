namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_device_id_iterator_t
{
    [NativeTypeName("xcb_input_device_id_t *")]
    public ushort* data;

    public int rem;

    public int index;
}

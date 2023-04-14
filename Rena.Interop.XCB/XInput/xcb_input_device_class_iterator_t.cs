namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_device_class_iterator_t
{
    public xcb_input_device_class_t* data;

    public int rem;

    public int index;
}

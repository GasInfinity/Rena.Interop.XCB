namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_device_time_coord_iterator_t
{
    public xcb_input_device_time_coord_t* data;

    public int rem;

    public int index;

    [NativeTypeName("uint8_t")]
    public byte num_axes;
}

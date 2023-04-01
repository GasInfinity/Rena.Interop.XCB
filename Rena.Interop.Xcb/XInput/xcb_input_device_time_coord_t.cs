namespace Rena.Interop.Xcb;

public partial struct xcb_input_device_time_coord_t
{
    [NativeTypeName("xcb_timestamp_t")]
    public uint time;
}

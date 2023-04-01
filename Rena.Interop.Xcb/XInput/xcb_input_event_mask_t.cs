namespace Rena.Interop.Xcb;

public partial struct xcb_input_event_mask_t
{
    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint16_t")]
    public ushort mask_len;
}

namespace Rena.Interop.Xcb;

public partial struct xcb_input_device_state_t
{
    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint16_t")]
    public ushort len;
}

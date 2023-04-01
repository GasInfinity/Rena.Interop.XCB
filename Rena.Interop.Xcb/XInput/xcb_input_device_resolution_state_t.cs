namespace Rena.Interop.Xcb;

public partial struct xcb_input_device_resolution_state_t
{
    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint32_t")]
    public uint num_valuators;
}

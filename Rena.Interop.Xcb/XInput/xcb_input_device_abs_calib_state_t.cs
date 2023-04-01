namespace Rena.Interop.Xcb;

public partial struct xcb_input_device_abs_calib_state_t
{
    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("int32_t")]
    public int min_x;

    [NativeTypeName("int32_t")]
    public int max_x;

    [NativeTypeName("int32_t")]
    public int min_y;

    [NativeTypeName("int32_t")]
    public int max_y;

    [NativeTypeName("uint32_t")]
    public uint flip_x;

    [NativeTypeName("uint32_t")]
    public uint flip_y;

    [NativeTypeName("uint32_t")]
    public uint rotation;

    [NativeTypeName("uint32_t")]
    public uint button_threshold;
}

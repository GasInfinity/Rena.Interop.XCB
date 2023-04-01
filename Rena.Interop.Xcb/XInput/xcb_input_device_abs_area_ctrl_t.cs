namespace Rena.Interop.Xcb;

public partial struct xcb_input_device_abs_area_ctrl_t
{
    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint32_t")]
    public uint offset_x;

    [NativeTypeName("uint32_t")]
    public uint offset_y;

    [NativeTypeName("int32_t")]
    public int width;

    [NativeTypeName("int32_t")]
    public int height;

    [NativeTypeName("int32_t")]
    public int screen;

    [NativeTypeName("uint32_t")]
    public uint following;
}

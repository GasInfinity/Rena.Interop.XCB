namespace Rena.Interop.XCB;

public partial struct xcb_input_device_abs_area_state_t
{
    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint32_t")]
    public uint offset_x;

    [NativeTypeName("uint32_t")]
    public uint offset_y;

    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("uint32_t")]
    public uint screen;

    [NativeTypeName("uint32_t")]
    public uint following;
}

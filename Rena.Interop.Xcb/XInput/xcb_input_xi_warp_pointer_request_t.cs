namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_xi_warp_pointer_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint src_win;

    [NativeTypeName("xcb_window_t")]
    public uint dst_win;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int src_x;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int src_y;

    [NativeTypeName("uint16_t")]
    public ushort src_width;

    [NativeTypeName("uint16_t")]
    public ushort src_height;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int dst_x;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int dst_y;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

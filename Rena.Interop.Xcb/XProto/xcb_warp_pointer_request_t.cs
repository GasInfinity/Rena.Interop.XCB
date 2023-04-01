namespace Rena.Interop.Xcb;

public partial struct xcb_warp_pointer_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint src_window;

    [NativeTypeName("xcb_window_t")]
    public uint dst_window;

    [NativeTypeName("int16_t")]
    public short src_x;

    [NativeTypeName("int16_t")]
    public short src_y;

    [NativeTypeName("uint16_t")]
    public ushort src_width;

    [NativeTypeName("uint16_t")]
    public ushort src_height;

    [NativeTypeName("int16_t")]
    public short dst_x;

    [NativeTypeName("int16_t")]
    public short dst_y;
}

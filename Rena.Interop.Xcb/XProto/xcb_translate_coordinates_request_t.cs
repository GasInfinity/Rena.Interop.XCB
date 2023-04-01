namespace Rena.Interop.Xcb;

public partial struct xcb_translate_coordinates_request_t
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
}

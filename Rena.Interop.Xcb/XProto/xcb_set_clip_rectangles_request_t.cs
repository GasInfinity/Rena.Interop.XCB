namespace Rena.Interop.Xcb;

public partial struct xcb_set_clip_rectangles_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte ordering;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_gcontext_t")]
    public uint gc;

    [NativeTypeName("int16_t")]
    public short clip_x_origin;

    [NativeTypeName("int16_t")]
    public short clip_y_origin;
}

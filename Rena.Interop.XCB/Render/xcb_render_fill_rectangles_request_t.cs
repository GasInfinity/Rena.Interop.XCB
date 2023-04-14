namespace Rena.Interop.XCB;

public unsafe partial struct xcb_render_fill_rectangles_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint8_t")]
    public byte op;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];

    [NativeTypeName("xcb_render_picture_t")]
    public uint dst;

    public xcb_render_color_t color;
}

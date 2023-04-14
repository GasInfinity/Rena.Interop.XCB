namespace Rena.Interop.XCB;

public partial struct xcb_render_create_solid_fill_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_render_picture_t")]
    public uint picture;

    public xcb_render_color_t color;
}

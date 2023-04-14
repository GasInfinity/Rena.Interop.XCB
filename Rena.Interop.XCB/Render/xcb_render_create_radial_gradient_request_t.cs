namespace Rena.Interop.XCB;

public partial struct xcb_render_create_radial_gradient_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_render_picture_t")]
    public uint picture;

    public xcb_render_pointfix_t inner;

    public xcb_render_pointfix_t outer;

    [NativeTypeName("xcb_render_fixed_t")]
    public int inner_radius;

    [NativeTypeName("xcb_render_fixed_t")]
    public int outer_radius;

    [NativeTypeName("uint32_t")]
    public uint num_stops;
}

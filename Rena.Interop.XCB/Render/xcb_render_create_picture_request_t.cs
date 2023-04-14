namespace Rena.Interop.XCB;

public partial struct xcb_render_create_picture_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_render_picture_t")]
    public uint pid;

    [NativeTypeName("xcb_drawable_t")]
    public uint drawable;

    [NativeTypeName("xcb_render_pictformat_t")]
    public uint format;

    [NativeTypeName("uint32_t")]
    public uint value_mask;
}

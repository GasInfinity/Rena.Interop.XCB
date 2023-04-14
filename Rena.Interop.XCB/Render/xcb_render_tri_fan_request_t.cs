namespace Rena.Interop.XCB;

public unsafe partial struct xcb_render_tri_fan_request_t
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
    public uint src;

    [NativeTypeName("xcb_render_picture_t")]
    public uint dst;

    [NativeTypeName("xcb_render_pictformat_t")]
    public uint mask_format;

    [NativeTypeName("int16_t")]
    public short src_x;

    [NativeTypeName("int16_t")]
    public short src_y;
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_composite_request_t
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
    public uint mask;

    [NativeTypeName("xcb_render_picture_t")]
    public uint dst;

    [NativeTypeName("int16_t")]
    public short src_x;

    [NativeTypeName("int16_t")]
    public short src_y;

    [NativeTypeName("int16_t")]
    public short mask_x;

    [NativeTypeName("int16_t")]
    public short mask_y;

    [NativeTypeName("int16_t")]
    public short dst_x;

    [NativeTypeName("int16_t")]
    public short dst_y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;
}

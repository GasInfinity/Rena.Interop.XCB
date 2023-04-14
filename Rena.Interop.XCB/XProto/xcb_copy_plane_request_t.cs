namespace Rena.Interop.XCB;

public partial struct xcb_copy_plane_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_drawable_t")]
    public uint src_drawable;

    [NativeTypeName("xcb_drawable_t")]
    public uint dst_drawable;

    [NativeTypeName("xcb_gcontext_t")]
    public uint gc;

    [NativeTypeName("int16_t")]
    public short src_x;

    [NativeTypeName("int16_t")]
    public short src_y;

    [NativeTypeName("int16_t")]
    public short dst_x;

    [NativeTypeName("int16_t")]
    public short dst_y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint32_t")]
    public uint bit_plane;
}

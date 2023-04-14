namespace Rena.Interop.XCB;

public unsafe partial struct xcb_put_image_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte format;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_drawable_t")]
    public uint drawable;

    [NativeTypeName("xcb_gcontext_t")]
    public uint gc;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("int16_t")]
    public short dst_x;

    [NativeTypeName("int16_t")]
    public short dst_y;

    [NativeTypeName("uint8_t")]
    public byte left_pad;

    [NativeTypeName("uint8_t")]
    public byte depth;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

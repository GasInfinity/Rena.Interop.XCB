namespace Rena.Interop.XCB;

public unsafe partial struct xcb_fill_poly_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_drawable_t")]
    public uint drawable;

    [NativeTypeName("xcb_gcontext_t")]
    public uint gc;

    [NativeTypeName("uint8_t")]
    public byte shape;

    [NativeTypeName("uint8_t")]
    public byte coordinate_mode;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

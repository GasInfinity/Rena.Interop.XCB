namespace Rena.Interop.XCB;

public unsafe partial struct xcb_set_font_path_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint16_t")]
    public ushort font_qty;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

namespace Rena.Interop.XCB;

public partial struct xcb_recolor_cursor_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_cursor_t")]
    public uint cursor;

    [NativeTypeName("uint16_t")]
    public ushort fore_red;

    [NativeTypeName("uint16_t")]
    public ushort fore_green;

    [NativeTypeName("uint16_t")]
    public ushort fore_blue;

    [NativeTypeName("uint16_t")]
    public ushort back_red;

    [NativeTypeName("uint16_t")]
    public ushort back_green;

    [NativeTypeName("uint16_t")]
    public ushort back_blue;
}

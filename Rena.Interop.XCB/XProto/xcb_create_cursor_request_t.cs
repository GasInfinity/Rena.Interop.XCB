namespace Rena.Interop.XCB;

public partial struct xcb_create_cursor_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_cursor_t")]
    public uint cid;

    [NativeTypeName("xcb_pixmap_t")]
    public uint source;

    [NativeTypeName("xcb_pixmap_t")]
    public uint mask;

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

    [NativeTypeName("uint16_t")]
    public ushort x;

    [NativeTypeName("uint16_t")]
    public ushort y;
}

namespace Rena.Interop.Xcb;

public partial struct xcb_create_pixmap_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte depth;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_pixmap_t")]
    public uint pid;

    [NativeTypeName("xcb_drawable_t")]
    public uint drawable;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;
}

namespace Rena.Interop.XCB;

public partial struct xcb_xfixes_create_region_from_bitmap_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xfixes_region_t")]
    public uint region;

    [NativeTypeName("xcb_pixmap_t")]
    public uint bitmap;
}

namespace Rena.Interop.Xcb;

public partial struct xcb_copy_colormap_and_free_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_colormap_t")]
    public uint mid;

    [NativeTypeName("xcb_colormap_t")]
    public uint src_cmap;
}

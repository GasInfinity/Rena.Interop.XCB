namespace Rena.Interop.XCB;

public partial struct xcb_free_colors_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_colormap_t")]
    public uint cmap;

    [NativeTypeName("uint32_t")]
    public uint plane_mask;
}

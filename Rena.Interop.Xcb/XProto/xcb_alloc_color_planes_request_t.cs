namespace Rena.Interop.Xcb;

public partial struct xcb_alloc_color_planes_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte contiguous;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_colormap_t")]
    public uint cmap;

    [NativeTypeName("uint16_t")]
    public ushort colors;

    [NativeTypeName("uint16_t")]
    public ushort reds;

    [NativeTypeName("uint16_t")]
    public ushort greens;

    [NativeTypeName("uint16_t")]
    public ushort blues;
}

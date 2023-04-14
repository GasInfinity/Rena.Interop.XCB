namespace Rena.Interop.XCB;

public unsafe partial struct xcb_store_named_color_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_colormap_t")]
    public uint cmap;

    [NativeTypeName("uint32_t")]
    public uint pixel;

    [NativeTypeName("uint16_t")]
    public ushort name_len;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

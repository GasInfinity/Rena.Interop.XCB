namespace Rena.Interop.XCB;

public unsafe partial struct xcb_render_query_pict_formats_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint32_t")]
    public uint num_formats;

    [NativeTypeName("uint32_t")]
    public uint num_screens;

    [NativeTypeName("uint32_t")]
    public uint num_depths;

    [NativeTypeName("uint32_t")]
    public uint num_visuals;

    [NativeTypeName("uint32_t")]
    public uint num_subpixel;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad1[4];
}

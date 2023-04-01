namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_query_filters_reply_t
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
    public uint num_aliases;

    [NativeTypeName("uint32_t")]
    public uint num_filters;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte pad1[16];
}

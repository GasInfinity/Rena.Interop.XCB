namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_alloc_color_planes_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort pixels_len;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];

    [NativeTypeName("uint32_t")]
    public uint red_mask;

    [NativeTypeName("uint32_t")]
    public uint green_mask;

    [NativeTypeName("uint32_t")]
    public uint blue_mask;

    [NativeTypeName("uint8_t[8]")]
    public fixed byte pad2[8];
}

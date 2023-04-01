namespace Rena.Interop.Xcb;

public partial struct xcb_lookup_color_reply_t
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
    public ushort exact_red;

    [NativeTypeName("uint16_t")]
    public ushort exact_green;

    [NativeTypeName("uint16_t")]
    public ushort exact_blue;

    [NativeTypeName("uint16_t")]
    public ushort visual_red;

    [NativeTypeName("uint16_t")]
    public ushort visual_green;

    [NativeTypeName("uint16_t")]
    public ushort visual_blue;
}

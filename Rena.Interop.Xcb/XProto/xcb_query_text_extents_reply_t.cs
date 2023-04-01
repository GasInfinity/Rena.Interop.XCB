namespace Rena.Interop.Xcb;

public partial struct xcb_query_text_extents_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte draw_direction;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("int16_t")]
    public short font_ascent;

    [NativeTypeName("int16_t")]
    public short font_descent;

    [NativeTypeName("int16_t")]
    public short overall_ascent;

    [NativeTypeName("int16_t")]
    public short overall_descent;

    [NativeTypeName("int32_t")]
    public int overall_width;

    [NativeTypeName("int32_t")]
    public int overall_left;

    [NativeTypeName("int32_t")]
    public int overall_right;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_list_fonts_with_info_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte name_len;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    public xcb_charinfo_t min_bounds;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad0[4];

    public xcb_charinfo_t max_bounds;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad1[4];

    [NativeTypeName("uint16_t")]
    public ushort min_char_or_byte2;

    [NativeTypeName("uint16_t")]
    public ushort max_char_or_byte2;

    [NativeTypeName("uint16_t")]
    public ushort default_char;

    [NativeTypeName("uint16_t")]
    public ushort properties_len;

    [NativeTypeName("uint8_t")]
    public byte draw_direction;

    [NativeTypeName("uint8_t")]
    public byte min_byte1;

    [NativeTypeName("uint8_t")]
    public byte max_byte1;

    [NativeTypeName("uint8_t")]
    public byte all_chars_exist;

    [NativeTypeName("int16_t")]
    public short font_ascent;

    [NativeTypeName("int16_t")]
    public short font_descent;

    [NativeTypeName("uint32_t")]
    public uint replies_hint;
}

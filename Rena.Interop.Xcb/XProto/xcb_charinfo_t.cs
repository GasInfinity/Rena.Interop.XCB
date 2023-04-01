namespace Rena.Interop.Xcb;

public partial struct xcb_charinfo_t
{
    [NativeTypeName("int16_t")]
    public short left_side_bearing;

    [NativeTypeName("int16_t")]
    public short right_side_bearing;

    [NativeTypeName("int16_t")]
    public short character_width;

    [NativeTypeName("int16_t")]
    public short ascent;

    [NativeTypeName("int16_t")]
    public short descent;

    [NativeTypeName("uint16_t")]
    public ushort attributes;
}

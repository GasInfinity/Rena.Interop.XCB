namespace Rena.Interop.Xcb;

public partial struct xcb_query_font_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_fontable_t")]
    public uint font;
}

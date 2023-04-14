namespace Rena.Interop.XCB;

public partial struct xcb_query_text_extents_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte odd_length;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_fontable_t")]
    public uint font;
}

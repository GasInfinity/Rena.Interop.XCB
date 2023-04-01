namespace Rena.Interop.Xcb;

public partial struct xcb_render_query_pict_formats_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;
}

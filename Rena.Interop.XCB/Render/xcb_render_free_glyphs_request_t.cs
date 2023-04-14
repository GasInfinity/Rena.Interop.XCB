namespace Rena.Interop.XCB;

public partial struct xcb_render_free_glyphs_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_render_glyphset_t")]
    public uint glyphset;
}

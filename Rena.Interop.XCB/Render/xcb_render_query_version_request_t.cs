namespace Rena.Interop.XCB;

public partial struct xcb_render_query_version_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint32_t")]
    public uint client_major_version;

    [NativeTypeName("uint32_t")]
    public uint client_minor_version;
}

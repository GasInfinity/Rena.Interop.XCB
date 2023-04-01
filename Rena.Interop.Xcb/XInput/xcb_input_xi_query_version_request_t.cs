namespace Rena.Interop.Xcb;

public partial struct xcb_input_xi_query_version_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint16_t")]
    public ushort major_version;

    [NativeTypeName("uint16_t")]
    public ushort minor_version;
}

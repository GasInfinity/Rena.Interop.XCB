namespace Rena.Interop.XCB;

public partial struct xcb_randr_list_output_properties_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_output_t")]
    public uint output;
}

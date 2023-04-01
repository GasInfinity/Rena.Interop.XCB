namespace Rena.Interop.Xcb;

public partial struct xcb_randr_get_output_info_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_output_t")]
    public uint output;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;
}

namespace Rena.Interop.Xcb;

public partial struct xcb_randr_set_provider_output_source_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_provider_t")]
    public uint provider;

    [NativeTypeName("xcb_randr_provider_t")]
    public uint source_provider;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;
}

namespace Rena.Interop.XCB;

public partial struct xcb_randr_get_crtc_info_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;
}

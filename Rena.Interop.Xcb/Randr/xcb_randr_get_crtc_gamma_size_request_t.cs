namespace Rena.Interop.Xcb;

public partial struct xcb_randr_get_crtc_gamma_size_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;
}

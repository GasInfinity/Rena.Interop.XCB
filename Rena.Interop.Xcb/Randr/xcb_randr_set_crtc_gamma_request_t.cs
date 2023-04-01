namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_set_crtc_gamma_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;

    [NativeTypeName("uint16_t")]
    public ushort size;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

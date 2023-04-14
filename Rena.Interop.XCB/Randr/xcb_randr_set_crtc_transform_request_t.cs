namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_set_crtc_transform_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;

    public xcb_render_transform_t transform;

    [NativeTypeName("uint16_t")]
    public ushort filter_len;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

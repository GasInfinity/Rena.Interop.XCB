namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_get_crtc_transform_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    public xcb_render_transform_t pending_transform;

    [NativeTypeName("uint8_t")]
    public byte has_transforms;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad1[3];

    public xcb_render_transform_t current_transform;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad2[4];

    [NativeTypeName("uint16_t")]
    public ushort pending_len;

    [NativeTypeName("uint16_t")]
    public ushort pending_nparams;

    [NativeTypeName("uint16_t")]
    public ushort current_len;

    [NativeTypeName("uint16_t")]
    public ushort current_nparams;
}

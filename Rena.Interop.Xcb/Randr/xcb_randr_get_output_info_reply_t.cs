namespace Rena.Interop.Xcb;

public partial struct xcb_randr_get_output_info_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte status;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;

    [NativeTypeName("uint32_t")]
    public uint mm_width;

    [NativeTypeName("uint32_t")]
    public uint mm_height;

    [NativeTypeName("uint8_t")]
    public byte connection;

    [NativeTypeName("uint8_t")]
    public byte subpixel_order;

    [NativeTypeName("uint16_t")]
    public ushort num_crtcs;

    [NativeTypeName("uint16_t")]
    public ushort num_modes;

    [NativeTypeName("uint16_t")]
    public ushort num_preferred;

    [NativeTypeName("uint16_t")]
    public ushort num_clones;

    [NativeTypeName("uint16_t")]
    public ushort name_len;
}

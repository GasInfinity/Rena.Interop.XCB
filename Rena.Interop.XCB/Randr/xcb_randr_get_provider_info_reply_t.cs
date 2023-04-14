namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_get_provider_info_reply_t
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

    [NativeTypeName("uint32_t")]
    public uint capabilities;

    [NativeTypeName("uint16_t")]
    public ushort num_crtcs;

    [NativeTypeName("uint16_t")]
    public ushort num_outputs;

    [NativeTypeName("uint16_t")]
    public ushort num_associated_providers;

    [NativeTypeName("uint16_t")]
    public ushort name_len;

    [NativeTypeName("uint8_t[8]")]
    public fixed byte pad0[8];
}

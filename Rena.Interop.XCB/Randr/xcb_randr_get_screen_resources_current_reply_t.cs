namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_get_screen_resources_current_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;

    [NativeTypeName("uint16_t")]
    public ushort num_crtcs;

    [NativeTypeName("uint16_t")]
    public ushort num_outputs;

    [NativeTypeName("uint16_t")]
    public ushort num_modes;

    [NativeTypeName("uint16_t")]
    public ushort names_len;

    [NativeTypeName("uint8_t[8]")]
    public fixed byte pad1[8];
}

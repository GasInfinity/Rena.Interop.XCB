namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_set_screen_config_reply_t
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
    public uint new_timestamp;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;

    [NativeTypeName("xcb_window_t")]
    public uint root;

    [NativeTypeName("uint16_t")]
    public ushort subpixel_order;

    [NativeTypeName("uint8_t[10]")]
    public fixed byte pad0[10];
}

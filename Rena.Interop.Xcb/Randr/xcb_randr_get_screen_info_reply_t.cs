namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_get_screen_info_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte rotations;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_window_t")]
    public uint root;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;

    [NativeTypeName("uint16_t")]
    public ushort nSizes;

    [NativeTypeName("uint16_t")]
    public ushort sizeID;

    [NativeTypeName("uint16_t")]
    public ushort rotation;

    [NativeTypeName("uint16_t")]
    public ushort rate;

    [NativeTypeName("uint16_t")]
    public ushort nInfo;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

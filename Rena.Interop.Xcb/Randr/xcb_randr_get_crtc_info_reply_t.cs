namespace Rena.Interop.Xcb;

public partial struct xcb_randr_get_crtc_info_reply_t
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

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("xcb_randr_mode_t")]
    public uint mode;

    [NativeTypeName("uint16_t")]
    public ushort rotation;

    [NativeTypeName("uint16_t")]
    public ushort rotations;

    [NativeTypeName("uint16_t")]
    public ushort num_outputs;

    [NativeTypeName("uint16_t")]
    public ushort num_possible_outputs;
}

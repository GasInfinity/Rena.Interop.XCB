namespace Rena.Interop.XCB;

public partial struct xcb_randr_get_panning_reply_t
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

    [NativeTypeName("uint16_t")]
    public ushort left;

    [NativeTypeName("uint16_t")]
    public ushort top;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint16_t")]
    public ushort track_left;

    [NativeTypeName("uint16_t")]
    public ushort track_top;

    [NativeTypeName("uint16_t")]
    public ushort track_width;

    [NativeTypeName("uint16_t")]
    public ushort track_height;

    [NativeTypeName("int16_t")]
    public short border_left;

    [NativeTypeName("int16_t")]
    public short border_top;

    [NativeTypeName("int16_t")]
    public short border_right;

    [NativeTypeName("int16_t")]
    public short border_bottom;
}

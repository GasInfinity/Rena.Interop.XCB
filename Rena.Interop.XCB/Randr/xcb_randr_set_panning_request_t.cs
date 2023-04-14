namespace Rena.Interop.XCB;

public partial struct xcb_randr_set_panning_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;

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

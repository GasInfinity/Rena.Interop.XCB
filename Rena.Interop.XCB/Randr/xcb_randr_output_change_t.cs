namespace Rena.Interop.XCB;

public partial struct xcb_randr_output_change_t
{
    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_randr_output_t")]
    public uint output;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;

    [NativeTypeName("xcb_randr_mode_t")]
    public uint mode;

    [NativeTypeName("uint16_t")]
    public ushort rotation;

    [NativeTypeName("uint8_t")]
    public byte connection;

    [NativeTypeName("uint8_t")]
    public byte subpixel_order;
}

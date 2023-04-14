namespace Rena.Interop.XCB;

public partial struct xcb_randr_screen_change_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte rotation;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;

    [NativeTypeName("xcb_window_t")]
    public uint root;

    [NativeTypeName("xcb_window_t")]
    public uint request_window;

    [NativeTypeName("uint16_t")]
    public ushort sizeID;

    [NativeTypeName("uint16_t")]
    public ushort subpixel_order;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint16_t")]
    public ushort mwidth;

    [NativeTypeName("uint16_t")]
    public ushort mheight;
}

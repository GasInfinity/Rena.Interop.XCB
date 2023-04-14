namespace Rena.Interop.XCB;

public partial struct xcb_configure_request_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte stack_mode;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint parent;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_window_t")]
    public uint sibling;

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint16_t")]
    public ushort border_width;

    [NativeTypeName("uint16_t")]
    public ushort value_mask;
}

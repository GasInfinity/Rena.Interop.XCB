namespace Rena.Interop.XCB;

public unsafe partial struct xcb_shape_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("xcb_shape_kind_t")]
    public byte shape_kind;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint affected_window;

    [NativeTypeName("int16_t")]
    public short extents_x;

    [NativeTypeName("int16_t")]
    public short extents_y;

    [NativeTypeName("uint16_t")]
    public ushort extents_width;

    [NativeTypeName("uint16_t")]
    public ushort extents_height;

    [NativeTypeName("xcb_timestamp_t")]
    public uint server_time;

    [NativeTypeName("uint8_t")]
    public byte shaped;

    [NativeTypeName("uint8_t[11]")]
    public fixed byte pad0[11];
}

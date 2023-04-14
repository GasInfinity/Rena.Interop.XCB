namespace Rena.Interop.XCB;

public partial struct xcb_input_xi_grab_device_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("xcb_cursor_t")]
    public uint cursor;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint8_t")]
    public byte paired_device_mode;

    [NativeTypeName("uint8_t")]
    public byte owner_events;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort mask_len;
}

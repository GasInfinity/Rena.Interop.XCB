namespace Rena.Interop.Xcb;

public partial struct xcb_get_motion_events_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_timestamp_t")]
    public uint start;

    [NativeTypeName("xcb_timestamp_t")]
    public uint stop;
}

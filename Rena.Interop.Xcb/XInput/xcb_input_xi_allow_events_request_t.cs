namespace Rena.Interop.Xcb;

public partial struct xcb_input_xi_allow_events_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint8_t")]
    public byte event_mode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint32_t")]
    public uint touchid;

    [NativeTypeName("xcb_window_t")]
    public uint grab_window;
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_xi_passive_grab_device_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("xcb_window_t")]
    public uint grab_window;

    [NativeTypeName("xcb_cursor_t")]
    public uint cursor;

    [NativeTypeName("uint32_t")]
    public uint detail;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint16_t")]
    public ushort num_modifiers;

    [NativeTypeName("uint16_t")]
    public ushort mask_len;

    [NativeTypeName("uint8_t")]
    public byte grab_type;

    [NativeTypeName("uint8_t")]
    public byte grab_mode;

    [NativeTypeName("uint8_t")]
    public byte paired_device_mode;

    [NativeTypeName("uint8_t")]
    public byte owner_events;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

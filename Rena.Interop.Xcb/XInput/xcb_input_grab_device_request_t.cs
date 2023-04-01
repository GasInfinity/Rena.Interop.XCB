namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_grab_device_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint grab_window;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint16_t")]
    public ushort num_classes;

    [NativeTypeName("uint8_t")]
    public byte this_device_mode;

    [NativeTypeName("uint8_t")]
    public byte other_device_mode;

    [NativeTypeName("uint8_t")]
    public byte owner_events;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

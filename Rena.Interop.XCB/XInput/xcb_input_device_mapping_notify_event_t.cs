namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_device_mapping_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint8_t")]
    public byte request;

    [NativeTypeName("xcb_input_key_code_t")]
    public byte first_keycode;

    [NativeTypeName("uint8_t")]
    public byte count;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad1[20];
}

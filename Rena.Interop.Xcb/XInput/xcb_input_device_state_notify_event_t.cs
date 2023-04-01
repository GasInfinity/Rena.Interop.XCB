namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_device_state_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint8_t")]
    public byte num_keys;

    [NativeTypeName("uint8_t")]
    public byte num_buttons;

    [NativeTypeName("uint8_t")]
    public byte num_valuators;

    [NativeTypeName("uint8_t")]
    public byte classes_reported;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte buttons[4];

    [NativeTypeName("uint8_t[4]")]
    public fixed byte keys[4];

    [NativeTypeName("uint32_t[3]")]
    public fixed uint valuators[3];
}

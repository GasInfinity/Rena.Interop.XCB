namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_device_button_state_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint8_t[28]")]
    public fixed byte buttons[28];
}

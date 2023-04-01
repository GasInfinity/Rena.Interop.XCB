namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_device_valuator_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint16_t")]
    public ushort device_state;

    [NativeTypeName("uint8_t")]
    public byte num_valuators;

    [NativeTypeName("uint8_t")]
    public byte first_valuator;

    [NativeTypeName("int32_t[6]")]
    public fixed int valuators[6];
}

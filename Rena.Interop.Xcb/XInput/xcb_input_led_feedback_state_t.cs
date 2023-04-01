namespace Rena.Interop.Xcb;

public partial struct xcb_input_led_feedback_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint32_t")]
    public uint led_mask;

    [NativeTypeName("uint32_t")]
    public uint led_values;
}

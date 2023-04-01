namespace Rena.Interop.Xcb;

public partial struct xcb_input_kbd_feedback_ctl_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("xcb_input_key_code_t")]
    public byte key;

    [NativeTypeName("uint8_t")]
    public byte auto_repeat_mode;

    [NativeTypeName("int8_t")]
    public sbyte key_click_percent;

    [NativeTypeName("int8_t")]
    public sbyte bell_percent;

    [NativeTypeName("int16_t")]
    public short bell_pitch;

    [NativeTypeName("int16_t")]
    public short bell_duration;

    [NativeTypeName("uint32_t")]
    public uint led_mask;

    [NativeTypeName("uint32_t")]
    public uint led_values;
}

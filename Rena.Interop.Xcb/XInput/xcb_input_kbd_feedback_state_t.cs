namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_kbd_feedback_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint16_t")]
    public ushort pitch;

    [NativeTypeName("uint16_t")]
    public ushort duration;

    [NativeTypeName("uint32_t")]
    public uint led_mask;

    [NativeTypeName("uint32_t")]
    public uint led_values;

    [NativeTypeName("uint8_t")]
    public byte global_auto_repeat;

    [NativeTypeName("uint8_t")]
    public byte click;

    [NativeTypeName("uint8_t")]
    public byte percent;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint8_t[32]")]
    public fixed byte auto_repeats[32];
}

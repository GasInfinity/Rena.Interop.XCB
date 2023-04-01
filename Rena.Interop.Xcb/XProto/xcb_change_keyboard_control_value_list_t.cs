namespace Rena.Interop.Xcb;

public partial struct xcb_change_keyboard_control_value_list_t
{
    [NativeTypeName("int32_t")]
    public int key_click_percent;

    [NativeTypeName("int32_t")]
    public int bell_percent;

    [NativeTypeName("int32_t")]
    public int bell_pitch;

    [NativeTypeName("int32_t")]
    public int bell_duration;

    [NativeTypeName("uint32_t")]
    public uint led;

    [NativeTypeName("uint32_t")]
    public uint led_mode;

    [NativeTypeName("xcb_keycode32_t")]
    public uint key;

    [NativeTypeName("uint32_t")]
    public uint auto_repeat_mode;
}

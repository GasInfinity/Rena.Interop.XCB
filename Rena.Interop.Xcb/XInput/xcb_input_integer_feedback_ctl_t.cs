namespace Rena.Interop.Xcb;

public partial struct xcb_input_integer_feedback_ctl_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("int32_t")]
    public int int_to_display;
}

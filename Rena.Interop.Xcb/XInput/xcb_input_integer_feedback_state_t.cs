namespace Rena.Interop.Xcb;

public partial struct xcb_input_integer_feedback_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint32_t")]
    public uint resolution;

    [NativeTypeName("int32_t")]
    public int min_value;

    [NativeTypeName("int32_t")]
    public int max_value;
}

namespace Rena.Interop.XCB;

public partial struct xcb_input_string_feedback_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint16_t")]
    public ushort max_symbols;

    [NativeTypeName("uint16_t")]
    public ushort num_keysyms;
}

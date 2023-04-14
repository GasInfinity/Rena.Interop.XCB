namespace Rena.Interop.XCB;

public partial struct xcb_input_valuator_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte len;

    [NativeTypeName("uint8_t")]
    public byte num_valuators;

    [NativeTypeName("uint8_t")]
    public byte mode;
}

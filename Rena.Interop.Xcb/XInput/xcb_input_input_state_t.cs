namespace Rena.Interop.Xcb;

public partial struct xcb_input_input_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte len;
}

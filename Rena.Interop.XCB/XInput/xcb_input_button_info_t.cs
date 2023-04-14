namespace Rena.Interop.XCB;

public partial struct xcb_input_button_info_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte len;

    [NativeTypeName("uint16_t")]
    public ushort num_buttons;
}

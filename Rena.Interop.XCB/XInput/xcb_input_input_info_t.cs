namespace Rena.Interop.XCB;

public partial struct xcb_input_input_info_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte len;
}

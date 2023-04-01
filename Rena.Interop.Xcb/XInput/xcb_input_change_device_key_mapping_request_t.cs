namespace Rena.Interop.Xcb;

public partial struct xcb_input_change_device_key_mapping_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("xcb_input_key_code_t")]
    public byte first_keycode;

    [NativeTypeName("uint8_t")]
    public byte keysyms_per_keycode;

    [NativeTypeName("uint8_t")]
    public byte keycode_count;
}

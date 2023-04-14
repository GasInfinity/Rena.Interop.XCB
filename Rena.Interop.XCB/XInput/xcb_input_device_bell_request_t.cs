namespace Rena.Interop.XCB;

public partial struct xcb_input_device_bell_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_class;

    [NativeTypeName("int8_t")]
    public sbyte percent;
}

namespace Rena.Interop.XCB;

public partial struct xcb_input_set_device_valuators_request_t
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
    public byte first_valuator;

    [NativeTypeName("uint8_t")]
    public byte num_valuators;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

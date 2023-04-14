namespace Rena.Interop.XCB;

public partial struct xcb_input_change_pointer_device_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint8_t")]
    public byte x_axis;

    [NativeTypeName("uint8_t")]
    public byte y_axis;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

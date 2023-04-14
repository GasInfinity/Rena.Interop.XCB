namespace Rena.Interop.XCB;

public partial struct xcb_input_get_device_control_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

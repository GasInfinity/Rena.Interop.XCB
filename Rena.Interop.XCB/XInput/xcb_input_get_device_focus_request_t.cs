namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_get_device_focus_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

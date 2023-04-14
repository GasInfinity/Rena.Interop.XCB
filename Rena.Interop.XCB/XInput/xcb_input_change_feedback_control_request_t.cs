namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_change_feedback_control_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint32_t")]
    public uint mask;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

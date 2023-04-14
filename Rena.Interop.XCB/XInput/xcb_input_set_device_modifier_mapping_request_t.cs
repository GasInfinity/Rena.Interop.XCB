namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_set_device_modifier_mapping_request_t
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
    public byte keycodes_per_modifier;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

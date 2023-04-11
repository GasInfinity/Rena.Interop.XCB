namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_get_state_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

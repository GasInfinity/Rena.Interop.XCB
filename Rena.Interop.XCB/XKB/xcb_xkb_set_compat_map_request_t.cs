namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_set_compat_map_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint8_t")]
    public byte recomputeActions;

    [NativeTypeName("uint8_t")]
    public byte truncateSI;

    [NativeTypeName("uint8_t")]
    public byte groups;

    [NativeTypeName("uint16_t")]
    public ushort firstSI;

    [NativeTypeName("uint16_t")]
    public ushort nSI;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

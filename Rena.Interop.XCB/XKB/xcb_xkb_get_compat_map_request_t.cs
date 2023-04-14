namespace Rena.Interop.XCB;

public partial struct xcb_xkb_get_compat_map_request_t
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
    public byte groups;

    [NativeTypeName("uint8_t")]
    public byte getAllSI;

    [NativeTypeName("uint16_t")]
    public ushort firstSI;

    [NativeTypeName("uint16_t")]
    public ushort nSI;
}

namespace Rena.Interop.XCB;

public partial struct xcb_input_xi_get_property_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint8_t")]
    public byte _delete;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("xcb_atom_t")]
    public uint type;

    [NativeTypeName("uint32_t")]
    public uint offset;

    [NativeTypeName("uint32_t")]
    public uint len;
}

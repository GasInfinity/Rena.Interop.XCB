namespace Rena.Interop.Xcb;

public partial struct xcb_input_xi_change_property_request_t
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
    public byte mode;

    [NativeTypeName("uint8_t")]
    public byte format;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("xcb_atom_t")]
    public uint type;

    [NativeTypeName("uint32_t")]
    public uint num_items;
}

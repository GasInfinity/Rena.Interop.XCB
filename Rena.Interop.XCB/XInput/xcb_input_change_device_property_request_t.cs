namespace Rena.Interop.XCB;

public partial struct xcb_input_change_device_property_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("xcb_atom_t")]
    public uint type;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t")]
    public byte format;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint32_t")]
    public uint num_items;
}

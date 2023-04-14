namespace Rena.Interop.XCB;

public partial struct xcb_get_property_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte _delete;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("xcb_atom_t")]
    public uint type;

    [NativeTypeName("uint32_t")]
    public uint long_offset;

    [NativeTypeName("uint32_t")]
    public uint long_length;
}

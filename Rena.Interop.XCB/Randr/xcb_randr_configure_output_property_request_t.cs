namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_configure_output_property_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_output_t")]
    public uint output;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("uint8_t")]
    public byte pending;

    [NativeTypeName("uint8_t")]
    public byte range;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

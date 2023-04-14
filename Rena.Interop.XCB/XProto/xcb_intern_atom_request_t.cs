namespace Rena.Interop.XCB;

public unsafe partial struct xcb_intern_atom_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte only_if_exists;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint16_t")]
    public ushort name_len;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

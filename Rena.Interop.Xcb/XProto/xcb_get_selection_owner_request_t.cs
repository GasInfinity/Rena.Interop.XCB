namespace Rena.Interop.Xcb;

public partial struct xcb_get_selection_owner_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_atom_t")]
    public uint selection;
}

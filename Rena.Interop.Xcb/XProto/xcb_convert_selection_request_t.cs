namespace Rena.Interop.Xcb;

public partial struct xcb_convert_selection_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint requestor;

    [NativeTypeName("xcb_atom_t")]
    public uint selection;

    [NativeTypeName("xcb_atom_t")]
    public uint target;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;
}

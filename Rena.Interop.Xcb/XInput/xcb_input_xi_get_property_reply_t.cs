namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_xi_get_property_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_atom_t")]
    public uint type;

    [NativeTypeName("uint32_t")]
    public uint bytes_after;

    [NativeTypeName("uint32_t")]
    public uint num_items;

    [NativeTypeName("uint8_t")]
    public byte format;

    [NativeTypeName("uint8_t[11]")]
    public fixed byte pad1[11];
}

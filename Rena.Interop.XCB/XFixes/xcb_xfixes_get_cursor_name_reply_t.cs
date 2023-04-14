namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xfixes_get_cursor_name_reply_t
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
    public uint atom;

    [NativeTypeName("uint16_t")]
    public ushort nbytes;

    [NativeTypeName("uint8_t[18]")]
    public fixed byte pad1[18];
}

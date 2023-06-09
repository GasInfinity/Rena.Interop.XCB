namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xfixes_get_cursor_image_and_name_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint16_t")]
    public ushort xhot;

    [NativeTypeName("uint16_t")]
    public ushort yhot;

    [NativeTypeName("uint32_t")]
    public uint cursor_serial;

    [NativeTypeName("xcb_atom_t")]
    public uint cursor_atom;

    [NativeTypeName("uint16_t")]
    public ushort nbytes;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

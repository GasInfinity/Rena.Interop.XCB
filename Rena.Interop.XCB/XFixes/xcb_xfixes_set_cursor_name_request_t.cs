namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xfixes_set_cursor_name_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_cursor_t")]
    public uint cursor;

    [NativeTypeName("uint16_t")]
    public ushort nbytes;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

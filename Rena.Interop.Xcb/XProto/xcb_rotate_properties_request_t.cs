namespace Rena.Interop.Xcb;

public partial struct xcb_rotate_properties_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint16_t")]
    public ushort atoms_len;

    [NativeTypeName("int16_t")]
    public short delta;
}

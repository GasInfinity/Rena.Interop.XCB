namespace Rena.Interop.Xcb;

public partial struct xcb_create_window_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte depth;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint wid;

    [NativeTypeName("xcb_window_t")]
    public uint parent;

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint16_t")]
    public ushort border_width;

    [NativeTypeName("uint16_t")]
    public ushort _class;

    [NativeTypeName("xcb_visualid_t")]
    public uint visual;

    [NativeTypeName("uint32_t")]
    public uint value_mask;
}

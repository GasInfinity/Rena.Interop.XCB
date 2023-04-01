namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_shape_get_rectangles_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_shape_kind_t")]
    public byte source_kind;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

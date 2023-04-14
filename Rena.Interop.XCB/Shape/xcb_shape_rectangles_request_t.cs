namespace Rena.Interop.XCB;

public partial struct xcb_shape_rectangles_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_shape_op_t")]
    public byte operation;

    [NativeTypeName("xcb_shape_kind_t")]
    public byte destination_kind;

    [NativeTypeName("uint8_t")]
    public byte ordering;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("xcb_window_t")]
    public uint destination_window;

    [NativeTypeName("int16_t")]
    public short x_offset;

    [NativeTypeName("int16_t")]
    public short y_offset;
}

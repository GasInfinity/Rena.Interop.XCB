namespace Rena.Interop.XCB;

public unsafe partial struct xcb_shape_select_input_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint destination_window;

    [NativeTypeName("uint8_t")]
    public byte enable;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

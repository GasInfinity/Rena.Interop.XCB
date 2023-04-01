namespace Rena.Interop.Xcb;

public partial struct xcb_xfixes_select_cursor_input_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint32_t")]
    public uint event_mask;
}

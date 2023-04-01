namespace Rena.Interop.Xcb;

public partial struct xcb_set_input_focus_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte revert_to;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint focus;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;
}

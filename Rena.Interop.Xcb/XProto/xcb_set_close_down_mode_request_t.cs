namespace Rena.Interop.Xcb;

public partial struct xcb_set_close_down_mode_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint16_t")]
    public ushort length;
}

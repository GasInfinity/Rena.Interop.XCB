namespace Rena.Interop.Xcb;

public partial struct xcb_force_screen_saver_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint16_t")]
    public ushort length;
}

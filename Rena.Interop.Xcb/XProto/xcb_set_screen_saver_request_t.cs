namespace Rena.Interop.Xcb;

public partial struct xcb_set_screen_saver_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("int16_t")]
    public short timeout;

    [NativeTypeName("int16_t")]
    public short interval;

    [NativeTypeName("uint8_t")]
    public byte prefer_blanking;

    [NativeTypeName("uint8_t")]
    public byte allow_exposures;
}

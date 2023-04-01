namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_get_screen_saver_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort timeout;

    [NativeTypeName("uint16_t")]
    public ushort interval;

    [NativeTypeName("uint8_t")]
    public byte prefer_blanking;

    [NativeTypeName("uint8_t")]
    public byte allow_exposures;

    [NativeTypeName("uint8_t[18]")]
    public fixed byte pad1[18];
}

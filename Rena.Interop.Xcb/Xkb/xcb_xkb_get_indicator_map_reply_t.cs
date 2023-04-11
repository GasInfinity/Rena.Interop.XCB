namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_get_indicator_map_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint32_t")]
    public uint which;

    [NativeTypeName("uint32_t")]
    public uint realIndicators;

    [NativeTypeName("uint8_t")]
    public byte nIndicators;

    [NativeTypeName("uint8_t[15]")]
    public fixed byte pad0[15];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_get_indicator_state_reply_t
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
    public uint state;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad0[20];
}

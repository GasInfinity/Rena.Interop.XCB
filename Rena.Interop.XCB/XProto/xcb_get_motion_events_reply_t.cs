namespace Rena.Interop.XCB;

public unsafe partial struct xcb_get_motion_events_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint32_t")]
    public uint events_len;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad1[20];
}

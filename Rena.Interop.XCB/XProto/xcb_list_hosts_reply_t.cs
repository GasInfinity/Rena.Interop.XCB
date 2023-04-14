namespace Rena.Interop.XCB;

public unsafe partial struct xcb_list_hosts_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort hosts_len;

    [NativeTypeName("uint8_t[22]")]
    public fixed byte pad0[22];
}

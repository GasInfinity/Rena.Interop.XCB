namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_get_providers_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("uint16_t")]
    public ushort num_providers;

    [NativeTypeName("uint8_t[18]")]
    public fixed byte pad1[18];
}

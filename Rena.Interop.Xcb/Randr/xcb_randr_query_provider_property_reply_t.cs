namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_query_provider_property_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint8_t")]
    public byte pending;

    [NativeTypeName("uint8_t")]
    public byte range;

    [NativeTypeName("uint8_t")]
    public byte immutable;

    [NativeTypeName("uint8_t[21]")]
    public fixed byte pad1[21];
}

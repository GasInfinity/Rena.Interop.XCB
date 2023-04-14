namespace Rena.Interop.XCB;

public unsafe partial struct xcb_raw_generic_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t[7]")]
    public fixed uint pad[7];
}

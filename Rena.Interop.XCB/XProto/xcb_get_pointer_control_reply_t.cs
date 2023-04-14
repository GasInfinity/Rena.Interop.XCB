namespace Rena.Interop.XCB;

public unsafe partial struct xcb_get_pointer_control_reply_t
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
    public ushort acceleration_numerator;

    [NativeTypeName("uint16_t")]
    public ushort acceleration_denominator;

    [NativeTypeName("uint16_t")]
    public ushort threshold;

    [NativeTypeName("uint8_t[18]")]
    public fixed byte pad1[18];
}

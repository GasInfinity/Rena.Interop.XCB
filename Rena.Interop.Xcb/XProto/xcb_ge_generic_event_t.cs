namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_ge_generic_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte extension;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort event_type;

    [NativeTypeName("uint8_t[22]")]
    public fixed byte pad0[22];

    [NativeTypeName("uint32_t")]
    public uint full_sequence;
}

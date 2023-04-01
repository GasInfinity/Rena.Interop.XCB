namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_get_monitors_reply_t
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

    [NativeTypeName("uint32_t")]
    public uint nMonitors;

    [NativeTypeName("uint32_t")]
    public uint nOutputs;

    [NativeTypeName("uint8_t[12]")]
    public fixed byte pad1[12];
}

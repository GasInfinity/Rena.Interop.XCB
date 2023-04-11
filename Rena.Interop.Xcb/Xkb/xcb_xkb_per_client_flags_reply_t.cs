namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_per_client_flags_reply_t
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
    public uint supported;

    [NativeTypeName("uint32_t")]
    public uint value;

    [NativeTypeName("uint32_t")]
    public uint autoCtrls;

    [NativeTypeName("uint32_t")]
    public uint autoCtrlsValues;

    [NativeTypeName("uint8_t[8]")]
    public fixed byte pad0[8];
}

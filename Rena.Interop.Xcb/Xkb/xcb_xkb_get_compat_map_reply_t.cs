namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_get_compat_map_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint8_t")]
    public byte groupsRtrn;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort firstSIRtrn;

    [NativeTypeName("uint16_t")]
    public ushort nSIRtrn;

    [NativeTypeName("uint16_t")]
    public ushort nTotalSI;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte pad1[16];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_set_debugging_flags_reply_t
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
    public uint currentFlags;

    [NativeTypeName("uint32_t")]
    public uint currentCtrls;

    [NativeTypeName("uint32_t")]
    public uint supportedFlags;

    [NativeTypeName("uint32_t")]
    public uint supportedCtrls;

    [NativeTypeName("uint8_t[8]")]
    public fixed byte pad1[8];
}

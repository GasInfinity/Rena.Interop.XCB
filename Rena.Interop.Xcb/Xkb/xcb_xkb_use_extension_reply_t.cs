namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_use_extension_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte supported;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort serverMajor;

    [NativeTypeName("uint16_t")]
    public ushort serverMinor;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad0[20];
}

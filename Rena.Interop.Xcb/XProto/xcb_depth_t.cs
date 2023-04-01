namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_depth_t
{
    [NativeTypeName("uint8_t")]
    public byte depth;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort visuals_len;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad1[4];
}

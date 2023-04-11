namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_sa_terminate_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t[7]")]
    public fixed byte pad0[7];
}

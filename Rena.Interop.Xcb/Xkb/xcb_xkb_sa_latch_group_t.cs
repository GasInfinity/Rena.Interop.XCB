namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_sa_latch_group_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("int8_t")]
    public sbyte group;

    [NativeTypeName("uint8_t[5]")]
    public fixed byte pad0[5];
}

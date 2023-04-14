namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_sa_set_group_t
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

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_sa_set_ptr_dflt_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint8_t")]
    public byte affect;

    [NativeTypeName("int8_t")]
    public sbyte value;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad0[4];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_sa_no_action_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t[7]")]
    public fixed byte pad0[7];
}

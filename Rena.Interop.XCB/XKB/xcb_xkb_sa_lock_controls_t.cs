namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_sa_lock_controls_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];

    [NativeTypeName("uint8_t")]
    public byte boolCtrlsHigh;

    [NativeTypeName("uint8_t")]
    public byte boolCtrlsLow;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

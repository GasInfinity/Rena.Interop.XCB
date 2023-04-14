namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_sa_ptr_btn_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint8_t")]
    public byte count;

    [NativeTypeName("uint8_t")]
    public byte button;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad0[4];
}

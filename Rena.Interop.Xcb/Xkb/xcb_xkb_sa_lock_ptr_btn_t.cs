namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_sa_lock_ptr_btn_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint8_t")]
    public byte button;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad1[4];
}

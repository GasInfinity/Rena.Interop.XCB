namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_sa_move_ptr_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("int8_t")]
    public sbyte xHigh;

    [NativeTypeName("uint8_t")]
    public byte xLow;

    [NativeTypeName("int8_t")]
    public sbyte yHigh;

    [NativeTypeName("uint8_t")]
    public byte yLow;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

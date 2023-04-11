namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_overlay_row_t
{
    [NativeTypeName("uint8_t")]
    public byte rowUnder;

    [NativeTypeName("uint8_t")]
    public byte nKeys;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

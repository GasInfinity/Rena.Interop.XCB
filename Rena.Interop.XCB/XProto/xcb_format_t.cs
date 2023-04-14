namespace Rena.Interop.XCB;

public unsafe partial struct xcb_format_t
{
    [NativeTypeName("uint8_t")]
    public byte depth;

    [NativeTypeName("uint8_t")]
    public byte bits_per_pixel;

    [NativeTypeName("uint8_t")]
    public byte scanline_pad;

    [NativeTypeName("uint8_t[5]")]
    public fixed byte pad0[5];
}

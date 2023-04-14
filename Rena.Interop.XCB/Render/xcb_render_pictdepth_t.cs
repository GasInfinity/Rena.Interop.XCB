namespace Rena.Interop.XCB;

public unsafe partial struct xcb_render_pictdepth_t
{
    [NativeTypeName("uint8_t")]
    public byte depth;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort num_visuals;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad1[4];
}

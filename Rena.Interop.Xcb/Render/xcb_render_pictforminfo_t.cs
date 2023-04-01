namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_pictforminfo_t
{
    [NativeTypeName("xcb_render_pictformat_t")]
    public uint id;

    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte depth;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    public xcb_render_directformat_t direct;

    [NativeTypeName("xcb_colormap_t")]
    public uint colormap;
}

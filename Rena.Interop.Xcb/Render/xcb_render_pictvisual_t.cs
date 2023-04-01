namespace Rena.Interop.Xcb;

public partial struct xcb_render_pictvisual_t
{
    [NativeTypeName("xcb_visualid_t")]
    public uint visual;

    [NativeTypeName("xcb_render_pictformat_t")]
    public uint format;
}

namespace Rena.Interop.XCB;

public partial struct xcb_render_pictscreen_t
{
    [NativeTypeName("uint32_t")]
    public uint num_depths;

    [NativeTypeName("xcb_render_pictformat_t")]
    public uint fallback;
}

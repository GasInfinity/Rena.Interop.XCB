namespace Rena.Interop.XCB;

public partial struct xcb_render_spanfix_t
{
    [NativeTypeName("xcb_render_fixed_t")]
    public int l;

    [NativeTypeName("xcb_render_fixed_t")]
    public int r;

    [NativeTypeName("xcb_render_fixed_t")]
    public int y;
}

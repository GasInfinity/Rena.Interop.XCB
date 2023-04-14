namespace Rena.Interop.XCB;

public partial struct xcb_render_pointfix_t
{
    [NativeTypeName("xcb_render_fixed_t")]
    public int x;

    [NativeTypeName("xcb_render_fixed_t")]
    public int y;
}

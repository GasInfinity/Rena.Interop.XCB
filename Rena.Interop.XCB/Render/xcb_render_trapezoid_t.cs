namespace Rena.Interop.XCB;

public partial struct xcb_render_trapezoid_t
{
    [NativeTypeName("xcb_render_fixed_t")]
    public int top;

    [NativeTypeName("xcb_render_fixed_t")]
    public int bottom;

    public xcb_render_linefix_t left;

    public xcb_render_linefix_t right;
}

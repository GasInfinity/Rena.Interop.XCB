namespace Rena.Interop.XCB;

public partial struct xcb_render_transform_t
{
    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix11;

    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix12;

    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix13;

    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix21;

    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix22;

    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix23;

    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix31;

    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix32;

    [NativeTypeName("xcb_render_fixed_t")]
    public int matrix33;
}

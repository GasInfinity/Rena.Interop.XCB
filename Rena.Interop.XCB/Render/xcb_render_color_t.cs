namespace Rena.Interop.XCB;

public partial struct xcb_render_color_t
{
    [NativeTypeName("uint16_t")]
    public ushort red;

    [NativeTypeName("uint16_t")]
    public ushort green;

    [NativeTypeName("uint16_t")]
    public ushort blue;

    [NativeTypeName("uint16_t")]
    public ushort alpha;
}

namespace Rena.Interop.XCB;

public partial struct xcb_render_glyphinfo_t
{
    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("int16_t")]
    public short x_off;

    [NativeTypeName("int16_t")]
    public short y_off;
}

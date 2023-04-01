namespace Rena.Interop.Xcb;

public partial struct xcb_render_create_picture_value_list_t
{
    [NativeTypeName("uint32_t")]
    public uint repeat;

    [NativeTypeName("xcb_render_picture_t")]
    public uint alphamap;

    [NativeTypeName("int32_t")]
    public int alphaxorigin;

    [NativeTypeName("int32_t")]
    public int alphayorigin;

    [NativeTypeName("int32_t")]
    public int clipxorigin;

    [NativeTypeName("int32_t")]
    public int clipyorigin;

    [NativeTypeName("xcb_pixmap_t")]
    public uint clipmask;

    [NativeTypeName("uint32_t")]
    public uint graphicsexposure;

    [NativeTypeName("uint32_t")]
    public uint subwindowmode;

    [NativeTypeName("uint32_t")]
    public uint polyedge;

    [NativeTypeName("uint32_t")]
    public uint polymode;

    [NativeTypeName("xcb_atom_t")]
    public uint dither;

    [NativeTypeName("uint32_t")]
    public uint componentalpha;
}

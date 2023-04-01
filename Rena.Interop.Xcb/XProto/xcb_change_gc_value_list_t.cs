namespace Rena.Interop.Xcb;

public partial struct xcb_change_gc_value_list_t
{
    [NativeTypeName("uint32_t")]
    public uint function;

    [NativeTypeName("uint32_t")]
    public uint plane_mask;

    [NativeTypeName("uint32_t")]
    public uint foreground;

    [NativeTypeName("uint32_t")]
    public uint background;

    [NativeTypeName("uint32_t")]
    public uint line_width;

    [NativeTypeName("uint32_t")]
    public uint line_style;

    [NativeTypeName("uint32_t")]
    public uint cap_style;

    [NativeTypeName("uint32_t")]
    public uint join_style;

    [NativeTypeName("uint32_t")]
    public uint fill_style;

    [NativeTypeName("uint32_t")]
    public uint fill_rule;

    [NativeTypeName("xcb_pixmap_t")]
    public uint tile;

    [NativeTypeName("xcb_pixmap_t")]
    public uint stipple;

    [NativeTypeName("int32_t")]
    public int tile_stipple_x_origin;

    [NativeTypeName("int32_t")]
    public int tile_stipple_y_origin;

    [NativeTypeName("xcb_font_t")]
    public uint font;

    [NativeTypeName("uint32_t")]
    public uint subwindow_mode;

    [NativeTypeName("xcb_bool32_t")]
    public uint graphics_exposures;

    [NativeTypeName("int32_t")]
    public int clip_x_origin;

    [NativeTypeName("int32_t")]
    public int clip_y_origin;

    [NativeTypeName("xcb_pixmap_t")]
    public uint clip_mask;

    [NativeTypeName("uint32_t")]
    public uint dash_offset;

    [NativeTypeName("uint32_t")]
    public uint dashes;

    [NativeTypeName("uint32_t")]
    public uint arc_mode;
}

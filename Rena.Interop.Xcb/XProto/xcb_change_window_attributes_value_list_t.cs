namespace Rena.Interop.Xcb;

public partial struct xcb_change_window_attributes_value_list_t
{
    [NativeTypeName("xcb_pixmap_t")]
    public uint background_pixmap;

    [NativeTypeName("uint32_t")]
    public uint background_pixel;

    [NativeTypeName("xcb_pixmap_t")]
    public uint border_pixmap;

    [NativeTypeName("uint32_t")]
    public uint border_pixel;

    [NativeTypeName("uint32_t")]
    public uint bit_gravity;

    [NativeTypeName("uint32_t")]
    public uint win_gravity;

    [NativeTypeName("uint32_t")]
    public uint backing_store;

    [NativeTypeName("uint32_t")]
    public uint backing_planes;

    [NativeTypeName("uint32_t")]
    public uint backing_pixel;

    [NativeTypeName("xcb_bool32_t")]
    public uint override_redirect;

    [NativeTypeName("xcb_bool32_t")]
    public uint save_under;

    [NativeTypeName("uint32_t")]
    public uint event_mask;

    [NativeTypeName("uint32_t")]
    public uint do_not_propogate_mask;

    [NativeTypeName("xcb_colormap_t")]
    public uint colormap;

    [NativeTypeName("xcb_cursor_t")]
    public uint cursor;
}

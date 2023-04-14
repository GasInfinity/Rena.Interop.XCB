namespace Rena.Interop.XCB;

public partial struct xcb_screen_t
{
    [NativeTypeName("xcb_window_t")]
    public uint root;

    [NativeTypeName("xcb_colormap_t")]
    public uint default_colormap;

    [NativeTypeName("uint32_t")]
    public uint white_pixel;

    [NativeTypeName("uint32_t")]
    public uint black_pixel;

    [NativeTypeName("uint32_t")]
    public uint current_input_masks;

    [NativeTypeName("uint16_t")]
    public ushort width_in_pixels;

    [NativeTypeName("uint16_t")]
    public ushort height_in_pixels;

    [NativeTypeName("uint16_t")]
    public ushort width_in_millimeters;

    [NativeTypeName("uint16_t")]
    public ushort height_in_millimeters;

    [NativeTypeName("uint16_t")]
    public ushort min_installed_maps;

    [NativeTypeName("uint16_t")]
    public ushort max_installed_maps;

    [NativeTypeName("xcb_visualid_t")]
    public uint root_visual;

    [NativeTypeName("uint8_t")]
    public byte backing_stores;

    [NativeTypeName("uint8_t")]
    public byte save_unders;

    [NativeTypeName("uint8_t")]
    public byte root_depth;

    [NativeTypeName("uint8_t")]
    public byte allowed_depths_len;
}

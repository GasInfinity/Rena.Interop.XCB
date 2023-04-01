namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_get_window_attributes_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte backing_store;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_visualid_t")]
    public uint visual;

    [NativeTypeName("uint16_t")]
    public ushort _class;

    [NativeTypeName("uint8_t")]
    public byte bit_gravity;

    [NativeTypeName("uint8_t")]
    public byte win_gravity;

    [NativeTypeName("uint32_t")]
    public uint backing_planes;

    [NativeTypeName("uint32_t")]
    public uint backing_pixel;

    [NativeTypeName("uint8_t")]
    public byte save_under;

    [NativeTypeName("uint8_t")]
    public byte map_is_installed;

    [NativeTypeName("uint8_t")]
    public byte map_state;

    [NativeTypeName("uint8_t")]
    public byte override_redirect;

    [NativeTypeName("xcb_colormap_t")]
    public uint colormap;

    [NativeTypeName("uint32_t")]
    public uint all_event_masks;

    [NativeTypeName("uint32_t")]
    public uint your_event_mask;

    [NativeTypeName("uint16_t")]
    public ushort do_not_propagate_mask;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

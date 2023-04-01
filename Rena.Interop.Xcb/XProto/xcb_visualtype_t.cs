namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_visualtype_t
{
    [NativeTypeName("xcb_visualid_t")]
    public uint visual_id;

    [NativeTypeName("uint8_t")]
    public byte _class;

    [NativeTypeName("uint8_t")]
    public byte bits_per_rgb_value;

    [NativeTypeName("uint16_t")]
    public ushort colormap_entries;

    [NativeTypeName("uint32_t")]
    public uint red_mask;

    [NativeTypeName("uint32_t")]
    public uint green_mask;

    [NativeTypeName("uint32_t")]
    public uint blue_mask;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad0[4];
}

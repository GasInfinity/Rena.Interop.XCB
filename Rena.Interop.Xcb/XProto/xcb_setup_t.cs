namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_setup_t
{
    [NativeTypeName("uint8_t")]
    public byte status;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort protocol_major_version;

    [NativeTypeName("uint16_t")]
    public ushort protocol_minor_version;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint32_t")]
    public uint release_number;

    [NativeTypeName("uint32_t")]
    public uint resource_id_base;

    [NativeTypeName("uint32_t")]
    public uint resource_id_mask;

    [NativeTypeName("uint32_t")]
    public uint motion_buffer_size;

    [NativeTypeName("uint16_t")]
    public ushort vendor_len;

    [NativeTypeName("uint16_t")]
    public ushort maximum_request_length;

    [NativeTypeName("uint8_t")]
    public byte roots_len;

    [NativeTypeName("uint8_t")]
    public byte pixmap_formats_len;

    [NativeTypeName("uint8_t")]
    public byte image_byte_order;

    [NativeTypeName("uint8_t")]
    public byte bitmap_format_bit_order;

    [NativeTypeName("uint8_t")]
    public byte bitmap_format_scanline_unit;

    [NativeTypeName("uint8_t")]
    public byte bitmap_format_scanline_pad;

    [NativeTypeName("xcb_keycode_t")]
    public byte min_keycode;

    [NativeTypeName("xcb_keycode_t")]
    public byte max_keycode;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad1[4];
}

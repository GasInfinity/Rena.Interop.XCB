namespace Rena.Interop.XCB;

public unsafe partial struct xcb_shape_query_extents_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint8_t")]
    public byte bounding_shaped;

    [NativeTypeName("uint8_t")]
    public byte clip_shaped;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];

    [NativeTypeName("int16_t")]
    public short bounding_shape_extents_x;

    [NativeTypeName("int16_t")]
    public short bounding_shape_extents_y;

    [NativeTypeName("uint16_t")]
    public ushort bounding_shape_extents_width;

    [NativeTypeName("uint16_t")]
    public ushort bounding_shape_extents_height;

    [NativeTypeName("int16_t")]
    public short clip_shape_extents_x;

    [NativeTypeName("int16_t")]
    public short clip_shape_extents_y;

    [NativeTypeName("uint16_t")]
    public ushort clip_shape_extents_width;

    [NativeTypeName("uint16_t")]
    public ushort clip_shape_extents_height;
}

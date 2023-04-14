namespace Rena.Interop.XCB;

public unsafe partial struct xcb_shape_get_rectangles_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte ordering;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint32_t")]
    public uint rectangles_len;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad0[20];
}

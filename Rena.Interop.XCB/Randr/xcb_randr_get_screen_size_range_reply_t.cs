namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_get_screen_size_range_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort min_width;

    [NativeTypeName("uint16_t")]
    public ushort min_height;

    [NativeTypeName("uint16_t")]
    public ushort max_width;

    [NativeTypeName("uint16_t")]
    public ushort max_height;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte pad1[16];
}

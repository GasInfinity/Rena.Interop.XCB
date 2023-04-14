namespace Rena.Interop.XCB;

public partial struct xcb_translate_coordinates_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte same_screen;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_window_t")]
    public uint child;

    [NativeTypeName("int16_t")]
    public short dst_x;

    [NativeTypeName("int16_t")]
    public short dst_y;
}

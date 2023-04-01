namespace Rena.Interop.Xcb;

public partial struct xcb_randr_set_screen_size_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint32_t")]
    public uint mm_width;

    [NativeTypeName("uint32_t")]
    public uint mm_height;
}

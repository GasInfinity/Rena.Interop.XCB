namespace Rena.Interop.Xcb;

public partial struct xcb_randr_mode_info_t
{
    [NativeTypeName("uint32_t")]
    public uint id;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint32_t")]
    public uint dot_clock;

    [NativeTypeName("uint16_t")]
    public ushort hsync_start;

    [NativeTypeName("uint16_t")]
    public ushort hsync_end;

    [NativeTypeName("uint16_t")]
    public ushort htotal;

    [NativeTypeName("uint16_t")]
    public ushort hskew;

    [NativeTypeName("uint16_t")]
    public ushort vsync_start;

    [NativeTypeName("uint16_t")]
    public ushort vsync_end;

    [NativeTypeName("uint16_t")]
    public ushort vtotal;

    [NativeTypeName("uint16_t")]
    public ushort name_len;

    [NativeTypeName("uint32_t")]
    public uint mode_flags;
}

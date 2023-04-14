namespace Rena.Interop.XCB;

public partial struct xcb_randr_screen_size_t
{
    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint16_t")]
    public ushort mwidth;

    [NativeTypeName("uint16_t")]
    public ushort mheight;
}

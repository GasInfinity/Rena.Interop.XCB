namespace Rena.Interop.Xcb;

public partial struct xcb_render_directformat_t
{
    [NativeTypeName("uint16_t")]
    public ushort red_shift;

    [NativeTypeName("uint16_t")]
    public ushort red_mask;

    [NativeTypeName("uint16_t")]
    public ushort green_shift;

    [NativeTypeName("uint16_t")]
    public ushort green_mask;

    [NativeTypeName("uint16_t")]
    public ushort blue_shift;

    [NativeTypeName("uint16_t")]
    public ushort blue_mask;

    [NativeTypeName("uint16_t")]
    public ushort alpha_shift;

    [NativeTypeName("uint16_t")]
    public ushort alpha_mask;
}

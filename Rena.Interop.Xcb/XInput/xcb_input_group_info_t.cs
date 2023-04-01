namespace Rena.Interop.Xcb;

public partial struct xcb_input_group_info_t
{
    [NativeTypeName("uint8_t")]
    public byte @base;

    [NativeTypeName("uint8_t")]
    public byte latched;

    [NativeTypeName("uint8_t")]
    public byte locked;

    [NativeTypeName("uint8_t")]
    public byte effective;
}

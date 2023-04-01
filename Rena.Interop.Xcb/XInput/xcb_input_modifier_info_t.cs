namespace Rena.Interop.Xcb;

public partial struct xcb_input_modifier_info_t
{
    [NativeTypeName("uint32_t")]
    public uint @base;

    [NativeTypeName("uint32_t")]
    public uint latched;

    [NativeTypeName("uint32_t")]
    public uint locked;

    [NativeTypeName("uint32_t")]
    public uint effective;
}

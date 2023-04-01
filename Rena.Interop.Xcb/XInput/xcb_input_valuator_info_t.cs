namespace Rena.Interop.Xcb;

public partial struct xcb_input_valuator_info_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte len;

    [NativeTypeName("uint8_t")]
    public byte axes_len;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint32_t")]
    public uint motion_size;
}

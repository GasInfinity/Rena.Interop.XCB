namespace Rena.Interop.Xcb;

public partial struct xcb_input_input_class_info_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("xcb_input_event_type_base_t")]
    public byte event_type_base;
}

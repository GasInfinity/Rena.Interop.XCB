namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_get_device_info_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("uint16_t")]
    public ushort wanted;

    [NativeTypeName("uint8_t")]
    public byte allButtons;

    [NativeTypeName("uint8_t")]
    public byte firstButton;

    [NativeTypeName("uint8_t")]
    public byte nButtons;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("xcb_xkb_led_class_spec_t")]
    public ushort ledClass;

    [NativeTypeName("xcb_xkb_id_spec_t")]
    public ushort ledID;
}

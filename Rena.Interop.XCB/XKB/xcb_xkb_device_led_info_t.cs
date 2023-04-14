namespace Rena.Interop.XCB;

public partial struct xcb_xkb_device_led_info_t
{
    [NativeTypeName("xcb_xkb_led_class_spec_t")]
    public ushort ledClass;

    [NativeTypeName("xcb_xkb_id_spec_t")]
    public ushort ledID;

    [NativeTypeName("uint32_t")]
    public uint namesPresent;

    [NativeTypeName("uint32_t")]
    public uint mapsPresent;

    [NativeTypeName("uint32_t")]
    public uint physIndicators;

    [NativeTypeName("uint32_t")]
    public uint state;
}

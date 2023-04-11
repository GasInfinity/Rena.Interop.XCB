namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_set_device_info_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("uint8_t")]
    public byte firstBtn;

    [NativeTypeName("uint8_t")]
    public byte nBtns;

    [NativeTypeName("uint16_t")]
    public ushort change;

    [NativeTypeName("uint16_t")]
    public ushort nDeviceLedFBs;
}

namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_get_kbd_by_name_request_t
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
    public ushort need;

    [NativeTypeName("uint16_t")]
    public ushort want;

    [NativeTypeName("uint8_t")]
    public byte load;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

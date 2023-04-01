namespace Rena.Interop.Xcb;

public partial struct xcb_input_ungrab_device_key_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint grabWindow;

    [NativeTypeName("uint16_t")]
    public ushort modifiers;

    [NativeTypeName("uint8_t")]
    public byte modifier_device;

    [NativeTypeName("uint8_t")]
    public byte key;

    [NativeTypeName("uint8_t")]
    public byte grabbed_device;
}

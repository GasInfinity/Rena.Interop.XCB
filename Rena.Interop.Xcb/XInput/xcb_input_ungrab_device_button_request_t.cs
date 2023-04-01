namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_ungrab_device_button_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint grab_window;

    [NativeTypeName("uint16_t")]
    public ushort modifiers;

    [NativeTypeName("uint8_t")]
    public byte modifier_device;

    [NativeTypeName("uint8_t")]
    public byte button;

    [NativeTypeName("uint8_t")]
    public byte grabbed_device;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

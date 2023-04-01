namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_grab_device_key_request_t
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
    public ushort num_classes;

    [NativeTypeName("uint16_t")]
    public ushort modifiers;

    [NativeTypeName("uint8_t")]
    public byte modifier_device;

    [NativeTypeName("uint8_t")]
    public byte grabbed_device;

    [NativeTypeName("uint8_t")]
    public byte key;

    [NativeTypeName("uint8_t")]
    public byte this_device_mode;

    [NativeTypeName("uint8_t")]
    public byte other_device_mode;

    [NativeTypeName("uint8_t")]
    public byte owner_events;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_extension_device_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte xkbType;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort reason;

    [NativeTypeName("uint16_t")]
    public ushort ledClass;

    [NativeTypeName("uint16_t")]
    public ushort ledID;

    [NativeTypeName("uint32_t")]
    public uint ledsDefined;

    [NativeTypeName("uint32_t")]
    public uint ledState;

    [NativeTypeName("uint8_t")]
    public byte firstButton;

    [NativeTypeName("uint8_t")]
    public byte nButtons;

    [NativeTypeName("uint16_t")]
    public ushort supported;

    [NativeTypeName("uint16_t")]
    public ushort unsupported;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

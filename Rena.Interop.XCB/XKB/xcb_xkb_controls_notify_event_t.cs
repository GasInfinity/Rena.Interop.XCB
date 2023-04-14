namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_controls_notify_event_t
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
    public byte numGroups;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("uint32_t")]
    public uint changedControls;

    [NativeTypeName("uint32_t")]
    public uint enabledControls;

    [NativeTypeName("uint32_t")]
    public uint enabledControlChanges;

    [NativeTypeName("xcb_keycode_t")]
    public byte keycode;

    [NativeTypeName("uint8_t")]
    public byte eventType;

    [NativeTypeName("uint8_t")]
    public byte requestMajor;

    [NativeTypeName("uint8_t")]
    public byte requestMinor;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad1[4];
}

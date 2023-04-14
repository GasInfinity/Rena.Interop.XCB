namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_map_notify_event_t
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
    public byte ptrBtnActions;

    [NativeTypeName("uint16_t")]
    public ushort changed;

    [NativeTypeName("xcb_keycode_t")]
    public byte minKeyCode;

    [NativeTypeName("xcb_keycode_t")]
    public byte maxKeyCode;

    [NativeTypeName("uint8_t")]
    public byte firstType;

    [NativeTypeName("uint8_t")]
    public byte nTypes;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeySym;

    [NativeTypeName("uint8_t")]
    public byte nKeySyms;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyAct;

    [NativeTypeName("uint8_t")]
    public byte nKeyActs;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyBehavior;

    [NativeTypeName("uint8_t")]
    public byte nKeyBehavior;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKeyExplicit;

    [NativeTypeName("uint8_t")]
    public byte nKeyExplicit;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstModMapKey;

    [NativeTypeName("uint8_t")]
    public byte nModMapKeys;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstVModMapKey;

    [NativeTypeName("uint8_t")]
    public byte nVModMapKeys;

    [NativeTypeName("uint16_t")]
    public ushort virtualMods;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

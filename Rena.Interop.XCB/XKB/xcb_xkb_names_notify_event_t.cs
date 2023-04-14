namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_names_notify_event_t
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
    public ushort changed;

    [NativeTypeName("uint8_t")]
    public byte firstType;

    [NativeTypeName("uint8_t")]
    public byte nTypes;

    [NativeTypeName("uint8_t")]
    public byte firstLevelName;

    [NativeTypeName("uint8_t")]
    public byte nLevelNames;

    [NativeTypeName("uint8_t")]
    public byte pad1;

    [NativeTypeName("uint8_t")]
    public byte nRadioGroups;

    [NativeTypeName("uint8_t")]
    public byte nKeyAliases;

    [NativeTypeName("uint8_t")]
    public byte changedGroupNames;

    [NativeTypeName("uint16_t")]
    public ushort changedVirtualMods;

    [NativeTypeName("xcb_keycode_t")]
    public byte firstKey;

    [NativeTypeName("uint8_t")]
    public byte nKeys;

    [NativeTypeName("uint32_t")]
    public uint changedIndicators;

    [NativeTypeName("uint8_t[4]")]
    public fixed byte pad2[4];
}

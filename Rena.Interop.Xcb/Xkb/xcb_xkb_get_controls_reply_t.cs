namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_get_controls_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint8_t")]
    public byte mouseKeysDfltBtn;

    [NativeTypeName("uint8_t")]
    public byte numGroups;

    [NativeTypeName("uint8_t")]
    public byte groupsWrap;

    [NativeTypeName("uint8_t")]
    public byte internalModsMask;

    [NativeTypeName("uint8_t")]
    public byte ignoreLockModsMask;

    [NativeTypeName("uint8_t")]
    public byte internalModsRealMods;

    [NativeTypeName("uint8_t")]
    public byte ignoreLockModsRealMods;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort internalModsVmods;

    [NativeTypeName("uint16_t")]
    public ushort ignoreLockModsVmods;

    [NativeTypeName("uint16_t")]
    public ushort repeatDelay;

    [NativeTypeName("uint16_t")]
    public ushort repeatInterval;

    [NativeTypeName("uint16_t")]
    public ushort slowKeysDelay;

    [NativeTypeName("uint16_t")]
    public ushort debounceDelay;

    [NativeTypeName("uint16_t")]
    public ushort mouseKeysDelay;

    [NativeTypeName("uint16_t")]
    public ushort mouseKeysInterval;

    [NativeTypeName("uint16_t")]
    public ushort mouseKeysTimeToMax;

    [NativeTypeName("uint16_t")]
    public ushort mouseKeysMaxSpeed;

    [NativeTypeName("int16_t")]
    public short mouseKeysCurve;

    [NativeTypeName("uint16_t")]
    public ushort accessXOption;

    [NativeTypeName("uint16_t")]
    public ushort accessXTimeout;

    [NativeTypeName("uint16_t")]
    public ushort accessXTimeoutOptionsMask;

    [NativeTypeName("uint16_t")]
    public ushort accessXTimeoutOptionsValues;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];

    [NativeTypeName("uint32_t")]
    public uint accessXTimeoutMask;

    [NativeTypeName("uint32_t")]
    public uint accessXTimeoutValues;

    [NativeTypeName("uint32_t")]
    public uint enabledControls;

    [NativeTypeName("uint8_t[32]")]
    public fixed byte perKeyRepeat[32];
}

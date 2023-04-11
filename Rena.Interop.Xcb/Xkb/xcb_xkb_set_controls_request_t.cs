namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_set_controls_request_t
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
    public byte affectInternalRealMods;

    [NativeTypeName("uint8_t")]
    public byte internalRealMods;

    [NativeTypeName("uint8_t")]
    public byte affectIgnoreLockRealMods;

    [NativeTypeName("uint8_t")]
    public byte ignoreLockRealMods;

    [NativeTypeName("uint16_t")]
    public ushort affectInternalVirtualMods;

    [NativeTypeName("uint16_t")]
    public ushort internalVirtualMods;

    [NativeTypeName("uint16_t")]
    public ushort affectIgnoreLockVirtualMods;

    [NativeTypeName("uint16_t")]
    public ushort ignoreLockVirtualMods;

    [NativeTypeName("uint8_t")]
    public byte mouseKeysDfltBtn;

    [NativeTypeName("uint8_t")]
    public byte groupsWrap;

    [NativeTypeName("uint16_t")]
    public ushort accessXOptions;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("uint32_t")]
    public uint affectEnabledControls;

    [NativeTypeName("uint32_t")]
    public uint enabledControls;

    [NativeTypeName("uint32_t")]
    public uint changeControls;

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
    public ushort accessXTimeout;

    [NativeTypeName("uint32_t")]
    public uint accessXTimeoutMask;

    [NativeTypeName("uint32_t")]
    public uint accessXTimeoutValues;

    [NativeTypeName("uint16_t")]
    public ushort accessXTimeoutOptionsMask;

    [NativeTypeName("uint16_t")]
    public ushort accessXTimeoutOptionsValues;

    [NativeTypeName("uint8_t[32]")]
    public fixed byte perKeyRepeat[32];
}

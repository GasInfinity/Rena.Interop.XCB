namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_get_state_reply_t
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
    public byte mods;

    [NativeTypeName("uint8_t")]
    public byte baseMods;

    [NativeTypeName("uint8_t")]
    public byte latchedMods;

    [NativeTypeName("uint8_t")]
    public byte lockedMods;

    [NativeTypeName("uint8_t")]
    public byte group;

    [NativeTypeName("uint8_t")]
    public byte lockedGroup;

    [NativeTypeName("int16_t")]
    public short baseGroup;

    [NativeTypeName("int16_t")]
    public short latchedGroup;

    [NativeTypeName("uint8_t")]
    public byte compatState;

    [NativeTypeName("uint8_t")]
    public byte grabMods;

    [NativeTypeName("uint8_t")]
    public byte compatGrabMods;

    [NativeTypeName("uint8_t")]
    public byte lookupMods;

    [NativeTypeName("uint8_t")]
    public byte compatLookupMods;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort ptrBtnState;

    [NativeTypeName("uint8_t[6]")]
    public fixed byte pad1[6];
}

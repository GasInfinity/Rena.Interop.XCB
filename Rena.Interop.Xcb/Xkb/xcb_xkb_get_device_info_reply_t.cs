namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_get_device_info_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort present;

    [NativeTypeName("uint16_t")]
    public ushort supported;

    [NativeTypeName("uint16_t")]
    public ushort unsupported;

    [NativeTypeName("uint16_t")]
    public ushort nDeviceLedFBs;

    [NativeTypeName("uint8_t")]
    public byte firstBtnWanted;

    [NativeTypeName("uint8_t")]
    public byte nBtnsWanted;

    [NativeTypeName("uint8_t")]
    public byte firstBtnRtrn;

    [NativeTypeName("uint8_t")]
    public byte nBtnsRtrn;

    [NativeTypeName("uint8_t")]
    public byte totalBtns;

    [NativeTypeName("uint8_t")]
    public byte hasOwnState;

    [NativeTypeName("uint16_t")]
    public ushort dfltKbdFB;

    [NativeTypeName("uint16_t")]
    public ushort dfltLedFB;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("xcb_atom_t")]
    public uint devType;

    [NativeTypeName("uint16_t")]
    public ushort nameLen;
}

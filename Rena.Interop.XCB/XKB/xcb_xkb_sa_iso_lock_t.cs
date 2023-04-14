namespace Rena.Interop.XCB;

public partial struct xcb_xkb_sa_iso_lock_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint8_t")]
    public byte mask;

    [NativeTypeName("uint8_t")]
    public byte realMods;

    [NativeTypeName("int8_t")]
    public sbyte group;

    [NativeTypeName("uint8_t")]
    public byte affect;

    [NativeTypeName("uint8_t")]
    public byte vmodsHigh;

    [NativeTypeName("uint8_t")]
    public byte vmodsLow;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_sa_lock_mods_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint8_t")]
    public byte mask;

    [NativeTypeName("uint8_t")]
    public byte realMods;

    [NativeTypeName("uint8_t")]
    public byte vmodsHigh;

    [NativeTypeName("uint8_t")]
    public byte vmodsLow;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

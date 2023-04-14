namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_overlay_t
{
    [NativeTypeName("xcb_atom_t")]
    public uint name;

    [NativeTypeName("uint8_t")]
    public byte nRows;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

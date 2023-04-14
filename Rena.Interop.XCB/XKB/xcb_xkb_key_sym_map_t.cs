namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_key_sym_map_t
{
    [NativeTypeName("uint8_t[4]")]
    public fixed byte kt_index[4];

    [NativeTypeName("uint8_t")]
    public byte groupInfo;

    [NativeTypeName("uint8_t")]
    public byte width;

    [NativeTypeName("uint16_t")]
    public ushort nSyms;
}

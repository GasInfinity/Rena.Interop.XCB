namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_row_t
{
    [NativeTypeName("int16_t")]
    public short top;

    [NativeTypeName("int16_t")]
    public short left;

    [NativeTypeName("uint8_t")]
    public byte nKeys;

    [NativeTypeName("uint8_t")]
    public byte vertical;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

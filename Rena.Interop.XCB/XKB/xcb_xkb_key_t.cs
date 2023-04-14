namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_key_t
{
    [NativeTypeName("xcb_xkb_string8_t[4]")]
    public fixed sbyte name[4];

    [NativeTypeName("int16_t")]
    public short gap;

    [NativeTypeName("uint8_t")]
    public byte shapeNdx;

    [NativeTypeName("uint8_t")]
    public byte colorNdx;
}

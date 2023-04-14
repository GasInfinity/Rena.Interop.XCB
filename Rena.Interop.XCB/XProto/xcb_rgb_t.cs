namespace Rena.Interop.XCB;

public unsafe partial struct xcb_rgb_t
{
    [NativeTypeName("uint16_t")]
    public ushort red;

    [NativeTypeName("uint16_t")]
    public ushort green;

    [NativeTypeName("uint16_t")]
    public ushort blue;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

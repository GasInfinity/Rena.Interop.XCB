namespace Rena.Interop.XCB;

public unsafe partial struct xcb_setup_authenticate_t
{
    [NativeTypeName("uint8_t")]
    public byte status;

    [NativeTypeName("uint8_t[5]")]
    public fixed byte pad0[5];

    [NativeTypeName("uint16_t")]
    public ushort length;
}

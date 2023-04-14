namespace Rena.Interop.XCB;

public partial struct xcb_host_t
{
    [NativeTypeName("uint8_t")]
    public byte family;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort address_len;
}

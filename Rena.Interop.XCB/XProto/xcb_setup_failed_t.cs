namespace Rena.Interop.XCB;

public partial struct xcb_setup_failed_t
{
    [NativeTypeName("uint8_t")]
    public byte status;

    [NativeTypeName("uint8_t")]
    public byte reason_len;

    [NativeTypeName("uint16_t")]
    public ushort protocol_major_version;

    [NativeTypeName("uint16_t")]
    public ushort protocol_minor_version;

    [NativeTypeName("uint16_t")]
    public ushort length;
}

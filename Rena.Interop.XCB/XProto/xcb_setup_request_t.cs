namespace Rena.Interop.XCB;

public unsafe partial struct xcb_setup_request_t
{
    [NativeTypeName("uint8_t")]
    public byte byte_order;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort protocol_major_version;

    [NativeTypeName("uint16_t")]
    public ushort protocol_minor_version;

    [NativeTypeName("uint16_t")]
    public ushort authorization_protocol_name_len;

    [NativeTypeName("uint16_t")]
    public ushort authorization_protocol_data_len;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

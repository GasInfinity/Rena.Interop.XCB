namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_get_extension_version_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte xi_reply_type;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort server_major;

    [NativeTypeName("uint16_t")]
    public ushort server_minor;

    [NativeTypeName("uint8_t")]
    public byte present;

    [NativeTypeName("uint8_t[19]")]
    public fixed byte pad0[19];
}

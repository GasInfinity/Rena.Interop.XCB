namespace Rena.Interop.Xcb;

public partial struct xcb_xfixes_set_client_disconnect_mode_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint32_t")]
    public uint disconnect_mode;
}

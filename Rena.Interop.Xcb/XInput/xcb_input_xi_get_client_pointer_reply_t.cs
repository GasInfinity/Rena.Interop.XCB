namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_xi_get_client_pointer_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint8_t")]
    public byte set;

    [NativeTypeName("uint8_t")]
    public byte pad1;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad2[20];
}

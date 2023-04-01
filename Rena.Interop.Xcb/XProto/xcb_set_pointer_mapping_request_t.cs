namespace Rena.Interop.Xcb;

public partial struct xcb_set_pointer_mapping_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte map_len;

    [NativeTypeName("uint16_t")]
    public ushort length;
}

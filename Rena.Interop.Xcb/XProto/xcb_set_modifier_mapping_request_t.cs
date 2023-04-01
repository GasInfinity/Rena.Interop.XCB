namespace Rena.Interop.Xcb;

public partial struct xcb_set_modifier_mapping_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte keycodes_per_modifier;

    [NativeTypeName("uint16_t")]
    public ushort length;
}

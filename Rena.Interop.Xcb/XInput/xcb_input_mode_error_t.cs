namespace Rena.Interop.Xcb;

public partial struct xcb_input_mode_error_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte error_code;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint bad_value;

    [NativeTypeName("uint16_t")]
    public ushort minor_opcode;

    [NativeTypeName("uint8_t")]
    public byte major_opcode;
}

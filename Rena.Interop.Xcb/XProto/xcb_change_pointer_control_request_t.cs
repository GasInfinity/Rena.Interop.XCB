namespace Rena.Interop.Xcb;

public partial struct xcb_change_pointer_control_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("int16_t")]
    public short acceleration_numerator;

    [NativeTypeName("int16_t")]
    public short acceleration_denominator;

    [NativeTypeName("int16_t")]
    public short threshold;

    [NativeTypeName("uint8_t")]
    public byte do_acceleration;

    [NativeTypeName("uint8_t")]
    public byte do_threshold;
}

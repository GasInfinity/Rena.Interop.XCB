namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_ptr_feedback_ctl_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("int16_t")]
    public short num;

    [NativeTypeName("int16_t")]
    public short denom;

    [NativeTypeName("int16_t")]
    public short threshold;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_ptr_feedback_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("uint16_t")]
    public ushort accel_num;

    [NativeTypeName("uint16_t")]
    public ushort accel_denom;

    [NativeTypeName("uint16_t")]
    public ushort threshold;
}

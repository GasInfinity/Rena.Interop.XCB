namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_bell_feedback_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint8_t")]
    public byte percent;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];

    [NativeTypeName("uint16_t")]
    public ushort pitch;

    [NativeTypeName("uint16_t")]
    public ushort duration;
}

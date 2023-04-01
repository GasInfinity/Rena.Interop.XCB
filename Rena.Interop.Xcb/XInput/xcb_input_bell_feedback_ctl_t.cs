namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_bell_feedback_ctl_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte feedback_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("int8_t")]
    public sbyte percent;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];

    [NativeTypeName("int16_t")]
    public short pitch;

    [NativeTypeName("int16_t")]
    public short duration;
}

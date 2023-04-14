namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_get_device_focus_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte xi_reply_type;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_window_t")]
    public uint focus;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint8_t")]
    public byte revert_to;

    [NativeTypeName("uint8_t[15]")]
    public fixed byte pad0[15];
}

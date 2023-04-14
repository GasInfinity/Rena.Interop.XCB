namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_xi_get_focus_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_window_t")]
    public uint focus;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad1[20];
}

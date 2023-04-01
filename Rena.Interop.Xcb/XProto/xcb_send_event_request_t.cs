namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_send_event_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte propagate;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint destination;

    [NativeTypeName("uint32_t")]
    public uint event_mask;

    [NativeTypeName("char[32]")]
    public fixed sbyte @event[32];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_visibility_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint8_t")]
    public byte state;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad1[3];
}

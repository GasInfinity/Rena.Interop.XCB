namespace Rena.Interop.XCB;

public partial struct xcb_gravity_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint @event;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;
}

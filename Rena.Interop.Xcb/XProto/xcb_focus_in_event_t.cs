namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_focus_in_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte detail;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint @event;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

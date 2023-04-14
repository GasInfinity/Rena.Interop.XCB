namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xfixes_cursor_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte subtype;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint32_t")]
    public uint cursor_serial;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_atom_t")]
    public uint name;

    [NativeTypeName("uint8_t[12]")]
    public fixed byte pad0[12];
}

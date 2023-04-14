namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xfixes_selection_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte subtype;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_window_t")]
    public uint owner;

    [NativeTypeName("xcb_atom_t")]
    public uint selection;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_timestamp_t")]
    public uint selection_timestamp;

    [NativeTypeName("uint8_t[8]")]
    public fixed byte pad0[8];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_expose_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint16_t")]
    public ushort x;

    [NativeTypeName("uint16_t")]
    public ushort y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint16_t")]
    public ushort count;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_send_extension_event_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint destination;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t")]
    public byte propagate;

    [NativeTypeName("uint16_t")]
    public ushort num_classes;

    [NativeTypeName("uint8_t")]
    public byte num_events;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

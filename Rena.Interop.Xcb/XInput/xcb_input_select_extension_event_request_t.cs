namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_select_extension_event_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint16_t")]
    public ushort num_classes;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

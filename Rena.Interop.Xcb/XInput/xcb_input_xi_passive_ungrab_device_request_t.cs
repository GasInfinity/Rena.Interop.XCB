namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_xi_passive_ungrab_device_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint grab_window;

    [NativeTypeName("uint32_t")]
    public uint detail;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint16_t")]
    public ushort num_modifiers;

    [NativeTypeName("uint8_t")]
    public byte grab_type;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

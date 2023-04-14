namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_set_device_focus_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint focus;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint8_t")]
    public byte revert_to;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

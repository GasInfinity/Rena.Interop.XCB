namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_set_screen_config_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;

    [NativeTypeName("uint16_t")]
    public ushort sizeID;

    [NativeTypeName("uint16_t")]
    public ushort rotation;

    [NativeTypeName("uint16_t")]
    public ushort rate;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

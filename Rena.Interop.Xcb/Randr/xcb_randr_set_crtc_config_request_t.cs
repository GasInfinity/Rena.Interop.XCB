namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_set_crtc_config_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_timestamp_t")]
    public uint config_timestamp;

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("xcb_randr_mode_t")]
    public uint mode;

    [NativeTypeName("uint16_t")]
    public ushort rotation;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

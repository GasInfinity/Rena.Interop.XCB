namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xfixes_create_region_from_window_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xfixes_region_t")]
    public uint region;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_shape_kind_t")]
    public byte kind;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

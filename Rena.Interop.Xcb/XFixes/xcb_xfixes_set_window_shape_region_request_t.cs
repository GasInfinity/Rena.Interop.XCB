namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xfixes_set_window_shape_region_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint dest;

    [NativeTypeName("xcb_shape_kind_t")]
    public byte dest_kind;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];

    [NativeTypeName("int16_t")]
    public short x_offset;

    [NativeTypeName("int16_t")]
    public short y_offset;

    [NativeTypeName("xcb_xfixes_region_t")]
    public uint region;
}

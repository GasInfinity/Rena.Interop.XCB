namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_render_set_picture_filter_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_render_picture_t")]
    public uint picture;

    [NativeTypeName("uint16_t")]
    public ushort filter_len;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

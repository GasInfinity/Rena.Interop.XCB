namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_configure_window_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint16_t")]
    public ushort value_mask;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];
}

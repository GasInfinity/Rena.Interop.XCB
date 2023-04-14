namespace Rena.Interop.XCB;

public partial struct xcb_create_colormap_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte alloc;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_colormap_t")]
    public uint mid;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_visualid_t")]
    public uint visual;
}

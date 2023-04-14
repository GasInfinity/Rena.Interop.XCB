namespace Rena.Interop.XCB;

public partial struct xcb_xfixes_change_save_set_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint8_t")]
    public byte target;

    [NativeTypeName("uint8_t")]
    public byte map;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("xcb_window_t")]
    public uint window;
}

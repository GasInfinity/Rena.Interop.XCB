namespace Rena.Interop.XCB;

public partial struct xcb_input_add_master_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint16_t")]
    public ushort name_len;

    [NativeTypeName("uint8_t")]
    public byte send_core;

    [NativeTypeName("uint8_t")]
    public byte enable;
}

namespace Rena.Interop.XCB;

public partial struct xcb_randr_set_output_primary_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_randr_output_t")]
    public uint output;
}

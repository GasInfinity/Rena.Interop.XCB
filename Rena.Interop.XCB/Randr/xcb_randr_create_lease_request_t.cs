namespace Rena.Interop.XCB;

public partial struct xcb_randr_create_lease_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_randr_lease_t")]
    public uint lid;

    [NativeTypeName("uint16_t")]
    public ushort num_crtcs;

    [NativeTypeName("uint16_t")]
    public ushort num_outputs;
}

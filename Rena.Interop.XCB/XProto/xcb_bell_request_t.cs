namespace Rena.Interop.XCB;

public partial struct xcb_bell_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("int8_t")]
    public sbyte percent;

    [NativeTypeName("uint16_t")]
    public ushort length;
}

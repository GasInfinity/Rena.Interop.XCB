namespace Rena.Interop.XCB;

public partial struct xcb_allow_events_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;
}

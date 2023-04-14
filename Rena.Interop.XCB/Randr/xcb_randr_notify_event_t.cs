namespace Rena.Interop.XCB;

public partial struct xcb_randr_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte subCode;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    public xcb_randr_notify_data_t u;
}

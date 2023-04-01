namespace Rena.Interop.Xcb;

public partial struct xcb_mapping_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint8_t")]
    public byte request;

    [NativeTypeName("xcb_keycode_t")]
    public byte first_keycode;

    [NativeTypeName("uint8_t")]
    public byte count;

    [NativeTypeName("uint8_t")]
    public byte pad1;
}

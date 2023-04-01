namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_keymap_notify_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t[31]")]
    public fixed byte keys[31];
}

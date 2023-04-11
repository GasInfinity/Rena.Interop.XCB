namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_sa_action_message_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint8_t[6]")]
    public fixed byte message[6];
}

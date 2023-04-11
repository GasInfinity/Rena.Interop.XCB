namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_common_behavior_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte data;
}

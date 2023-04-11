namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_permament_radio_group_behavior_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte group;
}

namespace Rena.Interop.XCB;

public partial struct xcb_xkb_overlay_behavior_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("xcb_keycode_t")]
    public byte key;
}

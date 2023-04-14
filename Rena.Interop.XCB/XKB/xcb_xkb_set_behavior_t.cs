namespace Rena.Interop.XCB;

public partial struct xcb_xkb_set_behavior_t
{
    [NativeTypeName("xcb_keycode_t")]
    public byte keycode;

    public xcb_xkb_behavior_t behavior;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

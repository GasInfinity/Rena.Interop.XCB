namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_set_explicit_t
{
    [NativeTypeName("xcb_keycode_t")]
    public byte keycode;

    [NativeTypeName("uint8_t")]
    public byte @explicit;
}

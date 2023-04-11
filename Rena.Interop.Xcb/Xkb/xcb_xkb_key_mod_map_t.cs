namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_key_mod_map_t
{
    [NativeTypeName("xcb_keycode_t")]
    public byte keycode;

    [NativeTypeName("uint8_t")]
    public byte mods;
}

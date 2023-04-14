namespace Rena.Interop.XCB;

public partial struct xcb_xkb_key_v_mod_map_t
{
    [NativeTypeName("xcb_keycode_t")]
    public byte keycode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort vmods;
}

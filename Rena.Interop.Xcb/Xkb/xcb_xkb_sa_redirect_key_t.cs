namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_sa_redirect_key_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("xcb_keycode_t")]
    public byte newkey;

    [NativeTypeName("uint8_t")]
    public byte mask;

    [NativeTypeName("uint8_t")]
    public byte realModifiers;

    [NativeTypeName("uint8_t")]
    public byte vmodsMaskHigh;

    [NativeTypeName("uint8_t")]
    public byte vmodsMaskLow;

    [NativeTypeName("uint8_t")]
    public byte vmodsHigh;

    [NativeTypeName("uint8_t")]
    public byte vmodsLow;
}

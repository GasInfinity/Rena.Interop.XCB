namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_sym_interpret_t
{
    [NativeTypeName("xcb_keysym_t")]
    public uint sym;

    [NativeTypeName("uint8_t")]
    public byte mods;

    [NativeTypeName("uint8_t")]
    public byte match;

    [NativeTypeName("uint8_t")]
    public byte virtualMod;

    [NativeTypeName("uint8_t")]
    public byte flags;

    public xcb_xkb_si_action_t action;
}

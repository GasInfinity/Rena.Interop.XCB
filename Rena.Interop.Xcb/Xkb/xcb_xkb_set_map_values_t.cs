namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_set_map_values_t
{
    public xcb_xkb_set_key_type_t* types;

    public xcb_xkb_key_sym_map_t* syms;

    [NativeTypeName("uint8_t *")]
    public byte* actionsCount;

    public xcb_xkb_action_t* actions;

    public xcb_xkb_set_behavior_t* behaviors;

    [NativeTypeName("uint8_t *")]
    public byte* vmods;

    public xcb_xkb_set_explicit_t* @explicit;

    public xcb_xkb_key_mod_map_t* modmap;

    public xcb_xkb_key_v_mod_map_t* vmodmap;
}

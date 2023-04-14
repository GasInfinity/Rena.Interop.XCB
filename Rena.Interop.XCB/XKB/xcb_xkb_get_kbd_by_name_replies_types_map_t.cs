namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_get_kbd_by_name_replies_types_map_t
{
    public xcb_xkb_key_type_t* types_rtrn;

    public xcb_xkb_key_sym_map_t* syms_rtrn;

    [NativeTypeName("uint8_t *")]
    public byte* acts_rtrn_count;

    public xcb_xkb_action_t* acts_rtrn_acts;

    public xcb_xkb_set_behavior_t* behaviors_rtrn;

    [NativeTypeName("uint8_t *")]
    public byte* vmods_rtrn;

    public xcb_xkb_set_explicit_t* explicit_rtrn;

    public xcb_xkb_key_mod_map_t* modmap_rtrn;

    public xcb_xkb_key_v_mod_map_t* vmodmap_rtrn;
}

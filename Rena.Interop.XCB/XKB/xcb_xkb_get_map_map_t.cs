namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_get_map_map_t
{
    public xcb_xkb_key_type_t* types_rtrn;

    public xcb_xkb_key_sym_map_t* syms_rtrn;

    [NativeTypeName("uint8_t *")]
    public byte* acts_rtrn_count;

    [NativeTypeName("uint8_t *")]
    public byte* pad2;

    public xcb_xkb_action_t* acts_rtrn_acts;

    public xcb_xkb_set_behavior_t* behaviors_rtrn;

    [NativeTypeName("uint8_t *")]
    public byte* vmods_rtrn;

    [NativeTypeName("uint8_t *")]
    public byte* pad3;

    public xcb_xkb_set_explicit_t* explicit_rtrn;

    [NativeTypeName("uint8_t *")]
    public byte* pad4;

    public xcb_xkb_key_mod_map_t* modmap_rtrn;

    [NativeTypeName("uint8_t *")]
    public byte* pad5;

    public xcb_xkb_key_v_mod_map_t* vmodmap_rtrn;
}

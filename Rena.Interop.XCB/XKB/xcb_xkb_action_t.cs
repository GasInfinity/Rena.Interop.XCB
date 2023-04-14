using System.Runtime.InteropServices;

namespace Rena.Interop.XCB;

[StructLayout(LayoutKind.Explicit)]
public partial struct xcb_xkb_action_t
{
    [FieldOffset(0)]
    public xcb_xkb_sa_no_action_t noaction;

    [FieldOffset(0)]
    public xcb_xkb_sa_set_mods_t setmods;

    [FieldOffset(0)]
    public xcb_xkb_sa_latch_mods_t latchmods;

    [FieldOffset(0)]
    public xcb_xkb_sa_lock_mods_t lockmods;

    [FieldOffset(0)]
    public xcb_xkb_sa_set_group_t setgroup;

    [FieldOffset(0)]
    public xcb_xkb_sa_latch_group_t latchgroup;

    [FieldOffset(0)]
    public xcb_xkb_sa_lock_group_t lockgroup;

    [FieldOffset(0)]
    public xcb_xkb_sa_move_ptr_t moveptr;

    [FieldOffset(0)]
    public xcb_xkb_sa_ptr_btn_t ptrbtn;

    [FieldOffset(0)]
    public xcb_xkb_sa_lock_ptr_btn_t lockptrbtn;

    [FieldOffset(0)]
    public xcb_xkb_sa_set_ptr_dflt_t setptrdflt;

    [FieldOffset(0)]
    public xcb_xkb_sa_iso_lock_t isolock;

    [FieldOffset(0)]
    public xcb_xkb_sa_terminate_t terminate;

    [FieldOffset(0)]
    public xcb_xkb_sa_switch_screen_t switchscreen;

    [FieldOffset(0)]
    public xcb_xkb_sa_set_controls_t setcontrols;

    [FieldOffset(0)]
    public xcb_xkb_sa_lock_controls_t lockcontrols;

    [FieldOffset(0)]
    public xcb_xkb_sa_action_message_t message;

    [FieldOffset(0)]
    public xcb_xkb_sa_redirect_key_t redirect;

    [FieldOffset(0)]
    public xcb_xkb_sa_device_btn_t devbtn;

    [FieldOffset(0)]
    public xcb_xkb_sa_lock_device_btn_t lockdevbtn;

    [FieldOffset(0)]
    public xcb_xkb_sa_device_valuator_t devval;

    [FieldOffset(0)]
    [NativeTypeName("uint8_t")]
    public byte type;
}

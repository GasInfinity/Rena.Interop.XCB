using System.Runtime.InteropServices;

namespace Rena.Interop.XCB;

[StructLayout(LayoutKind.Explicit)]
public partial struct xcb_xkb_behavior_t
{
    [FieldOffset(0)]
    public xcb_xkb_common_behavior_t common;

    [FieldOffset(0)]
    public xcb_xkb_default_behavior_t _default;

    [FieldOffset(0)]
    public xcb_xkb_lock_behavior_t @lock;

    [FieldOffset(0)]
    public xcb_xkb_radio_group_behavior_t radioGroup;

    [FieldOffset(0)]
    public xcb_xkb_overlay_behavior_t overlay1;

    [FieldOffset(0)]
    public xcb_xkb_overlay_behavior_t overlay2;

    [FieldOffset(0)]
    public xcb_xkb_permament_lock_behavior_t permamentLock;

    [FieldOffset(0)]
    public xcb_xkb_permament_radio_group_behavior_t permamentRadioGroup;

    [FieldOffset(0)]
    public xcb_xkb_permament_overlay_behavior_t permamentOverlay1;

    [FieldOffset(0)]
    public xcb_xkb_permament_overlay_behavior_t permamentOverlay2;

    [FieldOffset(0)]
    [NativeTypeName("uint8_t")]
    public byte type;
}

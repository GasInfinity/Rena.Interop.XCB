namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_sa_move_ptr_flag_t : uint
{
    XCB_XKB_SA_MOVE_PTR_FLAG_NO_ACCELERATION = 1,
    XCB_XKB_SA_MOVE_PTR_FLAG_MOVE_ABSOLUTE_X = 2,
    XCB_XKB_SA_MOVE_PTR_FLAG_MOVE_ABSOLUTE_Y = 4,
}

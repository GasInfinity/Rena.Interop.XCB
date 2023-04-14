namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_subwindow_mode_t : uint
{
    XCB_SUBWINDOW_MODE_CLIP_BY_CHILDREN = 0,
    XCB_SUBWINDOW_MODE_INCLUDE_INFERIORS = 1,
}

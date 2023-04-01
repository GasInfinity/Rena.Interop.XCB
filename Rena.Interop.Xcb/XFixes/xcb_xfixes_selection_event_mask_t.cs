namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xfixes_selection_event_mask_t : uint
{
    XCB_XFIXES_SELECTION_EVENT_MASK_SET_SELECTION_OWNER = 1,
    XCB_XFIXES_SELECTION_EVENT_MASK_SELECTION_WINDOW_DESTROY = 2,
    XCB_XFIXES_SELECTION_EVENT_MASK_SELECTION_CLIENT_CLOSE = 4,
}

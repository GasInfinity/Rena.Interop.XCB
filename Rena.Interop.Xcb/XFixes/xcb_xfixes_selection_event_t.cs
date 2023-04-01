namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xfixes_selection_event_t : uint
{
    XCB_XFIXES_SELECTION_EVENT_SET_SELECTION_OWNER = 0,
    XCB_XFIXES_SELECTION_EVENT_SELECTION_WINDOW_DESTROY = 1,
    XCB_XFIXES_SELECTION_EVENT_SELECTION_CLIENT_CLOSE = 2,
}

namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_send_event_dest_t : uint
{
    XCB_SEND_EVENT_DEST_POINTER_WINDOW = 0,
    XCB_SEND_EVENT_DEST_ITEM_FOCUS = 1,
}

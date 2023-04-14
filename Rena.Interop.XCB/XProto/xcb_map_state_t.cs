namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_map_state_t : uint
{
    XCB_MAP_STATE_UNMAPPED = 0,
    XCB_MAP_STATE_UNVIEWABLE = 1,
    XCB_MAP_STATE_VIEWABLE = 2,
}

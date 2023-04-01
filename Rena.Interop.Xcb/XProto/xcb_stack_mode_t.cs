namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_stack_mode_t : uint
{
    XCB_STACK_MODE_ABOVE = 0,
    XCB_STACK_MODE_BELOW = 1,
    XCB_STACK_MODE_TOP_IF = 2,
    XCB_STACK_MODE_BOTTOM_IF = 3,
    XCB_STACK_MODE_OPPOSITE = 4,
}

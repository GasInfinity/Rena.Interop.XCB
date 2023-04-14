namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_focus_t : uint
{
    XCB_INPUT_FOCUS_NONE = 0,
    XCB_INPUT_FOCUS_POINTER_ROOT = 1,
    XCB_INPUT_FOCUS_PARENT = 2,
    XCB_INPUT_FOCUS_FOLLOW_KEYBOARD = 3,
}

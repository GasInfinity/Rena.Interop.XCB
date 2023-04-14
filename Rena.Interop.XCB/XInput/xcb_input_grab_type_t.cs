namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_grab_type_t : uint
{
    XCB_INPUT_GRAB_TYPE_BUTTON = 0,
    XCB_INPUT_GRAB_TYPE_KEYCODE = 1,
    XCB_INPUT_GRAB_TYPE_ENTER = 2,
    XCB_INPUT_GRAB_TYPE_FOCUS_IN = 3,
    XCB_INPUT_GRAB_TYPE_TOUCH_BEGIN = 4,
    XCB_INPUT_GRAB_TYPE_GESTURE_PINCH_BEGIN = 5,
    XCB_INPUT_GRAB_TYPE_GESTURE_SWIPE_BEGIN = 6,
}

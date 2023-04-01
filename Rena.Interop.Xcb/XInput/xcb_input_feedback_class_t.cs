namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_input_feedback_class_t : uint
{
    XCB_INPUT_FEEDBACK_CLASS_KEYBOARD = 0,
    XCB_INPUT_FEEDBACK_CLASS_POINTER = 1,
    XCB_INPUT_FEEDBACK_CLASS_STRING = 2,
    XCB_INPUT_FEEDBACK_CLASS_INTEGER = 3,
    XCB_INPUT_FEEDBACK_CLASS_LED = 4,
    XCB_INPUT_FEEDBACK_CLASS_BELL = 5,
}

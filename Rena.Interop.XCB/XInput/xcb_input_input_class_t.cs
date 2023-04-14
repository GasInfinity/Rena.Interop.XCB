namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_input_class_t : uint
{
    XCB_INPUT_INPUT_CLASS_KEY = 0,
    XCB_INPUT_INPUT_CLASS_BUTTON = 1,
    XCB_INPUT_INPUT_CLASS_VALUATOR = 2,
    XCB_INPUT_INPUT_CLASS_FEEDBACK = 3,
    XCB_INPUT_INPUT_CLASS_PROXIMITY = 4,
    XCB_INPUT_INPUT_CLASS_FOCUS = 5,
    XCB_INPUT_INPUT_CLASS_OTHER = 6,
}

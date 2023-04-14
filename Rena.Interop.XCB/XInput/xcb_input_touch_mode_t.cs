namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_touch_mode_t : uint
{
    XCB_INPUT_TOUCH_MODE_DIRECT = 1,
    XCB_INPUT_TOUCH_MODE_DEPENDENT = 2,
}

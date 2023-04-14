namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_led_class_result_t : uint
{
    XCB_XKB_LED_CLASS_RESULT_KBD_FEEDBACK_CLASS = 0,
    XCB_XKB_LED_CLASS_RESULT_LED_FEEDBACK_CLASS = 4,
}

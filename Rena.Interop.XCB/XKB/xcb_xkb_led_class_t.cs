namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_led_class_t : uint
{
    XCB_XKB_LED_CLASS_KBD_FEEDBACK_CLASS = 0,
    XCB_XKB_LED_CLASS_LED_FEEDBACK_CLASS = 4,
    XCB_XKB_LED_CLASS_DFLT_XI_CLASS = 768,
    XCB_XKB_LED_CLASS_ALL_XI_CLASSES = 1280,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_input_device_class_type_t : uint
{
    XCB_INPUT_DEVICE_CLASS_TYPE_KEY = 0,
    XCB_INPUT_DEVICE_CLASS_TYPE_BUTTON = 1,
    XCB_INPUT_DEVICE_CLASS_TYPE_VALUATOR = 2,
    XCB_INPUT_DEVICE_CLASS_TYPE_SCROLL = 3,
    XCB_INPUT_DEVICE_CLASS_TYPE_TOUCH = 8,
    XCB_INPUT_DEVICE_CLASS_TYPE_GESTURE = 9,
}

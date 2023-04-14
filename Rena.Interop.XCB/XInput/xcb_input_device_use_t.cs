namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_device_use_t : uint
{
    XCB_INPUT_DEVICE_USE_IS_X_POINTER = 0,
    XCB_INPUT_DEVICE_USE_IS_X_KEYBOARD = 1,
    XCB_INPUT_DEVICE_USE_IS_X_EXTENSION_DEVICE = 2,
    XCB_INPUT_DEVICE_USE_IS_X_EXTENSION_KEYBOARD = 3,
    XCB_INPUT_DEVICE_USE_IS_X_EXTENSION_POINTER = 4,
}

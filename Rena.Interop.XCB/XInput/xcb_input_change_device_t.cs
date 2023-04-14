namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_change_device_t : uint
{
    XCB_INPUT_CHANGE_DEVICE_NEW_POINTER = 0,
    XCB_INPUT_CHANGE_DEVICE_NEW_KEYBOARD = 1,
}

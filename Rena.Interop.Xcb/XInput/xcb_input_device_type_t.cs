namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_input_device_type_t : uint
{
    XCB_INPUT_DEVICE_TYPE_MASTER_POINTER = 1,
    XCB_INPUT_DEVICE_TYPE_MASTER_KEYBOARD = 2,
    XCB_INPUT_DEVICE_TYPE_SLAVE_POINTER = 3,
    XCB_INPUT_DEVICE_TYPE_SLAVE_KEYBOARD = 4,
    XCB_INPUT_DEVICE_TYPE_FLOATING_SLAVE = 5,
}

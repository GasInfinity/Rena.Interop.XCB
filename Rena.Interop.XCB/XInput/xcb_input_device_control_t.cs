namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_device_control_t : uint
{
    XCB_INPUT_DEVICE_CONTROL_RESOLUTION = 1,
    XCB_INPUT_DEVICE_CONTROL_ABS_CALIB = 2,
    XCB_INPUT_DEVICE_CONTROL_CORE = 3,
    XCB_INPUT_DEVICE_CONTROL_ENABLE = 4,
    XCB_INPUT_DEVICE_CONTROL_ABS_AREA = 5,
}

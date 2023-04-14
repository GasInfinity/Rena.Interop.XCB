namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_change_reason_t : uint
{
    XCB_INPUT_CHANGE_REASON_SLAVE_SWITCH = 1,
    XCB_INPUT_CHANGE_REASON_DEVICE_CHANGE = 2,
}

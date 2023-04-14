namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_propagate_mode_t : uint
{
    XCB_INPUT_PROPAGATE_MODE_ADD_TO_LIST = 0,
    XCB_INPUT_PROPAGATE_MODE_DELETE_FROM_LIST = 1,
}

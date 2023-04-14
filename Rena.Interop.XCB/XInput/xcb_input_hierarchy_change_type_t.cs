namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_input_hierarchy_change_type_t : uint
{
    XCB_INPUT_HIERARCHY_CHANGE_TYPE_ADD_MASTER = 1,
    XCB_INPUT_HIERARCHY_CHANGE_TYPE_REMOVE_MASTER = 2,
    XCB_INPUT_HIERARCHY_CHANGE_TYPE_ATTACH_SLAVE = 3,
    XCB_INPUT_HIERARCHY_CHANGE_TYPE_DETACH_SLAVE = 4,
}

namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_input_property_flag_t : uint
{
    XCB_INPUT_PROPERTY_FLAG_DELETED = 0,
    XCB_INPUT_PROPERTY_FLAG_CREATED = 1,
    XCB_INPUT_PROPERTY_FLAG_MODIFIED = 2,
}

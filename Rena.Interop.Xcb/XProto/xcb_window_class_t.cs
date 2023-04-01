namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_window_class_t : uint
{
    XCB_WINDOW_CLASS_COPY_FROM_PARENT = 0,
    XCB_WINDOW_CLASS_INPUT_OUTPUT = 1,
    XCB_WINDOW_CLASS_INPUT_ONLY = 2,
}

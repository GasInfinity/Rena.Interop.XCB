namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_input_barrier_flags_t : uint
{
    XCB_INPUT_BARRIER_FLAGS_POINTER_RELEASED = 1,
    XCB_INPUT_BARRIER_FLAGS_DEVICE_IS_GRABBED = 2,
}

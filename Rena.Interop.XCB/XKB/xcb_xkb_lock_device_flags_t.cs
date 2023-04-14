namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_lock_device_flags_t : uint
{
    XCB_XKB_LOCK_DEVICE_FLAGS_NO_LOCK = 1,
    XCB_XKB_LOCK_DEVICE_FLAGS_NO_UNLOCK = 2,
}

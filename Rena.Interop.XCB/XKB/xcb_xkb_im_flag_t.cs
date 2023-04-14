namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_im_flag_t : uint
{
    XCB_XKB_IM_FLAG_NO_EXPLICIT = 128,
    XCB_XKB_IM_FLAG_NO_AUTOMATIC = 64,
    XCB_XKB_IM_FLAG_LED_DRIVES_KB = 32,
}

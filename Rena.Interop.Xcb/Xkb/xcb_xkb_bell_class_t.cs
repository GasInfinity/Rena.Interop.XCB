namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_bell_class_t : uint
{
    XCB_XKB_BELL_CLASS_KBD_FEEDBACK_CLASS = 0,
    XCB_XKB_BELL_CLASS_BELL_FEEDBACK_CLASS = 5,
    XCB_XKB_BELL_CLASS_DFLT_XI_CLASS = 768,
}

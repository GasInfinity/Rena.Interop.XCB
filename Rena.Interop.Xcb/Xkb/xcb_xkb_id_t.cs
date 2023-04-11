namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_id_t : uint
{
    XCB_XKB_ID_USE_CORE_KBD = 256,
    XCB_XKB_ID_USE_CORE_PTR = 512,
    XCB_XKB_ID_DFLT_XI_CLASS = 768,
    XCB_XKB_ID_DFLT_XI_ID = 1024,
    XCB_XKB_ID_ALL_XI_CLASS = 1280,
    XCB_XKB_ID_ALL_XI_ID = 1536,
    XCB_XKB_ID_XI_NONE = 65280,
}

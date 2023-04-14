namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_doodad_type_t : uint
{
    XCB_XKB_DOODAD_TYPE_OUTLINE = 1,
    XCB_XKB_DOODAD_TYPE_SOLID = 2,
    XCB_XKB_DOODAD_TYPE_TEXT = 3,
    XCB_XKB_DOODAD_TYPE_INDICATOR = 4,
    XCB_XKB_DOODAD_TYPE_LOGO = 5,
}

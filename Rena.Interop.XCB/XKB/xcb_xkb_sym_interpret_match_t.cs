namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_sym_interpret_match_t : uint
{
    XCB_XKB_SYM_INTERPRET_MATCH_NONE_OF = 0,
    XCB_XKB_SYM_INTERPRET_MATCH_ANY_OF_OR_NONE = 1,
    XCB_XKB_SYM_INTERPRET_MATCH_ANY_OF = 2,
    XCB_XKB_SYM_INTERPRET_MATCH_ALL_OF = 3,
    XCB_XKB_SYM_INTERPRET_MATCH_EXACTLY = 4,
}

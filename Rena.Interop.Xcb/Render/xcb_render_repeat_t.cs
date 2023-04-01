namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_render_repeat_t : uint
{
    XCB_RENDER_REPEAT_NONE = 0,
    XCB_RENDER_REPEAT_NORMAL = 1,
    XCB_RENDER_REPEAT_PAD = 2,
    XCB_RENDER_REPEAT_REFLECT = 3,
}

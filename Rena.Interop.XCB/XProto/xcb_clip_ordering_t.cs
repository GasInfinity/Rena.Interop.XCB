namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_clip_ordering_t : uint
{
    XCB_CLIP_ORDERING_UNSORTED = 0,
    XCB_CLIP_ORDERING_Y_SORTED = 1,
    XCB_CLIP_ORDERING_YX_SORTED = 2,
    XCB_CLIP_ORDERING_YX_BANDED = 3,
}

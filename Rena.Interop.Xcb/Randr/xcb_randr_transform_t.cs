namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_randr_transform_t : uint
{
    XCB_RANDR_TRANSFORM_UNIT = 1,
    XCB_RANDR_TRANSFORM_SCALE_UP = 2,
    XCB_RANDR_TRANSFORM_SCALE_DOWN = 4,
    XCB_RANDR_TRANSFORM_PROJECTIVE = 8,
}

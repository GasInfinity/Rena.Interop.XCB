namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_randr_set_config_t : uint
{
    XCB_RANDR_SET_CONFIG_SUCCESS = 0,
    XCB_RANDR_SET_CONFIG_INVALID_CONFIG_TIME = 1,
    XCB_RANDR_SET_CONFIG_INVALID_TIME = 2,
    XCB_RANDR_SET_CONFIG_FAILED = 3,
}

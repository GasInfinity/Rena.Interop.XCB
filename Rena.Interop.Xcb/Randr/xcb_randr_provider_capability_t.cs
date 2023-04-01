namespace Rena.Interop.Xcb;

[NativeTypeName("unsigned int")]
public enum xcb_randr_provider_capability_t : uint
{
    XCB_RANDR_PROVIDER_CAPABILITY_SOURCE_OUTPUT = 1,
    XCB_RANDR_PROVIDER_CAPABILITY_SINK_OUTPUT = 2,
    XCB_RANDR_PROVIDER_CAPABILITY_SOURCE_OFFLOAD = 4,
    XCB_RANDR_PROVIDER_CAPABILITY_SINK_OFFLOAD = 8,
}

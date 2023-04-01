namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_provider_change_t
{
    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_randr_provider_t")]
    public uint provider;

    [NativeTypeName("uint8_t[16]")]
    public fixed byte pad0[16];
}

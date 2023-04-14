namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_provider_property_t
{
    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_randr_provider_t")]
    public uint provider;

    [NativeTypeName("xcb_atom_t")]
    public uint atom;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("uint8_t")]
    public byte state;

    [NativeTypeName("uint8_t[11]")]
    public fixed byte pad0[11];
}

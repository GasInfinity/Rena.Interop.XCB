namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_output_property_t
{
    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_randr_output_t")]
    public uint output;

    [NativeTypeName("xcb_atom_t")]
    public uint atom;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("uint8_t")]
    public byte status;

    [NativeTypeName("uint8_t[11]")]
    public fixed byte pad0[11];
}

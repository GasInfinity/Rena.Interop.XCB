namespace Rena.Interop.Xcb;

public partial struct xcb_randr_monitor_info_t
{
    [NativeTypeName("xcb_atom_t")]
    public uint name;

    [NativeTypeName("uint8_t")]
    public byte primary;

    [NativeTypeName("uint8_t")]
    public byte automatic;

    [NativeTypeName("uint16_t")]
    public ushort nOutput;

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("uint32_t")]
    public uint width_in_millimeters;

    [NativeTypeName("uint32_t")]
    public uint height_in_millimeters;
}

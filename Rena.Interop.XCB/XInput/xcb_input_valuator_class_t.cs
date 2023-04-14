namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_valuator_class_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort sourceid;

    [NativeTypeName("uint16_t")]
    public ushort number;

    [NativeTypeName("xcb_atom_t")]
    public uint label;

    public xcb_input_fp3232_t min;

    public xcb_input_fp3232_t max;

    public xcb_input_fp3232_t value;

    [NativeTypeName("uint32_t")]
    public uint resolution;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

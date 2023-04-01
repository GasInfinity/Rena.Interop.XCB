namespace Rena.Interop.Xcb;

public partial struct xcb_input_device_info_t
{
    [NativeTypeName("xcb_atom_t")]
    public uint device_type;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t")]
    public byte num_class_info;

    [NativeTypeName("uint8_t")]
    public byte device_use;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

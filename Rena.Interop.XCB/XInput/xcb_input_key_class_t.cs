namespace Rena.Interop.XCB;

public partial struct xcb_input_key_class_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort sourceid;

    [NativeTypeName("uint16_t")]
    public ushort num_keys;
}

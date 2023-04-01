namespace Rena.Interop.Xcb;

public partial struct xcb_input_xi_device_info_t
{
    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort attachment;

    [NativeTypeName("uint16_t")]
    public ushort num_classes;

    [NativeTypeName("uint16_t")]
    public ushort name_len;

    [NativeTypeName("uint8_t")]
    public byte enabled;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

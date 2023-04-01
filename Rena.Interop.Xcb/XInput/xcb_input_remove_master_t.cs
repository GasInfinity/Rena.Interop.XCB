namespace Rena.Interop.Xcb;

public partial struct xcb_input_remove_master_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint8_t")]
    public byte return_mode;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort return_pointer;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort return_keyboard;
}

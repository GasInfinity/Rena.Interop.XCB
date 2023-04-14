namespace Rena.Interop.XCB;

public partial struct xcb_input_attach_slave_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort master;
}

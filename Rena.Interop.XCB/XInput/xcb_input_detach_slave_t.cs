namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_detach_slave_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

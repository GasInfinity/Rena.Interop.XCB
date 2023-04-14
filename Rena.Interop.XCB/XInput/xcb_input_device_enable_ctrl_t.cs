namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_device_enable_ctrl_t
{
    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint8_t")]
    public byte enable;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

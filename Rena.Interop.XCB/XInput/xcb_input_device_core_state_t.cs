namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_device_core_state_t
{
    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint8_t")]
    public byte status;

    [NativeTypeName("uint8_t")]
    public byte iscore;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

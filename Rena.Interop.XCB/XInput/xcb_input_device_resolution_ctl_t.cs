namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_device_resolution_ctl_t
{
    [NativeTypeName("uint16_t")]
    public ushort control_id;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("uint8_t")]
    public byte first_valuator;

    [NativeTypeName("uint8_t")]
    public byte num_valuators;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

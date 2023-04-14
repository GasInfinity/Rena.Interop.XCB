namespace Rena.Interop.XCB;

public partial struct xcb_xkb_sa_device_valuator_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte device;

    [NativeTypeName("uint8_t")]
    public byte val1what;

    [NativeTypeName("uint8_t")]
    public byte val1index;

    [NativeTypeName("uint8_t")]
    public byte val1value;

    [NativeTypeName("uint8_t")]
    public byte val2what;

    [NativeTypeName("uint8_t")]
    public byte val2index;

    [NativeTypeName("uint8_t")]
    public byte val2value;
}

namespace Rena.Interop.XCB;

public partial struct xcb_input_gesture_class_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort sourceid;

    [NativeTypeName("uint8_t")]
    public byte num_touches;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

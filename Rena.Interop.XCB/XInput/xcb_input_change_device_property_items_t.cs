namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_change_device_property_items_t
{
    [NativeTypeName("uint8_t *")]
    public byte* data8;

    [NativeTypeName("uint16_t *")]
    public ushort* data16;

    [NativeTypeName("uint32_t *")]
    public uint* data32;
}

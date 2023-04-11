namespace Rena.Interop.Xcb;

public partial struct xcb_xkb_select_events_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("uint16_t")]
    public ushort affectWhich;

    [NativeTypeName("uint16_t")]
    public ushort clear;

    [NativeTypeName("uint16_t")]
    public ushort selectAll;

    [NativeTypeName("uint16_t")]
    public ushort affectMap;

    [NativeTypeName("uint16_t")]
    public ushort map;
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_get_named_indicator_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("xcb_xkb_led_class_spec_t")]
    public ushort ledClass;

    [NativeTypeName("xcb_xkb_id_spec_t")]
    public ushort ledID;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("xcb_atom_t")]
    public uint indicator;
}

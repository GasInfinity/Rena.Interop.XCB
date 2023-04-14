namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_bell_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("xcb_xkb_bell_class_spec_t")]
    public ushort bellClass;

    [NativeTypeName("xcb_xkb_id_spec_t")]
    public ushort bellID;

    [NativeTypeName("int8_t")]
    public sbyte percent;

    [NativeTypeName("uint8_t")]
    public byte forceSound;

    [NativeTypeName("uint8_t")]
    public byte eventOnly;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("int16_t")]
    public short pitch;

    [NativeTypeName("int16_t")]
    public short duration;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad1[2];

    [NativeTypeName("xcb_atom_t")]
    public uint name;

    [NativeTypeName("xcb_window_t")]
    public uint window;
}

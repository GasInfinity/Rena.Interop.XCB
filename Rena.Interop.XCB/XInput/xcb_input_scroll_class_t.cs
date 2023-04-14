namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_scroll_class_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort sourceid;

    [NativeTypeName("uint16_t")]
    public ushort number;

    [NativeTypeName("uint16_t")]
    public ushort scroll_type;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("uint32_t")]
    public uint flags;

    public xcb_input_fp3232_t increment;
}

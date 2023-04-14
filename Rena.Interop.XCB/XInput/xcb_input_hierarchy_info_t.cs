namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_hierarchy_info_t
{
    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort attachment;

    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte enabled;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("uint32_t")]
    public uint flags;
}

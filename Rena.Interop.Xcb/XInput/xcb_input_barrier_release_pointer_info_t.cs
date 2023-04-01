namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_barrier_release_pointer_info_t
{
    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("xcb_xfixes_barrier_t")]
    public uint barrier;

    [NativeTypeName("uint32_t")]
    public uint eventid;
}

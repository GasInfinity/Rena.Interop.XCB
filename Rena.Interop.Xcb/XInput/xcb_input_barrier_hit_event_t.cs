namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_barrier_hit_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte extension;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort event_type;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("uint32_t")]
    public uint eventid;

    [NativeTypeName("xcb_window_t")]
    public uint root;

    [NativeTypeName("xcb_window_t")]
    public uint @event;

    [NativeTypeName("xcb_xfixes_barrier_t")]
    public uint barrier;

    [NativeTypeName("uint32_t")]
    public uint full_sequence;

    [NativeTypeName("uint32_t")]
    public uint dtime;

    [NativeTypeName("uint32_t")]
    public uint flags;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort sourceid;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("xcb_input_fp1616_t")]
    public int root_x;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int root_y;

    public xcb_input_fp3232_t dx;

    public xcb_input_fp3232_t dy;
}

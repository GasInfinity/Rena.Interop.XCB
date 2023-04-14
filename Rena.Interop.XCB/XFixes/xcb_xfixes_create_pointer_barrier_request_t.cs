namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xfixes_create_pointer_barrier_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xfixes_barrier_t")]
    public uint barrier;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("uint16_t")]
    public ushort x1;

    [NativeTypeName("uint16_t")]
    public ushort y1;

    [NativeTypeName("uint16_t")]
    public ushort x2;

    [NativeTypeName("uint16_t")]
    public ushort y2;

    [NativeTypeName("uint32_t")]
    public uint directions;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("uint16_t")]
    public ushort num_devices;
}

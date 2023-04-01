namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_query_pointer_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte same_screen;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_window_t")]
    public uint root;

    [NativeTypeName("xcb_window_t")]
    public uint child;

    [NativeTypeName("int16_t")]
    public short root_x;

    [NativeTypeName("int16_t")]
    public short root_y;

    [NativeTypeName("int16_t")]
    public short win_x;

    [NativeTypeName("int16_t")]
    public short win_y;

    [NativeTypeName("uint16_t")]
    public ushort mask;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

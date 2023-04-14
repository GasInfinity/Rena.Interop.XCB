namespace Rena.Interop.XCB;

public unsafe partial struct xcb_randr_crtc_change_t
{
    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_randr_crtc_t")]
    public uint crtc;

    [NativeTypeName("xcb_randr_mode_t")]
    public uint mode;

    [NativeTypeName("uint16_t")]
    public ushort rotation;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;
}

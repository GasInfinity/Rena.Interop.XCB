namespace Rena.Interop.XCB;

public partial struct xcb_timecoord_t
{
    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;
}

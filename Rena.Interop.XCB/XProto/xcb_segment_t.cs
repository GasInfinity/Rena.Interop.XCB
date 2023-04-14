namespace Rena.Interop.XCB;

public partial struct xcb_segment_t
{
    [NativeTypeName("int16_t")]
    public short x1;

    [NativeTypeName("int16_t")]
    public short y1;

    [NativeTypeName("int16_t")]
    public short x2;

    [NativeTypeName("int16_t")]
    public short y2;
}

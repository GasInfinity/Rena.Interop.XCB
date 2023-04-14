namespace Rena.Interop.XCB;

public partial struct xcb_arc_t
{
    [NativeTypeName("int16_t")]
    public short x;

    [NativeTypeName("int16_t")]
    public short y;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;

    [NativeTypeName("int16_t")]
    public short angle1;

    [NativeTypeName("int16_t")]
    public short angle2;
}

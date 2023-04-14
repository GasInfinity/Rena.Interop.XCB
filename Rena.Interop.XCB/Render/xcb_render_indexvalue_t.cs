namespace Rena.Interop.XCB;

public partial struct xcb_render_indexvalue_t
{
    [NativeTypeName("uint32_t")]
    public uint pixel;

    [NativeTypeName("uint16_t")]
    public ushort red;

    [NativeTypeName("uint16_t")]
    public ushort green;

    [NativeTypeName("uint16_t")]
    public ushort blue;

    [NativeTypeName("uint16_t")]
    public ushort alpha;
}

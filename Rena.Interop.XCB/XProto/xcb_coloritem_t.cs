namespace Rena.Interop.XCB;

public partial struct xcb_coloritem_t
{
    [NativeTypeName("uint32_t")]
    public uint pixel;

    [NativeTypeName("uint16_t")]
    public ushort red;

    [NativeTypeName("uint16_t")]
    public ushort green;

    [NativeTypeName("uint16_t")]
    public ushort blue;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

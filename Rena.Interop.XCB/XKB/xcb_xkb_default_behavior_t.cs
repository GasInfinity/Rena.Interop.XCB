namespace Rena.Interop.XCB;

public partial struct xcb_xkb_default_behavior_t
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte pad0;
}

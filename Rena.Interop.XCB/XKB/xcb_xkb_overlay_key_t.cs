namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_overlay_key_t
{
    [NativeTypeName("xcb_xkb_string8_t[4]")]
    public fixed sbyte over[4];

    [NativeTypeName("xcb_xkb_string8_t[4]")]
    public fixed sbyte under[4];
}

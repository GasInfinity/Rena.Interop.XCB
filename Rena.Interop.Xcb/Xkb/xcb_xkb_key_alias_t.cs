namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_key_alias_t
{
    [NativeTypeName("char[4]")]
    public fixed sbyte real[4];

    [NativeTypeName("char[4]")]
    public fixed sbyte alias[4];
}

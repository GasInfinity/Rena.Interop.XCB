namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_key_name_t
{
    [NativeTypeName("char[4]")]
    public fixed sbyte name[4];
}

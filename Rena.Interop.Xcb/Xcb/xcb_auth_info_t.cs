namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_auth_info_t
{
    public int namelen;

    [NativeTypeName("char *")]
    public sbyte* name;

    public int datalen;

    [NativeTypeName("char *")]
    public sbyte* data;
}

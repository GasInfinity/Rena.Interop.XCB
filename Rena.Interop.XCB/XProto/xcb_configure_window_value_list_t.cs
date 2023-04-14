namespace Rena.Interop.XCB;

public partial struct xcb_configure_window_value_list_t
{
    [NativeTypeName("int32_t")]
    public int x;

    [NativeTypeName("int32_t")]
    public int y;

    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("uint32_t")]
    public uint border_width;

    [NativeTypeName("xcb_window_t")]
    public uint sibling;

    [NativeTypeName("uint32_t")]
    public uint stack_mode;
}

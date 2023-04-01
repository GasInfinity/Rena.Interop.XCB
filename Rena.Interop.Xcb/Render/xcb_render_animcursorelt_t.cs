namespace Rena.Interop.Xcb;

public partial struct xcb_render_animcursorelt_t
{
    [NativeTypeName("xcb_cursor_t")]
    public uint cursor;

    [NativeTypeName("uint32_t")]
    public uint delay;
}

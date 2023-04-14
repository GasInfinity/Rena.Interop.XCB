namespace Rena.Interop.XCB;

public partial struct xcb_input_xi_query_pointer_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_window_t")]
    public uint root;

    [NativeTypeName("xcb_window_t")]
    public uint child;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int root_x;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int root_y;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int win_x;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int win_y;

    [NativeTypeName("uint8_t")]
    public byte same_screen;

    [NativeTypeName("uint8_t")]
    public byte pad1;

    [NativeTypeName("uint16_t")]
    public ushort buttons_len;

    public xcb_input_modifier_info_t mods;

    public xcb_input_group_info_t group;
}

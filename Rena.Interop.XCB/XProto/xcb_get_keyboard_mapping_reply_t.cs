namespace Rena.Interop.XCB;

public unsafe partial struct xcb_get_keyboard_mapping_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte keysyms_per_keycode;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint8_t[24]")]
    public fixed byte pad0[24];
}

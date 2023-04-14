namespace Rena.Interop.XCB;

public unsafe partial struct xcb_ungrab_key_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("xcb_keycode_t")]
    public byte key;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_window_t")]
    public uint grab_window;

    [NativeTypeName("uint16_t")]
    public ushort modifiers;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

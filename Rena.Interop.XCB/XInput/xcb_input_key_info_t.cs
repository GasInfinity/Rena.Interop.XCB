namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_key_info_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte len;

    [NativeTypeName("xcb_input_key_code_t")]
    public byte min_keycode;

    [NativeTypeName("xcb_input_key_code_t")]
    public byte max_keycode;

    [NativeTypeName("uint16_t")]
    public ushort num_keys;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_key_state_t
{
    [NativeTypeName("uint8_t")]
    public byte class_id;

    [NativeTypeName("uint8_t")]
    public byte len;

    [NativeTypeName("uint8_t")]
    public byte num_keys;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint8_t[32]")]
    public fixed byte keys[32];
}

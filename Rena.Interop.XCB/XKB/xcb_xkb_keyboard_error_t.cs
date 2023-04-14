namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_keyboard_error_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte error_code;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint value;

    [NativeTypeName("uint16_t")]
    public ushort minorOpcode;

    [NativeTypeName("uint8_t")]
    public byte majorOpcode;

    [NativeTypeName("uint8_t[21]")]
    public fixed byte pad0[21];
}

namespace Rena.Interop.XCB;

public unsafe partial struct xcb_input_grab_modifier_info_t
{
    [NativeTypeName("uint32_t")]
    public uint modifiers;

    [NativeTypeName("uint8_t")]
    public byte status;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}

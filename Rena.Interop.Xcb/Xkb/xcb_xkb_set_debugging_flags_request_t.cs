namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_set_debugging_flags_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("uint16_t")]
    public ushort msgLength;

    [NativeTypeName("uint8_t[2]")]
    public fixed byte pad0[2];

    [NativeTypeName("uint32_t")]
    public uint affectFlags;

    [NativeTypeName("uint32_t")]
    public uint flags;

    [NativeTypeName("uint32_t")]
    public uint affectCtrls;

    [NativeTypeName("uint32_t")]
    public uint ctrls;
}

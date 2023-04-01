namespace Rena.Interop.Xcb;

public partial struct xcb_no_exposure_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_drawable_t")]
    public uint drawable;

    [NativeTypeName("uint16_t")]
    public ushort minor_opcode;

    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte pad1;
}

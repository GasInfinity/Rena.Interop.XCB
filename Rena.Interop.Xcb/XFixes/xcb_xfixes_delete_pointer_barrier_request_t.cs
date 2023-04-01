namespace Rena.Interop.Xcb;

public partial struct xcb_xfixes_delete_pointer_barrier_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xfixes_barrier_t")]
    public uint barrier;
}

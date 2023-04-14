namespace Rena.Interop.XCB;

public partial struct xcb_xkb_latch_lock_state_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xkb_device_spec_t")]
    public ushort deviceSpec;

    [NativeTypeName("uint8_t")]
    public byte affectModLocks;

    [NativeTypeName("uint8_t")]
    public byte modLocks;

    [NativeTypeName("uint8_t")]
    public byte lockGroup;

    [NativeTypeName("uint8_t")]
    public byte groupLock;

    [NativeTypeName("uint8_t")]
    public byte affectModLatches;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint8_t")]
    public byte pad1;

    [NativeTypeName("uint8_t")]
    public byte latchGroup;

    [NativeTypeName("uint16_t")]
    public ushort groupLatch;
}

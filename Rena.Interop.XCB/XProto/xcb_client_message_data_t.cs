using System.Runtime.InteropServices;

namespace Rena.Interop.XCB;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct xcb_client_message_data_t
{
    [FieldOffset(0)]
    [NativeTypeName("uint8_t[20]")]
    public fixed byte data8[20];

    [FieldOffset(0)]
    [NativeTypeName("uint16_t[10]")]
    public fixed ushort data16[10];

    [FieldOffset(0)]
    [NativeTypeName("uint32_t[5]")]
    public fixed uint data32[5];
}

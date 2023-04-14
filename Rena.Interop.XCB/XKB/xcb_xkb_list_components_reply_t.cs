namespace Rena.Interop.XCB;

public unsafe partial struct xcb_xkb_list_components_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte deviceID;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort nKeymaps;

    [NativeTypeName("uint16_t")]
    public ushort nKeycodes;

    [NativeTypeName("uint16_t")]
    public ushort nTypes;

    [NativeTypeName("uint16_t")]
    public ushort nCompatMaps;

    [NativeTypeName("uint16_t")]
    public ushort nSymbols;

    [NativeTypeName("uint16_t")]
    public ushort nGeometries;

    [NativeTypeName("uint16_t")]
    public ushort extra;

    [NativeTypeName("uint8_t[10]")]
    public fixed byte pad0[10];
}

namespace Rena.Interop.XCB;

public partial struct xcb_xkb_select_events_details_t
{
    [NativeTypeName("uint16_t")]
    public ushort affectNewKeyboard;

    [NativeTypeName("uint16_t")]
    public ushort newKeyboardDetails;

    [NativeTypeName("uint16_t")]
    public ushort affectState;

    [NativeTypeName("uint16_t")]
    public ushort stateDetails;

    [NativeTypeName("uint32_t")]
    public uint affectCtrls;

    [NativeTypeName("uint32_t")]
    public uint ctrlDetails;

    [NativeTypeName("uint32_t")]
    public uint affectIndicatorState;

    [NativeTypeName("uint32_t")]
    public uint indicatorStateDetails;

    [NativeTypeName("uint32_t")]
    public uint affectIndicatorMap;

    [NativeTypeName("uint32_t")]
    public uint indicatorMapDetails;

    [NativeTypeName("uint16_t")]
    public ushort affectNames;

    [NativeTypeName("uint16_t")]
    public ushort namesDetails;

    [NativeTypeName("uint8_t")]
    public byte affectCompat;

    [NativeTypeName("uint8_t")]
    public byte compatDetails;

    [NativeTypeName("uint8_t")]
    public byte affectBell;

    [NativeTypeName("uint8_t")]
    public byte bellDetails;

    [NativeTypeName("uint8_t")]
    public byte affectMsgDetails;

    [NativeTypeName("uint8_t")]
    public byte msgDetails;

    [NativeTypeName("uint16_t")]
    public ushort affectAccessX;

    [NativeTypeName("uint16_t")]
    public ushort accessXDetails;

    [NativeTypeName("uint16_t")]
    public ushort affectExtDev;

    [NativeTypeName("uint16_t")]
    public ushort extdevDetails;
}

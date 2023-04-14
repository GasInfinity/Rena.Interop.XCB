namespace Rena.Interop.XCB;

public partial struct xcb_input_hierarchy_change_t
{
    [NativeTypeName("uint16_t")]
    public ushort type;

    [NativeTypeName("uint16_t")]
    public ushort len;
}

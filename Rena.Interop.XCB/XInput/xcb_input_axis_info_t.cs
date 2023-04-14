namespace Rena.Interop.XCB;

public partial struct xcb_input_axis_info_t
{
    [NativeTypeName("uint32_t")]
    public uint resolution;

    [NativeTypeName("int32_t")]
    public int minimum;

    [NativeTypeName("int32_t")]
    public int maximum;
}

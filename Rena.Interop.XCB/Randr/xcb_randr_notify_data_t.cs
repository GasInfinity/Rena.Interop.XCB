using System.Runtime.InteropServices;

namespace Rena.Interop.XCB;

[StructLayout(LayoutKind.Explicit)]
public partial struct xcb_randr_notify_data_t
{
    [FieldOffset(0)]
    public xcb_randr_crtc_change_t cc;

    [FieldOffset(0)]
    public xcb_randr_output_change_t oc;

    [FieldOffset(0)]
    public xcb_randr_output_property_t op;

    [FieldOffset(0)]
    public xcb_randr_provider_change_t pc;

    [FieldOffset(0)]
    public xcb_randr_provider_property_t pp;

    [FieldOffset(0)]
    public xcb_randr_resource_change_t rc;

    [FieldOffset(0)]
    public xcb_randr_lease_notify_t lc;
}

namespace Rena.Interop.Xcb;

public partial struct xcb_client_message_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte format;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("xcb_window_t")]
    public uint window;

    [NativeTypeName("xcb_atom_t")]
    public uint type;

    public xcb_client_message_data_t data;
}

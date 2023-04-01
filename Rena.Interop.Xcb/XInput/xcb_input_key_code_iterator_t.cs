namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_key_code_iterator_t
{
    [NativeTypeName("xcb_input_key_code_t *")]
    public byte* data;

    public int rem;

    public int index;
}

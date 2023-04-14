namespace Rena.Interop.XCB;

public partial struct xcb_input_input_state_data_t
{
    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1590:5)")]
    public _key_e__Struct key;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1595:5)")]
    public _button_e__Struct button;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1600:5)")]
    public _valuator_e__Struct valuator;

    public unsafe partial struct _key_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte num_keys;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint8_t[32]")]
        public fixed byte keys[32];
    }

    public unsafe partial struct _button_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte num_buttons;

        [NativeTypeName("uint8_t")]
        public byte pad1;

        [NativeTypeName("uint8_t[32]")]
        public fixed byte buttons[32];
    }

    public unsafe partial struct _valuator_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte num_valuators;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("int32_t *")]
        public int* valuators;
    }
}

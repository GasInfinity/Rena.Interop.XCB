namespace Rena.Interop.XCB;

public partial struct xcb_input_input_info_info_t
{
    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:247:5)")]
    public _key_e__Struct key;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:253:5)")]
    public _button_e__Struct button;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:256:5)")]
    public _valuator_e__Struct valuator;

    public unsafe partial struct _key_e__Struct
    {
        [NativeTypeName("xcb_input_key_code_t")]
        public byte min_keycode;

        [NativeTypeName("xcb_input_key_code_t")]
        public byte max_keycode;

        [NativeTypeName("uint16_t")]
        public ushort num_keys;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public partial struct _button_e__Struct
    {
        [NativeTypeName("uint16_t")]
        public ushort num_buttons;
    }

    public unsafe partial struct _valuator_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte axes_len;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint32_t")]
        public uint motion_size;

        public xcb_input_axis_info_t* axes;
    }
}

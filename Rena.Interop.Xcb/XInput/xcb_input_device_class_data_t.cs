namespace Rena.Interop.Xcb;

public partial struct xcb_input_device_class_data_t
{
    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2832:5)")]
    public _key_e__Struct key;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2836:5)")]
    public _button_e__Struct button;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2841:5)")]
    public _valuator_e__Struct valuator;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2851:5)")]
    public _scroll_e__Struct scroll;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2858:5)")]
    public _touch_e__Struct touch;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2862:5)")]
    public _gesture_e__Struct gesture;

    public unsafe partial struct _key_e__Struct
    {
        [NativeTypeName("uint16_t")]
        public ushort num_keys;

        [NativeTypeName("uint32_t *")]
        public uint* keys;
    }

    public unsafe partial struct _button_e__Struct
    {
        [NativeTypeName("uint16_t")]
        public ushort num_buttons;

        [NativeTypeName("uint32_t *")]
        public uint* state;

        [NativeTypeName("xcb_atom_t *")]
        public uint* labels;
    }

    public unsafe partial struct _valuator_e__Struct
    {
        [NativeTypeName("uint16_t")]
        public ushort number;

        [NativeTypeName("xcb_atom_t")]
        public uint label;

        public xcb_input_fp3232_t min;

        public xcb_input_fp3232_t max;

        public xcb_input_fp3232_t value;

        [NativeTypeName("uint32_t")]
        public uint resolution;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad0[3];
    }

    public unsafe partial struct _scroll_e__Struct
    {
        [NativeTypeName("uint16_t")]
        public ushort number;

        [NativeTypeName("uint16_t")]
        public ushort scroll_type;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];

        [NativeTypeName("uint32_t")]
        public uint flags;

        public xcb_input_fp3232_t increment;
    }

    public partial struct _touch_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint8_t")]
        public byte num_touches;
    }

    public partial struct _gesture_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte num_touches;

        [NativeTypeName("uint8_t")]
        public byte pad2;
    }
}

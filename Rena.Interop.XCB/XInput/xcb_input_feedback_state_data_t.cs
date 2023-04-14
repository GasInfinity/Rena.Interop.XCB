namespace Rena.Interop.XCB;

public partial struct xcb_input_feedback_state_data_t
{
    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1022:5)")]
    public _keyboard_e__Struct keyboard;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1033:5)")]
    public _pointer_e__Struct pointer;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1039:5)")]
    public _string_e__Struct @string;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1044:5)")]
    public _integer_e__Struct integer;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1049:5)")]
    public _led_e__Struct led;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1053:5)")]
    public _bell_e__Struct bell;

    public unsafe partial struct _keyboard_e__Struct
    {
        [NativeTypeName("uint16_t")]
        public ushort pitch;

        [NativeTypeName("uint16_t")]
        public ushort duration;

        [NativeTypeName("uint32_t")]
        public uint led_mask;

        [NativeTypeName("uint32_t")]
        public uint led_values;

        [NativeTypeName("uint8_t")]
        public byte global_auto_repeat;

        [NativeTypeName("uint8_t")]
        public byte click;

        [NativeTypeName("uint8_t")]
        public byte percent;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint8_t[32]")]
        public fixed byte auto_repeats[32];
    }

    public unsafe partial struct _pointer_e__Struct
    {
        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];

        [NativeTypeName("uint16_t")]
        public ushort accel_num;

        [NativeTypeName("uint16_t")]
        public ushort accel_denom;

        [NativeTypeName("uint16_t")]
        public ushort threshold;
    }

    public unsafe partial struct _string_e__Struct
    {
        [NativeTypeName("uint16_t")]
        public ushort max_symbols;

        [NativeTypeName("uint16_t")]
        public ushort num_keysyms;

        [NativeTypeName("xcb_keysym_t *")]
        public uint* keysyms;
    }

    public partial struct _integer_e__Struct
    {
        [NativeTypeName("uint32_t")]
        public uint resolution;

        [NativeTypeName("int32_t")]
        public int min_value;

        [NativeTypeName("int32_t")]
        public int max_value;
    }

    public partial struct _led_e__Struct
    {
        [NativeTypeName("uint32_t")]
        public uint led_mask;

        [NativeTypeName("uint32_t")]
        public uint led_values;
    }

    public unsafe partial struct _bell_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte percent;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad2[3];

        [NativeTypeName("uint16_t")]
        public ushort pitch;

        [NativeTypeName("uint16_t")]
        public ushort duration;
    }
}

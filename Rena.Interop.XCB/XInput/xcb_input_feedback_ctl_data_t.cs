namespace Rena.Interop.XCB;

public partial struct xcb_input_feedback_ctl_data_t
{
    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1248:5)")]
    public _keyboard_e__Struct keyboard;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1258:5)")]
    public _pointer_e__Struct pointer;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1264:5)")]
    public _string_e__Struct @string;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1269:5)")]
    public _integer_e__Struct integer;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1272:5)")]
    public _led_e__Struct led;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1276:5)")]
    public _bell_e__Struct bell;

    public partial struct _keyboard_e__Struct
    {
        [NativeTypeName("xcb_input_key_code_t")]
        public byte key;

        [NativeTypeName("uint8_t")]
        public byte auto_repeat_mode;

        [NativeTypeName("int8_t")]
        public sbyte key_click_percent;

        [NativeTypeName("int8_t")]
        public sbyte bell_percent;

        [NativeTypeName("int16_t")]
        public short bell_pitch;

        [NativeTypeName("int16_t")]
        public short bell_duration;

        [NativeTypeName("uint32_t")]
        public uint led_mask;

        [NativeTypeName("uint32_t")]
        public uint led_values;
    }

    public unsafe partial struct _pointer_e__Struct
    {
        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];

        [NativeTypeName("int16_t")]
        public short num;

        [NativeTypeName("int16_t")]
        public short denom;

        [NativeTypeName("int16_t")]
        public short threshold;
    }

    public unsafe partial struct _string_e__Struct
    {
        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];

        [NativeTypeName("uint16_t")]
        public ushort num_keysyms;

        [NativeTypeName("xcb_keysym_t *")]
        public uint* keysyms;
    }

    public partial struct _integer_e__Struct
    {
        [NativeTypeName("int32_t")]
        public int int_to_display;
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
        [NativeTypeName("int8_t")]
        public sbyte percent;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad2[3];

        [NativeTypeName("int16_t")]
        public short pitch;

        [NativeTypeName("int16_t")]
        public short duration;
    }
}

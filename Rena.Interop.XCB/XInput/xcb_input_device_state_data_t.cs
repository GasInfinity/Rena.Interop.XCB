namespace Rena.Interop.XCB;

public partial struct xcb_input_device_state_data_t
{
    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1828:5)")]
    public _resolution_e__Struct resolution;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1834:5)")]
    public _abs_calib_e__Struct abs_calib;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1844:5)")]
    public _core_e__Struct core;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1849:5)")]
    public _enable_e__Struct enable;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:1853:5)")]
    public _abs_area_e__Struct abs_area;

    public unsafe partial struct _resolution_e__Struct
    {
        [NativeTypeName("uint32_t")]
        public uint num_valuators;

        [NativeTypeName("uint32_t *")]
        public uint* resolution_values;

        [NativeTypeName("uint32_t *")]
        public uint* resolution_min;

        [NativeTypeName("uint32_t *")]
        public uint* resolution_max;
    }

    public partial struct _abs_calib_e__Struct
    {
        [NativeTypeName("int32_t")]
        public int min_x;

        [NativeTypeName("int32_t")]
        public int max_x;

        [NativeTypeName("int32_t")]
        public int min_y;

        [NativeTypeName("int32_t")]
        public int max_y;

        [NativeTypeName("uint32_t")]
        public uint flip_x;

        [NativeTypeName("uint32_t")]
        public uint flip_y;

        [NativeTypeName("uint32_t")]
        public uint rotation;

        [NativeTypeName("uint32_t")]
        public uint button_threshold;
    }

    public unsafe partial struct _core_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte status;

        [NativeTypeName("uint8_t")]
        public byte iscore;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public unsafe partial struct _enable_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte enable;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad1[3];
    }

    public partial struct _abs_area_e__Struct
    {
        [NativeTypeName("uint32_t")]
        public uint offset_x;

        [NativeTypeName("uint32_t")]
        public uint offset_y;

        [NativeTypeName("uint32_t")]
        public uint width;

        [NativeTypeName("uint32_t")]
        public uint height;

        [NativeTypeName("uint32_t")]
        public uint screen;

        [NativeTypeName("uint32_t")]
        public uint following;
    }
}

namespace Rena.Interop.Xcb;

public partial struct xcb_input_hierarchy_change_data_t
{
    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2468:5)")]
    public _add_master_e__Struct add_master;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2474:5)")]
    public _remove_master_e__Struct remove_master;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2481:5)")]
    public _attach_slave_e__Struct attach_slave;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xinput.h:2485:5)")]
    public _detach_slave_e__Struct detach_slave;

    public unsafe partial struct _add_master_e__Struct
    {
        [NativeTypeName("uint16_t")]
        public ushort name_len;

        [NativeTypeName("uint8_t")]
        public byte send_core;

        [NativeTypeName("uint8_t")]
        public byte enable;

        [NativeTypeName("char *")]
        public sbyte* name;
    }

    public partial struct _remove_master_e__Struct
    {
        [NativeTypeName("xcb_input_device_id_t")]
        public ushort deviceid;

        [NativeTypeName("uint8_t")]
        public byte return_mode;

        [NativeTypeName("uint8_t")]
        public byte pad1;

        [NativeTypeName("xcb_input_device_id_t")]
        public ushort return_pointer;

        [NativeTypeName("xcb_input_device_id_t")]
        public ushort return_keyboard;
    }

    public partial struct _attach_slave_e__Struct
    {
        [NativeTypeName("xcb_input_device_id_t")]
        public ushort deviceid;

        [NativeTypeName("xcb_input_device_id_t")]
        public ushort master;
    }

    public unsafe partial struct _detach_slave_e__Struct
    {
        [NativeTypeName("xcb_input_device_id_t")]
        public ushort deviceid;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad2[2];
    }
}

namespace Rena.Interop.XCB;

public partial struct xcb_xkb_get_kbd_by_name_replies_t
{
    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xkb.h:2529:5)")]
    public _types_e__Struct types;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xkb.h:2563:5)")]
    public _compat_map_e__Struct compat_map;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xkb.h:2577:5)")]
    public _indicator_maps_e__Struct indicator_maps;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xkb.h:2588:5)")]
    public _key_names_e__Struct key_names;

    [NativeTypeName("struct (anonymous struct at /usr/include/xcb/xkb.h:2608:5)")]
    public _geometry_e__Struct geometry;

    public unsafe partial struct _types_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte getmap_type;

        [NativeTypeName("uint8_t")]
        public byte typeDeviceID;

        [NativeTypeName("uint16_t")]
        public ushort getmap_sequence;

        [NativeTypeName("uint32_t")]
        public uint getmap_length;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];

        [NativeTypeName("xcb_keycode_t")]
        public byte typeMinKeyCode;

        [NativeTypeName("xcb_keycode_t")]
        public byte typeMaxKeyCode;

        [NativeTypeName("uint16_t")]
        public ushort present;

        [NativeTypeName("uint8_t")]
        public byte firstType;

        [NativeTypeName("uint8_t")]
        public byte nTypes;

        [NativeTypeName("uint8_t")]
        public byte totalTypes;

        [NativeTypeName("xcb_keycode_t")]
        public byte firstKeySym;

        [NativeTypeName("uint16_t")]
        public ushort totalSyms;

        [NativeTypeName("uint8_t")]
        public byte nKeySyms;

        [NativeTypeName("xcb_keycode_t")]
        public byte firstKeyAction;

        [NativeTypeName("uint16_t")]
        public ushort totalActions;

        [NativeTypeName("uint8_t")]
        public byte nKeyActions;

        [NativeTypeName("xcb_keycode_t")]
        public byte firstKeyBehavior;

        [NativeTypeName("uint8_t")]
        public byte nKeyBehaviors;

        [NativeTypeName("uint8_t")]
        public byte totalKeyBehaviors;

        [NativeTypeName("xcb_keycode_t")]
        public byte firstKeyExplicit;

        [NativeTypeName("uint8_t")]
        public byte nKeyExplicit;

        [NativeTypeName("uint8_t")]
        public byte totalKeyExplicit;

        [NativeTypeName("xcb_keycode_t")]
        public byte firstModMapKey;

        [NativeTypeName("uint8_t")]
        public byte nModMapKeys;

        [NativeTypeName("uint8_t")]
        public byte totalModMapKeys;

        [NativeTypeName("xcb_keycode_t")]
        public byte firstVModMapKey;

        [NativeTypeName("uint8_t")]
        public byte nVModMapKeys;

        [NativeTypeName("uint8_t")]
        public byte totalVModMapKeys;

        [NativeTypeName("uint8_t")]
        public byte pad2;

        [NativeTypeName("uint16_t")]
        public ushort virtualMods;

        public xcb_xkb_get_kbd_by_name_replies_types_map_t map;
    }

    public unsafe partial struct _compat_map_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte compatmap_type;

        [NativeTypeName("uint8_t")]
        public byte compatDeviceID;

        [NativeTypeName("uint16_t")]
        public ushort compatmap_sequence;

        [NativeTypeName("uint32_t")]
        public uint compatmap_length;

        [NativeTypeName("uint8_t")]
        public byte groupsRtrn;

        [NativeTypeName("uint8_t")]
        public byte pad7;

        [NativeTypeName("uint16_t")]
        public ushort firstSIRtrn;

        [NativeTypeName("uint16_t")]
        public ushort nSIRtrn;

        [NativeTypeName("uint16_t")]
        public ushort nTotalSI;

        [NativeTypeName("uint8_t[16]")]
        public fixed byte pad8[16];

        public xcb_xkb_sym_interpret_t* si_rtrn;

        public xcb_xkb_mod_def_t* group_rtrn;
    }

    public unsafe partial struct _indicator_maps_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte indicatormap_type;

        [NativeTypeName("uint8_t")]
        public byte indicatorDeviceID;

        [NativeTypeName("uint16_t")]
        public ushort indicatormap_sequence;

        [NativeTypeName("uint32_t")]
        public uint indicatormap_length;

        [NativeTypeName("uint32_t")]
        public uint which;

        [NativeTypeName("uint32_t")]
        public uint realIndicators;

        [NativeTypeName("uint8_t")]
        public byte nIndicators;

        [NativeTypeName("uint8_t[15]")]
        public fixed byte pad9[15];

        public xcb_xkb_indicator_map_t* maps;
    }

    public unsafe partial struct _key_names_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte keyname_type;

        [NativeTypeName("uint8_t")]
        public byte keyDeviceID;

        [NativeTypeName("uint16_t")]
        public ushort keyname_sequence;

        [NativeTypeName("uint32_t")]
        public uint keyname_length;

        [NativeTypeName("uint32_t")]
        public uint which;

        [NativeTypeName("xcb_keycode_t")]
        public byte keyMinKeyCode;

        [NativeTypeName("xcb_keycode_t")]
        public byte keyMaxKeyCode;

        [NativeTypeName("uint8_t")]
        public byte nTypes;

        [NativeTypeName("uint8_t")]
        public byte groupNames;

        [NativeTypeName("uint16_t")]
        public ushort virtualMods;

        [NativeTypeName("xcb_keycode_t")]
        public byte firstKey;

        [NativeTypeName("uint8_t")]
        public byte nKeys;

        [NativeTypeName("uint32_t")]
        public uint indicators;

        [NativeTypeName("uint8_t")]
        public byte nRadioGroups;

        [NativeTypeName("uint8_t")]
        public byte nKeyAliases;

        [NativeTypeName("uint16_t")]
        public ushort nKTLevels;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad10[4];

        public xcb_xkb_get_kbd_by_name_replies_key_names_value_list_t valueList;
    }

    public unsafe partial struct _geometry_e__Struct
    {
        [NativeTypeName("uint8_t")]
        public byte geometry_type;

        [NativeTypeName("uint8_t")]
        public byte geometryDeviceID;

        [NativeTypeName("uint16_t")]
        public ushort geometry_sequence;

        [NativeTypeName("uint32_t")]
        public uint geometry_length;

        [NativeTypeName("xcb_atom_t")]
        public uint name;

        [NativeTypeName("uint8_t")]
        public byte geometryFound;

        [NativeTypeName("uint8_t")]
        public byte pad12;

        [NativeTypeName("uint16_t")]
        public ushort widthMM;

        [NativeTypeName("uint16_t")]
        public ushort heightMM;

        [NativeTypeName("uint16_t")]
        public ushort nProperties;

        [NativeTypeName("uint16_t")]
        public ushort nColors;

        [NativeTypeName("uint16_t")]
        public ushort nShapes;

        [NativeTypeName("uint16_t")]
        public ushort nSections;

        [NativeTypeName("uint16_t")]
        public ushort nDoodads;

        [NativeTypeName("uint16_t")]
        public ushort nKeyAliases;

        [NativeTypeName("uint8_t")]
        public byte baseColorNdx;

        [NativeTypeName("uint8_t")]
        public byte labelColorNdx;

        public xcb_xkb_counted_string_16_t* labelFont;
    }
}

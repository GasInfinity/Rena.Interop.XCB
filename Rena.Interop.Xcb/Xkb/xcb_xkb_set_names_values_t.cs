namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xkb_set_names_values_t
{
    [NativeTypeName("xcb_atom_t")]
    public uint keycodesName;

    [NativeTypeName("xcb_atom_t")]
    public uint geometryName;

    [NativeTypeName("xcb_atom_t")]
    public uint symbolsName;

    [NativeTypeName("xcb_atom_t")]
    public uint physSymbolsName;

    [NativeTypeName("xcb_atom_t")]
    public uint typesName;

    [NativeTypeName("xcb_atom_t")]
    public uint compatName;

    [NativeTypeName("xcb_atom_t *")]
    public uint* typeNames;

    [NativeTypeName("uint8_t *")]
    public byte* nLevelsPerType;

    [NativeTypeName("xcb_atom_t *")]
    public uint* ktLevelNames;

    [NativeTypeName("xcb_atom_t *")]
    public uint* indicatorNames;

    [NativeTypeName("xcb_atom_t *")]
    public uint* virtualModNames;

    [NativeTypeName("xcb_atom_t *")]
    public uint* groups;

    public xcb_xkb_key_name_t* keyNames;

    public xcb_xkb_key_alias_t* keyAliases;

    [NativeTypeName("xcb_atom_t *")]
    public uint* radioGroupNames;
}

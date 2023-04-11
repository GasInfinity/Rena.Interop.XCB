using System.Runtime.InteropServices;

namespace Rena.Interop.Xcb;

public static unsafe partial class XcbXkb
{
    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map", ExactSpelling = true)]
    public static extern xcb_xkb_get_kbd_by_name_replies_types_map_t* get_kbd_by_name_replies_types_map([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_spec_next", ExactSpelling = true)]
    public static extern void device_spec_next(xcb_xkb_device_spec_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_spec_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_spec_end(xcb_xkb_device_spec_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_led_class_spec_next", ExactSpelling = true)]
    public static extern void led_class_spec_next(xcb_xkb_led_class_spec_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_led_class_spec_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t led_class_spec_end(xcb_xkb_led_class_spec_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_bell_class_spec_next", ExactSpelling = true)]
    public static extern void bell_class_spec_next(xcb_xkb_bell_class_spec_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_bell_class_spec_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t bell_class_spec_end(xcb_xkb_bell_class_spec_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_id_spec_next", ExactSpelling = true)]
    public static extern void id_spec_next(xcb_xkb_id_spec_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_id_spec_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t id_spec_end(xcb_xkb_id_spec_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_indicator_map_next", ExactSpelling = true)]
    public static extern void indicator_map_next(xcb_xkb_indicator_map_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_indicator_map_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t indicator_map_end(xcb_xkb_indicator_map_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_mod_def_next", ExactSpelling = true)]
    public static extern void mod_def_next(xcb_xkb_mod_def_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_mod_def_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t mod_def_end(xcb_xkb_mod_def_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_name_next", ExactSpelling = true)]
    public static extern void key_name_next(xcb_xkb_key_name_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_name_end(xcb_xkb_key_name_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_alias_next", ExactSpelling = true)]
    public static extern void key_alias_next(xcb_xkb_key_alias_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_alias_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_alias_end(xcb_xkb_key_alias_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_sizeof", ExactSpelling = true)]
    public static extern int counted_string_16_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_string", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* counted_string_16_string([NativeTypeName("const xcb_xkb_counted_string_16_t *")] xcb_xkb_counted_string_16_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_string_length", ExactSpelling = true)]
    public static extern int counted_string_16_string_length([NativeTypeName("const xcb_xkb_counted_string_16_t *")] xcb_xkb_counted_string_16_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_string_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t counted_string_16_string_end([NativeTypeName("const xcb_xkb_counted_string_16_t *")] xcb_xkb_counted_string_16_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_alignment_pad", ExactSpelling = true)]
    public static extern void* counted_string_16_alignment_pad([NativeTypeName("const xcb_xkb_counted_string_16_t *")] xcb_xkb_counted_string_16_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_alignment_pad_length", ExactSpelling = true)]
    public static extern int counted_string_16_alignment_pad_length([NativeTypeName("const xcb_xkb_counted_string_16_t *")] xcb_xkb_counted_string_16_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_alignment_pad_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t counted_string_16_alignment_pad_end([NativeTypeName("const xcb_xkb_counted_string_16_t *")] xcb_xkb_counted_string_16_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_next", ExactSpelling = true)]
    public static extern void counted_string_16_next(xcb_xkb_counted_string_16_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_counted_string_16_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t counted_string_16_end(xcb_xkb_counted_string_16_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_kt_map_entry_next", ExactSpelling = true)]
    public static extern void kt_map_entry_next(xcb_xkb_kt_map_entry_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_kt_map_entry_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t kt_map_entry_end(xcb_xkb_kt_map_entry_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_sizeof", ExactSpelling = true)]
    public static extern int key_type_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_map", ExactSpelling = true)]
    public static extern xcb_xkb_kt_map_entry_t* key_type_map([NativeTypeName("const xcb_xkb_key_type_t *")] xcb_xkb_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_map_length", ExactSpelling = true)]
    public static extern int key_type_map_length([NativeTypeName("const xcb_xkb_key_type_t *")] xcb_xkb_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_map_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_kt_map_entry_iterator_t key_type_map_iterator([NativeTypeName("const xcb_xkb_key_type_t *")] xcb_xkb_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_preserve", ExactSpelling = true)]
    public static extern xcb_xkb_mod_def_t* key_type_preserve([NativeTypeName("const xcb_xkb_key_type_t *")] xcb_xkb_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_preserve_length", ExactSpelling = true)]
    public static extern int key_type_preserve_length([NativeTypeName("const xcb_xkb_key_type_t *")] xcb_xkb_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_preserve_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_mod_def_iterator_t key_type_preserve_iterator([NativeTypeName("const xcb_xkb_key_type_t *")] xcb_xkb_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_next", ExactSpelling = true)]
    public static extern void key_type_next(xcb_xkb_key_type_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_type_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_type_end(xcb_xkb_key_type_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_sym_map_sizeof", ExactSpelling = true)]
    public static extern int key_sym_map_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_sym_map_syms", ExactSpelling = true)]
    [return: NativeTypeName("xcb_keysym_t *")]
    public static extern uint* key_sym_map_syms([NativeTypeName("const xcb_xkb_key_sym_map_t *")] xcb_xkb_key_sym_map_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_sym_map_syms_length", ExactSpelling = true)]
    public static extern int key_sym_map_syms_length([NativeTypeName("const xcb_xkb_key_sym_map_t *")] xcb_xkb_key_sym_map_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_sym_map_syms_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_sym_map_syms_end([NativeTypeName("const xcb_xkb_key_sym_map_t *")] xcb_xkb_key_sym_map_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_sym_map_next", ExactSpelling = true)]
    public static extern void key_sym_map_next(xcb_xkb_key_sym_map_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_sym_map_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_sym_map_end(xcb_xkb_key_sym_map_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_common_behavior_next", ExactSpelling = true)]
    public static extern void common_behavior_next(xcb_xkb_common_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_common_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t common_behavior_end(xcb_xkb_common_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_default_behavior_next", ExactSpelling = true)]
    public static extern void default_behavior_next(xcb_xkb_default_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_default_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t default_behavior_end(xcb_xkb_default_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_lock_behavior_next", ExactSpelling = true)]
    public static extern void lock_behavior_next(xcb_xkb_lock_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_lock_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t lock_behavior_end(xcb_xkb_lock_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_radio_group_behavior_next", ExactSpelling = true)]
    public static extern void radio_group_behavior_next(xcb_xkb_radio_group_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_radio_group_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t radio_group_behavior_end(xcb_xkb_radio_group_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_behavior_next", ExactSpelling = true)]
    public static extern void overlay_behavior_next(xcb_xkb_overlay_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t overlay_behavior_end(xcb_xkb_overlay_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_permament_lock_behavior_next", ExactSpelling = true)]
    public static extern void permament_lock_behavior_next(xcb_xkb_permament_lock_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_permament_lock_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t permament_lock_behavior_end(xcb_xkb_permament_lock_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_permament_radio_group_behavior_next", ExactSpelling = true)]
    public static extern void permament_radio_group_behavior_next(xcb_xkb_permament_radio_group_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_permament_radio_group_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t permament_radio_group_behavior_end(xcb_xkb_permament_radio_group_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_permament_overlay_behavior_next", ExactSpelling = true)]
    public static extern void permament_overlay_behavior_next(xcb_xkb_permament_overlay_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_permament_overlay_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t permament_overlay_behavior_end(xcb_xkb_permament_overlay_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_behavior_next", ExactSpelling = true)]
    public static extern void behavior_next(xcb_xkb_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t behavior_end(xcb_xkb_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_behavior_next", ExactSpelling = true)]
    public static extern void set_behavior_next(xcb_xkb_set_behavior_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_behavior_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_behavior_end(xcb_xkb_set_behavior_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_explicit_next", ExactSpelling = true)]
    public static extern void set_explicit_next(xcb_xkb_set_explicit_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_explicit_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_explicit_end(xcb_xkb_set_explicit_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_mod_map_next", ExactSpelling = true)]
    public static extern void key_mod_map_next(xcb_xkb_key_mod_map_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_mod_map_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_mod_map_end(xcb_xkb_key_mod_map_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_v_mod_map_next", ExactSpelling = true)]
    public static extern void key_v_mod_map_next(xcb_xkb_key_v_mod_map_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_v_mod_map_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_v_mod_map_end(xcb_xkb_key_v_mod_map_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_kt_set_map_entry_next", ExactSpelling = true)]
    public static extern void kt_set_map_entry_next(xcb_xkb_kt_set_map_entry_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_kt_set_map_entry_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t kt_set_map_entry_end(xcb_xkb_kt_set_map_entry_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_sizeof", ExactSpelling = true)]
    public static extern int set_key_type_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_entries", ExactSpelling = true)]
    public static extern xcb_xkb_kt_set_map_entry_t* set_key_type_entries([NativeTypeName("const xcb_xkb_set_key_type_t *")] xcb_xkb_set_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_entries_length", ExactSpelling = true)]
    public static extern int set_key_type_entries_length([NativeTypeName("const xcb_xkb_set_key_type_t *")] xcb_xkb_set_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_entries_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_kt_set_map_entry_iterator_t set_key_type_entries_iterator([NativeTypeName("const xcb_xkb_set_key_type_t *")] xcb_xkb_set_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_preserve_entries", ExactSpelling = true)]
    public static extern xcb_xkb_kt_set_map_entry_t* set_key_type_preserve_entries([NativeTypeName("const xcb_xkb_set_key_type_t *")] xcb_xkb_set_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_preserve_entries_length", ExactSpelling = true)]
    public static extern int set_key_type_preserve_entries_length([NativeTypeName("const xcb_xkb_set_key_type_t *")] xcb_xkb_set_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_preserve_entries_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_kt_set_map_entry_iterator_t set_key_type_preserve_entries_iterator([NativeTypeName("const xcb_xkb_set_key_type_t *")] xcb_xkb_set_key_type_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_next", ExactSpelling = true)]
    public static extern void set_key_type_next(xcb_xkb_set_key_type_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_key_type_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_key_type_end(xcb_xkb_set_key_type_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_string8_next", ExactSpelling = true)]
    public static extern void string8_next(xcb_xkb_string8_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_string8_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t string8_end(xcb_xkb_string8_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_outline_sizeof", ExactSpelling = true)]
    public static extern int outline_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_outline_points", ExactSpelling = true)]
    public static extern xcb_point_t* outline_points([NativeTypeName("const xcb_xkb_outline_t *")] xcb_xkb_outline_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_outline_points_length", ExactSpelling = true)]
    public static extern int outline_points_length([NativeTypeName("const xcb_xkb_outline_t *")] xcb_xkb_outline_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_outline_points_iterator", ExactSpelling = true)]
    public static extern xcb_point_iterator_t outline_points_iterator([NativeTypeName("const xcb_xkb_outline_t *")] xcb_xkb_outline_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_outline_next", ExactSpelling = true)]
    public static extern void outline_next(xcb_xkb_outline_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_outline_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t outline_end(xcb_xkb_outline_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_shape_sizeof", ExactSpelling = true)]
    public static extern int shape_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_shape_outlines_length", ExactSpelling = true)]
    public static extern int shape_outlines_length([NativeTypeName("const xcb_xkb_shape_t *")] xcb_xkb_shape_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_shape_outlines_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_outline_iterator_t shape_outlines_iterator([NativeTypeName("const xcb_xkb_shape_t *")] xcb_xkb_shape_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_shape_next", ExactSpelling = true)]
    public static extern void shape_next(xcb_xkb_shape_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_shape_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t shape_end(xcb_xkb_shape_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_next", ExactSpelling = true)]
    public static extern void key_next(xcb_xkb_key_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_key_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t key_end(xcb_xkb_key_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_key_next", ExactSpelling = true)]
    public static extern void overlay_key_next(xcb_xkb_overlay_key_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_key_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t overlay_key_end(xcb_xkb_overlay_key_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_row_sizeof", ExactSpelling = true)]
    public static extern int overlay_row_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_row_keys", ExactSpelling = true)]
    public static extern xcb_xkb_overlay_key_t* overlay_row_keys([NativeTypeName("const xcb_xkb_overlay_row_t *")] xcb_xkb_overlay_row_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_row_keys_length", ExactSpelling = true)]
    public static extern int overlay_row_keys_length([NativeTypeName("const xcb_xkb_overlay_row_t *")] xcb_xkb_overlay_row_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_row_keys_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_overlay_key_iterator_t overlay_row_keys_iterator([NativeTypeName("const xcb_xkb_overlay_row_t *")] xcb_xkb_overlay_row_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_row_next", ExactSpelling = true)]
    public static extern void overlay_row_next(xcb_xkb_overlay_row_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_row_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t overlay_row_end(xcb_xkb_overlay_row_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_sizeof", ExactSpelling = true)]
    public static extern int overlay_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_rows_length", ExactSpelling = true)]
    public static extern int overlay_rows_length([NativeTypeName("const xcb_xkb_overlay_t *")] xcb_xkb_overlay_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_rows_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_overlay_row_iterator_t overlay_rows_iterator([NativeTypeName("const xcb_xkb_overlay_t *")] xcb_xkb_overlay_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_next", ExactSpelling = true)]
    public static extern void overlay_next(xcb_xkb_overlay_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_overlay_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t overlay_end(xcb_xkb_overlay_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_row_sizeof", ExactSpelling = true)]
    public static extern int row_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_row_keys", ExactSpelling = true)]
    public static extern xcb_xkb_key_t* row_keys([NativeTypeName("const xcb_xkb_row_t *")] xcb_xkb_row_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_row_keys_length", ExactSpelling = true)]
    public static extern int row_keys_length([NativeTypeName("const xcb_xkb_row_t *")] xcb_xkb_row_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_row_keys_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_iterator_t row_keys_iterator([NativeTypeName("const xcb_xkb_row_t *")] xcb_xkb_row_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_row_next", ExactSpelling = true)]
    public static extern void row_next(xcb_xkb_row_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_row_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t row_end(xcb_xkb_row_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_listing_sizeof", ExactSpelling = true)]
    public static extern int listing_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_listing_string", ExactSpelling = true)]
    [return: NativeTypeName("xcb_xkb_string8_t *")]
    public static extern sbyte* listing_string([NativeTypeName("const xcb_xkb_listing_t *")] xcb_xkb_listing_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_listing_string_length", ExactSpelling = true)]
    public static extern int listing_string_length([NativeTypeName("const xcb_xkb_listing_t *")] xcb_xkb_listing_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_listing_string_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t listing_string_end([NativeTypeName("const xcb_xkb_listing_t *")] xcb_xkb_listing_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_listing_next", ExactSpelling = true)]
    public static extern void listing_next(xcb_xkb_listing_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_listing_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t listing_end(xcb_xkb_listing_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_sizeof", ExactSpelling = true)]
    public static extern int device_led_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* device_led_info_names([NativeTypeName("const xcb_xkb_device_led_info_t *")] xcb_xkb_device_led_info_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_names_length", ExactSpelling = true)]
    public static extern int device_led_info_names_length([NativeTypeName("const xcb_xkb_device_led_info_t *")] xcb_xkb_device_led_info_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_led_info_names_end([NativeTypeName("const xcb_xkb_device_led_info_t *")] xcb_xkb_device_led_info_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_maps", ExactSpelling = true)]
    public static extern xcb_xkb_indicator_map_t* device_led_info_maps([NativeTypeName("const xcb_xkb_device_led_info_t *")] xcb_xkb_device_led_info_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_maps_length", ExactSpelling = true)]
    public static extern int device_led_info_maps_length([NativeTypeName("const xcb_xkb_device_led_info_t *")] xcb_xkb_device_led_info_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_maps_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_indicator_map_iterator_t device_led_info_maps_iterator([NativeTypeName("const xcb_xkb_device_led_info_t *")] xcb_xkb_device_led_info_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_next", ExactSpelling = true)]
    public static extern void device_led_info_next(xcb_xkb_device_led_info_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_device_led_info_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t device_led_info_end(xcb_xkb_device_led_info_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_no_action_next", ExactSpelling = true)]
    public static extern void sa_no_action_next(xcb_xkb_sa_no_action_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_no_action_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_no_action_end(xcb_xkb_sa_no_action_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_set_mods_next", ExactSpelling = true)]
    public static extern void sa_set_mods_next(xcb_xkb_sa_set_mods_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_set_mods_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_set_mods_end(xcb_xkb_sa_set_mods_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_latch_mods_next", ExactSpelling = true)]
    public static extern void sa_latch_mods_next(xcb_xkb_sa_latch_mods_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_latch_mods_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_latch_mods_end(xcb_xkb_sa_latch_mods_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_mods_next", ExactSpelling = true)]
    public static extern void sa_lock_mods_next(xcb_xkb_sa_lock_mods_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_mods_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_lock_mods_end(xcb_xkb_sa_lock_mods_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_set_group_next", ExactSpelling = true)]
    public static extern void sa_set_group_next(xcb_xkb_sa_set_group_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_set_group_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_set_group_end(xcb_xkb_sa_set_group_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_latch_group_next", ExactSpelling = true)]
    public static extern void sa_latch_group_next(xcb_xkb_sa_latch_group_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_latch_group_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_latch_group_end(xcb_xkb_sa_latch_group_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_group_next", ExactSpelling = true)]
    public static extern void sa_lock_group_next(xcb_xkb_sa_lock_group_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_group_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_lock_group_end(xcb_xkb_sa_lock_group_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_move_ptr_next", ExactSpelling = true)]
    public static extern void sa_move_ptr_next(xcb_xkb_sa_move_ptr_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_move_ptr_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_move_ptr_end(xcb_xkb_sa_move_ptr_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_ptr_btn_next", ExactSpelling = true)]
    public static extern void sa_ptr_btn_next(xcb_xkb_sa_ptr_btn_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_ptr_btn_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_ptr_btn_end(xcb_xkb_sa_ptr_btn_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_ptr_btn_next", ExactSpelling = true)]
    public static extern void sa_lock_ptr_btn_next(xcb_xkb_sa_lock_ptr_btn_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_ptr_btn_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_lock_ptr_btn_end(xcb_xkb_sa_lock_ptr_btn_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_set_ptr_dflt_next", ExactSpelling = true)]
    public static extern void sa_set_ptr_dflt_next(xcb_xkb_sa_set_ptr_dflt_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_set_ptr_dflt_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_set_ptr_dflt_end(xcb_xkb_sa_set_ptr_dflt_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_iso_lock_next", ExactSpelling = true)]
    public static extern void sa_iso_lock_next(xcb_xkb_sa_iso_lock_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_iso_lock_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_iso_lock_end(xcb_xkb_sa_iso_lock_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_terminate_next", ExactSpelling = true)]
    public static extern void sa_terminate_next(xcb_xkb_sa_terminate_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_terminate_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_terminate_end(xcb_xkb_sa_terminate_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_switch_screen_next", ExactSpelling = true)]
    public static extern void sa_switch_screen_next(xcb_xkb_sa_switch_screen_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_switch_screen_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_switch_screen_end(xcb_xkb_sa_switch_screen_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_set_controls_next", ExactSpelling = true)]
    public static extern void sa_set_controls_next(xcb_xkb_sa_set_controls_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_set_controls_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_set_controls_end(xcb_xkb_sa_set_controls_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_controls_next", ExactSpelling = true)]
    public static extern void sa_lock_controls_next(xcb_xkb_sa_lock_controls_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_controls_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_lock_controls_end(xcb_xkb_sa_lock_controls_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_action_message_next", ExactSpelling = true)]
    public static extern void sa_action_message_next(xcb_xkb_sa_action_message_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_action_message_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_action_message_end(xcb_xkb_sa_action_message_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_redirect_key_next", ExactSpelling = true)]
    public static extern void sa_redirect_key_next(xcb_xkb_sa_redirect_key_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_redirect_key_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_redirect_key_end(xcb_xkb_sa_redirect_key_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_device_btn_next", ExactSpelling = true)]
    public static extern void sa_device_btn_next(xcb_xkb_sa_device_btn_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_device_btn_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_device_btn_end(xcb_xkb_sa_device_btn_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_device_btn_next", ExactSpelling = true)]
    public static extern void sa_lock_device_btn_next(xcb_xkb_sa_lock_device_btn_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_lock_device_btn_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_lock_device_btn_end(xcb_xkb_sa_lock_device_btn_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_device_valuator_next", ExactSpelling = true)]
    public static extern void sa_device_valuator_next(xcb_xkb_sa_device_valuator_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sa_device_valuator_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sa_device_valuator_end(xcb_xkb_sa_device_valuator_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_si_action_next", ExactSpelling = true)]
    public static extern void si_action_next(xcb_xkb_si_action_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_si_action_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t si_action_end(xcb_xkb_si_action_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sym_interpret_next", ExactSpelling = true)]
    public static extern void sym_interpret_next(xcb_xkb_sym_interpret_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_sym_interpret_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t sym_interpret_end(xcb_xkb_sym_interpret_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_action_next", ExactSpelling = true)]
    public static extern void action_next(xcb_xkb_action_iterator_t* i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_action_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t action_end(xcb_xkb_action_iterator_t i);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_use_extension", ExactSpelling = true)]
    public static extern xcb_xkb_use_extension_cookie_t use_extension(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort wantedMajor, [NativeTypeName("uint16_t")] ushort wantedMinor);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_use_extension_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_use_extension_cookie_t use_extension_unchecked(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort wantedMajor, [NativeTypeName("uint16_t")] ushort wantedMinor);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_use_extension_reply", ExactSpelling = true)]
    public static extern xcb_xkb_use_extension_reply_t* use_extension_reply(xcb_connection_t* c, xcb_xkb_use_extension_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events_details_serialize", ExactSpelling = true)]
    public static extern int select_events_details_serialize(void** _buffer, [NativeTypeName("uint16_t")] ushort affectWhich, [NativeTypeName("uint16_t")] ushort clear, [NativeTypeName("uint16_t")] ushort selectAll, [NativeTypeName("const xcb_xkb_select_events_details_t *")] xcb_xkb_select_events_details_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events_details_unpack", ExactSpelling = true)]
    public static extern int select_events_details_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort affectWhich, [NativeTypeName("uint16_t")] ushort clear, [NativeTypeName("uint16_t")] ushort selectAll, xcb_xkb_select_events_details_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events_details_sizeof", ExactSpelling = true)]
    public static extern int select_events_details_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort affectWhich, [NativeTypeName("uint16_t")] ushort clear, [NativeTypeName("uint16_t")] ushort selectAll);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events_sizeof", ExactSpelling = true)]
    public static extern int select_events_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_events_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort affectWhich, [NativeTypeName("uint16_t")] ushort clear, [NativeTypeName("uint16_t")] ushort selectAll, [NativeTypeName("uint16_t")] ushort affectMap, [NativeTypeName("uint16_t")] ushort map, [NativeTypeName("const void *")] void* details);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_events(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort affectWhich, [NativeTypeName("uint16_t")] ushort clear, [NativeTypeName("uint16_t")] ushort selectAll, [NativeTypeName("uint16_t")] ushort affectMap, [NativeTypeName("uint16_t")] ushort map, [NativeTypeName("const void *")] void* details);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events_aux_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_events_aux_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort affectWhich, [NativeTypeName("uint16_t")] ushort clear, [NativeTypeName("uint16_t")] ushort selectAll, [NativeTypeName("uint16_t")] ushort affectMap, [NativeTypeName("uint16_t")] ushort map, [NativeTypeName("const xcb_xkb_select_events_details_t *")] xcb_xkb_select_events_details_t* details);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events_aux", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_events_aux(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort affectWhich, [NativeTypeName("uint16_t")] ushort clear, [NativeTypeName("uint16_t")] ushort selectAll, [NativeTypeName("uint16_t")] ushort affectMap, [NativeTypeName("uint16_t")] ushort map, [NativeTypeName("const xcb_xkb_select_events_details_t *")] xcb_xkb_select_events_details_t* details);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_select_events_details", ExactSpelling = true)]
    public static extern void* select_events_details([NativeTypeName("const xcb_xkb_select_events_request_t *")] xcb_xkb_select_events_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_bell_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t bell_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("xcb_xkb_bell_class_spec_t")] ushort bellClass, [NativeTypeName("xcb_xkb_id_spec_t")] ushort bellID, [NativeTypeName("int8_t")] sbyte percent, [NativeTypeName("uint8_t")] byte forceSound, [NativeTypeName("uint8_t")] byte eventOnly, [NativeTypeName("int16_t")] short pitch, [NativeTypeName("int16_t")] short duration, [NativeTypeName("xcb_atom_t")] uint name, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_bell", ExactSpelling = true)]
    public static extern xcb_void_cookie_t bell(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("xcb_xkb_bell_class_spec_t")] ushort bellClass, [NativeTypeName("xcb_xkb_id_spec_t")] ushort bellID, [NativeTypeName("int8_t")] sbyte percent, [NativeTypeName("uint8_t")] byte forceSound, [NativeTypeName("uint8_t")] byte eventOnly, [NativeTypeName("int16_t")] short pitch, [NativeTypeName("int16_t")] short duration, [NativeTypeName("xcb_atom_t")] uint name, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_state", ExactSpelling = true)]
    public static extern xcb_xkb_get_state_cookie_t get_state(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_state_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_state_cookie_t get_state_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_state_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_state_reply_t* get_state_reply(xcb_connection_t* c, xcb_xkb_get_state_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_latch_lock_state_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t latch_lock_state_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte affectModLocks, [NativeTypeName("uint8_t")] byte modLocks, [NativeTypeName("uint8_t")] byte lockGroup, [NativeTypeName("uint8_t")] byte groupLock, [NativeTypeName("uint8_t")] byte affectModLatches, [NativeTypeName("uint8_t")] byte latchGroup, [NativeTypeName("uint16_t")] ushort groupLatch);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_latch_lock_state", ExactSpelling = true)]
    public static extern xcb_void_cookie_t latch_lock_state(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte affectModLocks, [NativeTypeName("uint8_t")] byte modLocks, [NativeTypeName("uint8_t")] byte lockGroup, [NativeTypeName("uint8_t")] byte groupLock, [NativeTypeName("uint8_t")] byte affectModLatches, [NativeTypeName("uint8_t")] byte latchGroup, [NativeTypeName("uint16_t")] ushort groupLatch);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_controls", ExactSpelling = true)]
    public static extern xcb_xkb_get_controls_cookie_t get_controls(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_controls_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_controls_cookie_t get_controls_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_controls_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_controls_reply_t* get_controls_reply(xcb_connection_t* c, xcb_xkb_get_controls_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_controls_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_controls_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte affectInternalRealMods, [NativeTypeName("uint8_t")] byte internalRealMods, [NativeTypeName("uint8_t")] byte affectIgnoreLockRealMods, [NativeTypeName("uint8_t")] byte ignoreLockRealMods, [NativeTypeName("uint16_t")] ushort affectInternalVirtualMods, [NativeTypeName("uint16_t")] ushort internalVirtualMods, [NativeTypeName("uint16_t")] ushort affectIgnoreLockVirtualMods, [NativeTypeName("uint16_t")] ushort ignoreLockVirtualMods, [NativeTypeName("uint8_t")] byte mouseKeysDfltBtn, [NativeTypeName("uint8_t")] byte groupsWrap, [NativeTypeName("uint16_t")] ushort accessXOptions, [NativeTypeName("uint32_t")] uint affectEnabledControls, [NativeTypeName("uint32_t")] uint enabledControls, [NativeTypeName("uint32_t")] uint changeControls, [NativeTypeName("uint16_t")] ushort repeatDelay, [NativeTypeName("uint16_t")] ushort repeatInterval, [NativeTypeName("uint16_t")] ushort slowKeysDelay, [NativeTypeName("uint16_t")] ushort debounceDelay, [NativeTypeName("uint16_t")] ushort mouseKeysDelay, [NativeTypeName("uint16_t")] ushort mouseKeysInterval, [NativeTypeName("uint16_t")] ushort mouseKeysTimeToMax, [NativeTypeName("uint16_t")] ushort mouseKeysMaxSpeed, [NativeTypeName("int16_t")] short mouseKeysCurve, [NativeTypeName("uint16_t")] ushort accessXTimeout, [NativeTypeName("uint32_t")] uint accessXTimeoutMask, [NativeTypeName("uint32_t")] uint accessXTimeoutValues, [NativeTypeName("uint16_t")] ushort accessXTimeoutOptionsMask, [NativeTypeName("uint16_t")] ushort accessXTimeoutOptionsValues, [NativeTypeName("const uint8_t *")] byte* perKeyRepeat);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_controls", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_controls(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte affectInternalRealMods, [NativeTypeName("uint8_t")] byte internalRealMods, [NativeTypeName("uint8_t")] byte affectIgnoreLockRealMods, [NativeTypeName("uint8_t")] byte ignoreLockRealMods, [NativeTypeName("uint16_t")] ushort affectInternalVirtualMods, [NativeTypeName("uint16_t")] ushort internalVirtualMods, [NativeTypeName("uint16_t")] ushort affectIgnoreLockVirtualMods, [NativeTypeName("uint16_t")] ushort ignoreLockVirtualMods, [NativeTypeName("uint8_t")] byte mouseKeysDfltBtn, [NativeTypeName("uint8_t")] byte groupsWrap, [NativeTypeName("uint16_t")] ushort accessXOptions, [NativeTypeName("uint32_t")] uint affectEnabledControls, [NativeTypeName("uint32_t")] uint enabledControls, [NativeTypeName("uint32_t")] uint changeControls, [NativeTypeName("uint16_t")] ushort repeatDelay, [NativeTypeName("uint16_t")] ushort repeatInterval, [NativeTypeName("uint16_t")] ushort slowKeysDelay, [NativeTypeName("uint16_t")] ushort debounceDelay, [NativeTypeName("uint16_t")] ushort mouseKeysDelay, [NativeTypeName("uint16_t")] ushort mouseKeysInterval, [NativeTypeName("uint16_t")] ushort mouseKeysTimeToMax, [NativeTypeName("uint16_t")] ushort mouseKeysMaxSpeed, [NativeTypeName("int16_t")] short mouseKeysCurve, [NativeTypeName("uint16_t")] ushort accessXTimeout, [NativeTypeName("uint32_t")] uint accessXTimeoutMask, [NativeTypeName("uint32_t")] uint accessXTimeoutValues, [NativeTypeName("uint16_t")] ushort accessXTimeoutOptionsMask, [NativeTypeName("uint16_t")] ushort accessXTimeoutOptionsValues, [NativeTypeName("const uint8_t *")] byte* perKeyRepeat);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_types_rtrn_length", ExactSpelling = true)]
    public static extern int get_map_map_types_rtrn_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_types_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_type_iterator_t get_map_map_types_rtrn_iterator([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_syms_rtrn_length", ExactSpelling = true)]
    public static extern int get_map_map_syms_rtrn_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_syms_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_sym_map_iterator_t get_map_map_syms_rtrn_iterator([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_acts_rtrn_count", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_map_map_acts_rtrn_count([NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_acts_rtrn_count_length", ExactSpelling = true)]
    public static extern int get_map_map_acts_rtrn_count_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_acts_rtrn_count_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_map_map_acts_rtrn_count_end([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_acts_rtrn_acts", ExactSpelling = true)]
    public static extern xcb_xkb_action_t* get_map_map_acts_rtrn_acts([NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_acts_rtrn_acts_length", ExactSpelling = true)]
    public static extern int get_map_map_acts_rtrn_acts_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_acts_rtrn_acts_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_action_iterator_t get_map_map_acts_rtrn_acts_iterator([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_behaviors_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_set_behavior_t* get_map_map_behaviors_rtrn([NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_behaviors_rtrn_length", ExactSpelling = true)]
    public static extern int get_map_map_behaviors_rtrn_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_behaviors_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_set_behavior_iterator_t get_map_map_behaviors_rtrn_iterator([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_vmods_rtrn", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_map_map_vmods_rtrn([NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_vmods_rtrn_length", ExactSpelling = true)]
    public static extern int get_map_map_vmods_rtrn_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_vmods_rtrn_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_map_map_vmods_rtrn_end([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_explicit_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_set_explicit_t* get_map_map_explicit_rtrn([NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_explicit_rtrn_length", ExactSpelling = true)]
    public static extern int get_map_map_explicit_rtrn_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_explicit_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_set_explicit_iterator_t get_map_map_explicit_rtrn_iterator([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_modmap_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_key_mod_map_t* get_map_map_modmap_rtrn([NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_modmap_rtrn_length", ExactSpelling = true)]
    public static extern int get_map_map_modmap_rtrn_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_modmap_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_mod_map_iterator_t get_map_map_modmap_rtrn_iterator([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_vmodmap_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_key_v_mod_map_t* get_map_map_vmodmap_rtrn([NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_vmodmap_rtrn_length", ExactSpelling = true)]
    public static extern int get_map_map_vmodmap_rtrn_length([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_vmodmap_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_v_mod_map_iterator_t get_map_map_vmodmap_rtrn_iterator([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_serialize", ExactSpelling = true)]
    public static extern int get_map_map_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present, [NativeTypeName("const xcb_xkb_get_map_map_t *")] xcb_xkb_get_map_map_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_unpack", ExactSpelling = true)]
    public static extern int get_map_map_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present, xcb_xkb_get_map_map_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map_sizeof", ExactSpelling = true)]
    public static extern int get_map_map_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_sizeof", ExactSpelling = true)]
    public static extern int get_map_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map", ExactSpelling = true)]
    public static extern xcb_xkb_get_map_cookie_t get_map(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort full, [NativeTypeName("uint16_t")] ushort partial, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("xcb_keycode_t")] byte firstKeySym, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("xcb_keycode_t")] byte firstKeyAction, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("xcb_keycode_t")] byte firstKeyBehavior, [NativeTypeName("uint8_t")] byte nKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("xcb_keycode_t")] byte firstKeyExplicit, [NativeTypeName("uint8_t")] byte nKeyExplicit, [NativeTypeName("xcb_keycode_t")] byte firstModMapKey, [NativeTypeName("uint8_t")] byte nModMapKeys, [NativeTypeName("xcb_keycode_t")] byte firstVModMapKey, [NativeTypeName("uint8_t")] byte nVModMapKeys);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_map_cookie_t get_map_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort full, [NativeTypeName("uint16_t")] ushort partial, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("xcb_keycode_t")] byte firstKeySym, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("xcb_keycode_t")] byte firstKeyAction, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("xcb_keycode_t")] byte firstKeyBehavior, [NativeTypeName("uint8_t")] byte nKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("xcb_keycode_t")] byte firstKeyExplicit, [NativeTypeName("uint8_t")] byte nKeyExplicit, [NativeTypeName("xcb_keycode_t")] byte firstModMapKey, [NativeTypeName("uint8_t")] byte nModMapKeys, [NativeTypeName("xcb_keycode_t")] byte firstVModMapKey, [NativeTypeName("uint8_t")] byte nVModMapKeys);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_map", ExactSpelling = true)]
    public static extern void* get_map_map([NativeTypeName("const xcb_xkb_get_map_reply_t *")] xcb_xkb_get_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_map_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_map_reply_t* get_map_reply(xcb_connection_t* c, xcb_xkb_get_map_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_types_length", ExactSpelling = true)]
    public static extern int set_map_values_types_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_types_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_set_key_type_iterator_t set_map_values_types_iterator([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_syms_length", ExactSpelling = true)]
    public static extern int set_map_values_syms_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_syms_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_sym_map_iterator_t set_map_values_syms_iterator([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_actions_count", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* set_map_values_actions_count([NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_actions_count_length", ExactSpelling = true)]
    public static extern int set_map_values_actions_count_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_actions_count_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_map_values_actions_count_end([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_actions", ExactSpelling = true)]
    public static extern xcb_xkb_action_t* set_map_values_actions([NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_actions_length", ExactSpelling = true)]
    public static extern int set_map_values_actions_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_actions_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_action_iterator_t set_map_values_actions_iterator([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_behaviors", ExactSpelling = true)]
    public static extern xcb_xkb_set_behavior_t* set_map_values_behaviors([NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_behaviors_length", ExactSpelling = true)]
    public static extern int set_map_values_behaviors_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_behaviors_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_set_behavior_iterator_t set_map_values_behaviors_iterator([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_vmods", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* set_map_values_vmods([NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_vmods_length", ExactSpelling = true)]
    public static extern int set_map_values_vmods_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_vmods_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_map_values_vmods_end([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_explicit", ExactSpelling = true)]
    public static extern xcb_xkb_set_explicit_t* set_map_values_explicit([NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_explicit_length", ExactSpelling = true)]
    public static extern int set_map_values_explicit_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_explicit_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_set_explicit_iterator_t set_map_values_explicit_iterator([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_modmap", ExactSpelling = true)]
    public static extern xcb_xkb_key_mod_map_t* set_map_values_modmap([NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_modmap_length", ExactSpelling = true)]
    public static extern int set_map_values_modmap_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_modmap_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_mod_map_iterator_t set_map_values_modmap_iterator([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_vmodmap", ExactSpelling = true)]
    public static extern xcb_xkb_key_v_mod_map_t* set_map_values_vmodmap([NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_vmodmap_length", ExactSpelling = true)]
    public static extern int set_map_values_vmodmap_length([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_vmodmap_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_v_mod_map_iterator_t set_map_values_vmodmap_iterator([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_serialize", ExactSpelling = true)]
    public static extern int set_map_values_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_unpack", ExactSpelling = true)]
    public static extern int set_map_values_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present, xcb_xkb_set_map_values_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values_sizeof", ExactSpelling = true)]
    public static extern int set_map_values_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_sizeof", ExactSpelling = true)]
    public static extern int set_map_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_map_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort present, [NativeTypeName("uint16_t")] ushort flags, [NativeTypeName("xcb_keycode_t")] byte minKeyCode, [NativeTypeName("xcb_keycode_t")] byte maxKeyCode, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("xcb_keycode_t")] byte firstKeySym, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint16_t")] ushort totalSyms, [NativeTypeName("xcb_keycode_t")] byte firstKeyAction, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("xcb_keycode_t")] byte firstKeyBehavior, [NativeTypeName("uint8_t")] byte nKeyBehaviors, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("xcb_keycode_t")] byte firstKeyExplicit, [NativeTypeName("uint8_t")] byte nKeyExplicit, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("xcb_keycode_t")] byte firstModMapKey, [NativeTypeName("uint8_t")] byte nModMapKeys, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("xcb_keycode_t")] byte firstVModMapKey, [NativeTypeName("uint8_t")] byte nVModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("const void *")] void* values);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_map(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort present, [NativeTypeName("uint16_t")] ushort flags, [NativeTypeName("xcb_keycode_t")] byte minKeyCode, [NativeTypeName("xcb_keycode_t")] byte maxKeyCode, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("xcb_keycode_t")] byte firstKeySym, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint16_t")] ushort totalSyms, [NativeTypeName("xcb_keycode_t")] byte firstKeyAction, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("xcb_keycode_t")] byte firstKeyBehavior, [NativeTypeName("uint8_t")] byte nKeyBehaviors, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("xcb_keycode_t")] byte firstKeyExplicit, [NativeTypeName("uint8_t")] byte nKeyExplicit, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("xcb_keycode_t")] byte firstModMapKey, [NativeTypeName("uint8_t")] byte nModMapKeys, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("xcb_keycode_t")] byte firstVModMapKey, [NativeTypeName("uint8_t")] byte nVModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("const void *")] void* values);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_aux_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_map_aux_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort present, [NativeTypeName("uint16_t")] ushort flags, [NativeTypeName("xcb_keycode_t")] byte minKeyCode, [NativeTypeName("xcb_keycode_t")] byte maxKeyCode, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("xcb_keycode_t")] byte firstKeySym, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint16_t")] ushort totalSyms, [NativeTypeName("xcb_keycode_t")] byte firstKeyAction, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("xcb_keycode_t")] byte firstKeyBehavior, [NativeTypeName("uint8_t")] byte nKeyBehaviors, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("xcb_keycode_t")] byte firstKeyExplicit, [NativeTypeName("uint8_t")] byte nKeyExplicit, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("xcb_keycode_t")] byte firstModMapKey, [NativeTypeName("uint8_t")] byte nModMapKeys, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("xcb_keycode_t")] byte firstVModMapKey, [NativeTypeName("uint8_t")] byte nVModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* values);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_aux", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_map_aux(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort present, [NativeTypeName("uint16_t")] ushort flags, [NativeTypeName("xcb_keycode_t")] byte minKeyCode, [NativeTypeName("xcb_keycode_t")] byte maxKeyCode, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("xcb_keycode_t")] byte firstKeySym, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint16_t")] ushort totalSyms, [NativeTypeName("xcb_keycode_t")] byte firstKeyAction, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("xcb_keycode_t")] byte firstKeyBehavior, [NativeTypeName("uint8_t")] byte nKeyBehaviors, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("xcb_keycode_t")] byte firstKeyExplicit, [NativeTypeName("uint8_t")] byte nKeyExplicit, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("xcb_keycode_t")] byte firstModMapKey, [NativeTypeName("uint8_t")] byte nModMapKeys, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("xcb_keycode_t")] byte firstVModMapKey, [NativeTypeName("uint8_t")] byte nVModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("const xcb_xkb_set_map_values_t *")] xcb_xkb_set_map_values_t* values);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_map_values", ExactSpelling = true)]
    public static extern void* set_map_values([NativeTypeName("const xcb_xkb_set_map_request_t *")] xcb_xkb_set_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_sizeof", ExactSpelling = true)]
    public static extern int get_compat_map_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map", ExactSpelling = true)]
    public static extern xcb_xkb_get_compat_map_cookie_t get_compat_map(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte groups, [NativeTypeName("uint8_t")] byte getAllSI, [NativeTypeName("uint16_t")] ushort firstSI, [NativeTypeName("uint16_t")] ushort nSI);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_compat_map_cookie_t get_compat_map_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte groups, [NativeTypeName("uint8_t")] byte getAllSI, [NativeTypeName("uint16_t")] ushort firstSI, [NativeTypeName("uint16_t")] ushort nSI);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_si_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_sym_interpret_t* get_compat_map_si_rtrn([NativeTypeName("const xcb_xkb_get_compat_map_reply_t *")] xcb_xkb_get_compat_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_si_rtrn_length", ExactSpelling = true)]
    public static extern int get_compat_map_si_rtrn_length([NativeTypeName("const xcb_xkb_get_compat_map_reply_t *")] xcb_xkb_get_compat_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_si_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_sym_interpret_iterator_t get_compat_map_si_rtrn_iterator([NativeTypeName("const xcb_xkb_get_compat_map_reply_t *")] xcb_xkb_get_compat_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_group_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_mod_def_t* get_compat_map_group_rtrn([NativeTypeName("const xcb_xkb_get_compat_map_reply_t *")] xcb_xkb_get_compat_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_group_rtrn_length", ExactSpelling = true)]
    public static extern int get_compat_map_group_rtrn_length([NativeTypeName("const xcb_xkb_get_compat_map_reply_t *")] xcb_xkb_get_compat_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_group_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_mod_def_iterator_t get_compat_map_group_rtrn_iterator([NativeTypeName("const xcb_xkb_get_compat_map_reply_t *")] xcb_xkb_get_compat_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_compat_map_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_compat_map_reply_t* get_compat_map_reply(xcb_connection_t* c, xcb_xkb_get_compat_map_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map_sizeof", ExactSpelling = true)]
    public static extern int set_compat_map_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_compat_map_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte recomputeActions, [NativeTypeName("uint8_t")] byte truncateSI, [NativeTypeName("uint8_t")] byte groups, [NativeTypeName("uint16_t")] ushort firstSI, [NativeTypeName("uint16_t")] ushort nSI, [NativeTypeName("const xcb_xkb_sym_interpret_t *")] xcb_xkb_sym_interpret_t* si, [NativeTypeName("const xcb_xkb_mod_def_t *")] xcb_xkb_mod_def_t* groupMaps);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_compat_map(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte recomputeActions, [NativeTypeName("uint8_t")] byte truncateSI, [NativeTypeName("uint8_t")] byte groups, [NativeTypeName("uint16_t")] ushort firstSI, [NativeTypeName("uint16_t")] ushort nSI, [NativeTypeName("const xcb_xkb_sym_interpret_t *")] xcb_xkb_sym_interpret_t* si, [NativeTypeName("const xcb_xkb_mod_def_t *")] xcb_xkb_mod_def_t* groupMaps);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map_si", ExactSpelling = true)]
    public static extern xcb_xkb_sym_interpret_t* set_compat_map_si([NativeTypeName("const xcb_xkb_set_compat_map_request_t *")] xcb_xkb_set_compat_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map_si_length", ExactSpelling = true)]
    public static extern int set_compat_map_si_length([NativeTypeName("const xcb_xkb_set_compat_map_request_t *")] xcb_xkb_set_compat_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map_si_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_sym_interpret_iterator_t set_compat_map_si_iterator([NativeTypeName("const xcb_xkb_set_compat_map_request_t *")] xcb_xkb_set_compat_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map_group_maps", ExactSpelling = true)]
    public static extern xcb_xkb_mod_def_t* set_compat_map_group_maps([NativeTypeName("const xcb_xkb_set_compat_map_request_t *")] xcb_xkb_set_compat_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map_group_maps_length", ExactSpelling = true)]
    public static extern int set_compat_map_group_maps_length([NativeTypeName("const xcb_xkb_set_compat_map_request_t *")] xcb_xkb_set_compat_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_compat_map_group_maps_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_mod_def_iterator_t set_compat_map_group_maps_iterator([NativeTypeName("const xcb_xkb_set_compat_map_request_t *")] xcb_xkb_set_compat_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_state", ExactSpelling = true)]
    public static extern xcb_xkb_get_indicator_state_cookie_t get_indicator_state(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_state_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_indicator_state_cookie_t get_indicator_state_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_state_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_indicator_state_reply_t* get_indicator_state_reply(xcb_connection_t* c, xcb_xkb_get_indicator_state_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_map_sizeof", ExactSpelling = true)]
    public static extern int get_indicator_map_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_map", ExactSpelling = true)]
    public static extern xcb_xkb_get_indicator_map_cookie_t get_indicator_map(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint32_t")] uint which);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_map_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_indicator_map_cookie_t get_indicator_map_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint32_t")] uint which);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_map_maps", ExactSpelling = true)]
    public static extern xcb_xkb_indicator_map_t* get_indicator_map_maps([NativeTypeName("const xcb_xkb_get_indicator_map_reply_t *")] xcb_xkb_get_indicator_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_map_maps_length", ExactSpelling = true)]
    public static extern int get_indicator_map_maps_length([NativeTypeName("const xcb_xkb_get_indicator_map_reply_t *")] xcb_xkb_get_indicator_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_map_maps_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_indicator_map_iterator_t get_indicator_map_maps_iterator([NativeTypeName("const xcb_xkb_get_indicator_map_reply_t *")] xcb_xkb_get_indicator_map_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_indicator_map_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_indicator_map_reply_t* get_indicator_map_reply(xcb_connection_t* c, xcb_xkb_get_indicator_map_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_indicator_map_sizeof", ExactSpelling = true)]
    public static extern int set_indicator_map_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_indicator_map_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_indicator_map_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("const xcb_xkb_indicator_map_t *")] xcb_xkb_indicator_map_t* maps);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_indicator_map", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_indicator_map(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("const xcb_xkb_indicator_map_t *")] xcb_xkb_indicator_map_t* maps);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_indicator_map_maps", ExactSpelling = true)]
    public static extern xcb_xkb_indicator_map_t* set_indicator_map_maps([NativeTypeName("const xcb_xkb_set_indicator_map_request_t *")] xcb_xkb_set_indicator_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_indicator_map_maps_length", ExactSpelling = true)]
    public static extern int set_indicator_map_maps_length([NativeTypeName("const xcb_xkb_set_indicator_map_request_t *")] xcb_xkb_set_indicator_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_indicator_map_maps_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_indicator_map_iterator_t set_indicator_map_maps_iterator([NativeTypeName("const xcb_xkb_set_indicator_map_request_t *")] xcb_xkb_set_indicator_map_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_named_indicator", ExactSpelling = true)]
    public static extern xcb_xkb_get_named_indicator_cookie_t get_named_indicator(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("xcb_xkb_led_class_spec_t")] ushort ledClass, [NativeTypeName("xcb_xkb_id_spec_t")] ushort ledID, [NativeTypeName("xcb_atom_t")] uint indicator);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_named_indicator_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_named_indicator_cookie_t get_named_indicator_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("xcb_xkb_led_class_spec_t")] ushort ledClass, [NativeTypeName("xcb_xkb_id_spec_t")] ushort ledID, [NativeTypeName("xcb_atom_t")] uint indicator);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_named_indicator_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_named_indicator_reply_t* get_named_indicator_reply(xcb_connection_t* c, xcb_xkb_get_named_indicator_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_named_indicator_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_named_indicator_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("xcb_xkb_led_class_spec_t")] ushort ledClass, [NativeTypeName("xcb_xkb_id_spec_t")] ushort ledID, [NativeTypeName("xcb_atom_t")] uint indicator, [NativeTypeName("uint8_t")] byte setState, [NativeTypeName("uint8_t")] byte on, [NativeTypeName("uint8_t")] byte setMap, [NativeTypeName("uint8_t")] byte createMap, [NativeTypeName("uint8_t")] byte map_flags, [NativeTypeName("uint8_t")] byte map_whichGroups, [NativeTypeName("uint8_t")] byte map_groups, [NativeTypeName("uint8_t")] byte map_whichMods, [NativeTypeName("uint8_t")] byte map_realMods, [NativeTypeName("uint16_t")] ushort map_vmods, [NativeTypeName("uint32_t")] uint map_ctrls);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_named_indicator", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_named_indicator(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("xcb_xkb_led_class_spec_t")] ushort ledClass, [NativeTypeName("xcb_xkb_id_spec_t")] ushort ledID, [NativeTypeName("xcb_atom_t")] uint indicator, [NativeTypeName("uint8_t")] byte setState, [NativeTypeName("uint8_t")] byte on, [NativeTypeName("uint8_t")] byte setMap, [NativeTypeName("uint8_t")] byte createMap, [NativeTypeName("uint8_t")] byte map_flags, [NativeTypeName("uint8_t")] byte map_whichGroups, [NativeTypeName("uint8_t")] byte map_groups, [NativeTypeName("uint8_t")] byte map_whichMods, [NativeTypeName("uint8_t")] byte map_realMods, [NativeTypeName("uint16_t")] ushort map_vmods, [NativeTypeName("uint32_t")] uint map_ctrls);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_type_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_names_value_list_type_names([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_type_names_length", ExactSpelling = true)]
    public static extern int get_names_value_list_type_names_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_type_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_names_value_list_type_names_end([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_n_levels_per_type", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_names_value_list_n_levels_per_type([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_n_levels_per_type_length", ExactSpelling = true)]
    public static extern int get_names_value_list_n_levels_per_type_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_n_levels_per_type_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_names_value_list_n_levels_per_type_end([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_kt_level_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_names_value_list_kt_level_names([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_kt_level_names_length", ExactSpelling = true)]
    public static extern int get_names_value_list_kt_level_names_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_kt_level_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_names_value_list_kt_level_names_end([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_indicator_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_names_value_list_indicator_names([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_indicator_names_length", ExactSpelling = true)]
    public static extern int get_names_value_list_indicator_names_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_indicator_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_names_value_list_indicator_names_end([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_virtual_mod_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_names_value_list_virtual_mod_names([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_virtual_mod_names_length", ExactSpelling = true)]
    public static extern int get_names_value_list_virtual_mod_names_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_virtual_mod_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_names_value_list_virtual_mod_names_end([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_groups", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_names_value_list_groups([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_groups_length", ExactSpelling = true)]
    public static extern int get_names_value_list_groups_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_groups_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_names_value_list_groups_end([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_key_names", ExactSpelling = true)]
    public static extern xcb_xkb_key_name_t* get_names_value_list_key_names([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_key_names_length", ExactSpelling = true)]
    public static extern int get_names_value_list_key_names_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_key_names_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_name_iterator_t get_names_value_list_key_names_iterator([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_key_aliases", ExactSpelling = true)]
    public static extern xcb_xkb_key_alias_t* get_names_value_list_key_aliases([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_key_aliases_length", ExactSpelling = true)]
    public static extern int get_names_value_list_key_aliases_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_key_aliases_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_alias_iterator_t get_names_value_list_key_aliases_iterator([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_radio_group_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_names_value_list_radio_group_names([NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_radio_group_names_length", ExactSpelling = true)]
    public static extern int get_names_value_list_radio_group_names_length([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_radio_group_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_names_value_list_radio_group_names_end([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_serialize", ExactSpelling = true)]
    public static extern int get_names_value_list_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("const xcb_xkb_get_names_value_list_t *")] xcb_xkb_get_names_value_list_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_unpack", ExactSpelling = true)]
    public static extern int get_names_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which, xcb_xkb_get_names_value_list_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list_sizeof", ExactSpelling = true)]
    public static extern int get_names_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_sizeof", ExactSpelling = true)]
    public static extern int get_names_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names", ExactSpelling = true)]
    public static extern xcb_xkb_get_names_cookie_t get_names(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint32_t")] uint which);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_names_cookie_t get_names_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint32_t")] uint which);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_value_list", ExactSpelling = true)]
    public static extern void* get_names_value_list([NativeTypeName("const xcb_xkb_get_names_reply_t *")] xcb_xkb_get_names_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_names_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_names_reply_t* get_names_reply(xcb_connection_t* c, xcb_xkb_get_names_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_type_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* set_names_values_type_names([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_type_names_length", ExactSpelling = true)]
    public static extern int set_names_values_type_names_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_type_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_names_values_type_names_end([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_n_levels_per_type", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* set_names_values_n_levels_per_type([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_n_levels_per_type_length", ExactSpelling = true)]
    public static extern int set_names_values_n_levels_per_type_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_n_levels_per_type_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_names_values_n_levels_per_type_end([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_kt_level_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* set_names_values_kt_level_names([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_kt_level_names_length", ExactSpelling = true)]
    public static extern int set_names_values_kt_level_names_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_kt_level_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_names_values_kt_level_names_end([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_indicator_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* set_names_values_indicator_names([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_indicator_names_length", ExactSpelling = true)]
    public static extern int set_names_values_indicator_names_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_indicator_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_names_values_indicator_names_end([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_virtual_mod_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* set_names_values_virtual_mod_names([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_virtual_mod_names_length", ExactSpelling = true)]
    public static extern int set_names_values_virtual_mod_names_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_virtual_mod_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_names_values_virtual_mod_names_end([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_groups", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* set_names_values_groups([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_groups_length", ExactSpelling = true)]
    public static extern int set_names_values_groups_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_groups_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_names_values_groups_end([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_key_names", ExactSpelling = true)]
    public static extern xcb_xkb_key_name_t* set_names_values_key_names([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_key_names_length", ExactSpelling = true)]
    public static extern int set_names_values_key_names_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_key_names_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_name_iterator_t set_names_values_key_names_iterator([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_key_aliases", ExactSpelling = true)]
    public static extern xcb_xkb_key_alias_t* set_names_values_key_aliases([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_key_aliases_length", ExactSpelling = true)]
    public static extern int set_names_values_key_aliases_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_key_aliases_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_alias_iterator_t set_names_values_key_aliases_iterator([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_radio_group_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* set_names_values_radio_group_names([NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_radio_group_names_length", ExactSpelling = true)]
    public static extern int set_names_values_radio_group_names_length([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_radio_group_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_names_values_radio_group_names_end([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_serialize", ExactSpelling = true)]
    public static extern int set_names_values_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_unpack", ExactSpelling = true)]
    public static extern int set_names_values_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which, xcb_xkb_set_names_values_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values_sizeof", ExactSpelling = true)]
    public static extern int set_names_values_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_sizeof", ExactSpelling = true)]
    public static extern int set_names_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_names_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte firstKTLevelt, [NativeTypeName("uint8_t")] byte nKTLevels, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("xcb_keycode_t")] byte firstKey, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint16_t")] ushort totalKTLevelNames, [NativeTypeName("const void *")] void* values);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_names(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte firstKTLevelt, [NativeTypeName("uint8_t")] byte nKTLevels, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("xcb_keycode_t")] byte firstKey, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint16_t")] ushort totalKTLevelNames, [NativeTypeName("const void *")] void* values);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_aux_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_names_aux_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte firstKTLevelt, [NativeTypeName("uint8_t")] byte nKTLevels, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("xcb_keycode_t")] byte firstKey, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint16_t")] ushort totalKTLevelNames, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* values);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_aux", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_names_aux(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("uint8_t")] byte firstType, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte firstKTLevelt, [NativeTypeName("uint8_t")] byte nKTLevels, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("xcb_keycode_t")] byte firstKey, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint16_t")] ushort totalKTLevelNames, [NativeTypeName("const xcb_xkb_set_names_values_t *")] xcb_xkb_set_names_values_t* values);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_names_values", ExactSpelling = true)]
    public static extern void* set_names_values([NativeTypeName("const xcb_xkb_set_names_request_t *")] xcb_xkb_set_names_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_per_client_flags", ExactSpelling = true)]
    public static extern xcb_xkb_per_client_flags_cookie_t per_client_flags(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint32_t")] uint change, [NativeTypeName("uint32_t")] uint value, [NativeTypeName("uint32_t")] uint ctrlsToChange, [NativeTypeName("uint32_t")] uint autoCtrls, [NativeTypeName("uint32_t")] uint autoCtrlsValues);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_per_client_flags_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_per_client_flags_cookie_t per_client_flags_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint32_t")] uint change, [NativeTypeName("uint32_t")] uint value, [NativeTypeName("uint32_t")] uint ctrlsToChange, [NativeTypeName("uint32_t")] uint autoCtrls, [NativeTypeName("uint32_t")] uint autoCtrlsValues);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_per_client_flags_reply", ExactSpelling = true)]
    public static extern xcb_xkb_per_client_flags_reply_t* per_client_flags_reply(xcb_connection_t* c, xcb_xkb_per_client_flags_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_sizeof", ExactSpelling = true)]
    public static extern int list_components_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components", ExactSpelling = true)]
    public static extern xcb_xkb_list_components_cookie_t list_components(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort maxNames);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_list_components_cookie_t list_components_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort maxNames);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_keymaps_length", ExactSpelling = true)]
    public static extern int list_components_keymaps_length([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_keymaps_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_listing_iterator_t list_components_keymaps_iterator([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_keycodes_length", ExactSpelling = true)]
    public static extern int list_components_keycodes_length([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_keycodes_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_listing_iterator_t list_components_keycodes_iterator([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_types_length", ExactSpelling = true)]
    public static extern int list_components_types_length([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_types_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_listing_iterator_t list_components_types_iterator([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_compat_maps_length", ExactSpelling = true)]
    public static extern int list_components_compat_maps_length([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_compat_maps_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_listing_iterator_t list_components_compat_maps_iterator([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_symbols_length", ExactSpelling = true)]
    public static extern int list_components_symbols_length([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_symbols_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_listing_iterator_t list_components_symbols_iterator([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_geometries_length", ExactSpelling = true)]
    public static extern int list_components_geometries_length([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_geometries_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_listing_iterator_t list_components_geometries_iterator([NativeTypeName("const xcb_xkb_list_components_reply_t *")] xcb_xkb_list_components_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_list_components_reply", ExactSpelling = true)]
    public static extern xcb_xkb_list_components_reply_t* list_components_reply(xcb_connection_t* c, xcb_xkb_list_components_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_types_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_types_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_types_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_type_iterator_t get_kbd_by_name_replies_types_map_types_rtrn_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_syms_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_syms_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_syms_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_sym_map_iterator_t get_kbd_by_name_replies_types_map_syms_rtrn_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_acts_rtrn_count", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_kbd_by_name_replies_types_map_acts_rtrn_count([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_acts_rtrn_count_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_acts_rtrn_count_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_acts_rtrn_count_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_types_map_acts_rtrn_count_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_acts_rtrn_acts", ExactSpelling = true)]
    public static extern xcb_xkb_action_t* get_kbd_by_name_replies_types_map_acts_rtrn_acts([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_acts_rtrn_acts_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_acts_rtrn_acts_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_acts_rtrn_acts_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_action_iterator_t get_kbd_by_name_replies_types_map_acts_rtrn_acts_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_behaviors_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_set_behavior_t* get_kbd_by_name_replies_types_map_behaviors_rtrn([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_behaviors_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_behaviors_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_behaviors_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_set_behavior_iterator_t get_kbd_by_name_replies_types_map_behaviors_rtrn_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_vmods_rtrn", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_kbd_by_name_replies_types_map_vmods_rtrn([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_vmods_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_vmods_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_vmods_rtrn_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_types_map_vmods_rtrn_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_explicit_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_set_explicit_t* get_kbd_by_name_replies_types_map_explicit_rtrn([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_explicit_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_explicit_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_explicit_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_set_explicit_iterator_t get_kbd_by_name_replies_types_map_explicit_rtrn_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_modmap_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_key_mod_map_t* get_kbd_by_name_replies_types_map_modmap_rtrn([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_modmap_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_modmap_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_modmap_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_mod_map_iterator_t get_kbd_by_name_replies_types_map_modmap_rtrn_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_vmodmap_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_key_v_mod_map_t* get_kbd_by_name_replies_types_map_vmodmap_rtrn([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_vmodmap_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_vmodmap_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_vmodmap_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_v_mod_map_iterator_t get_kbd_by_name_replies_types_map_vmodmap_rtrn_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_serialize", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_types_map_t *")] xcb_xkb_get_kbd_by_name_replies_types_map_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_unpack", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present, xcb_xkb_get_kbd_by_name_replies_types_map_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_types_map_sizeof", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_types_map_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint8_t")] byte nKeySyms, [NativeTypeName("uint8_t")] byte nKeyActions, [NativeTypeName("uint16_t")] ushort totalActions, [NativeTypeName("uint8_t")] byte totalKeyBehaviors, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte totalKeyExplicit, [NativeTypeName("uint8_t")] byte totalModMapKeys, [NativeTypeName("uint8_t")] byte totalVModMapKeys, [NativeTypeName("uint16_t")] ushort present);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_type_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_kbd_by_name_replies_key_names_value_list_type_names([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_type_names_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_type_names_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_type_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_key_names_value_list_type_names_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_n_levels_per_type", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* get_kbd_by_name_replies_key_names_value_list_n_levels_per_type([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_n_levels_per_type_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_n_levels_per_type_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_n_levels_per_type_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_key_names_value_list_n_levels_per_type_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_kt_level_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_kbd_by_name_replies_key_names_value_list_kt_level_names([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_kt_level_names_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_kt_level_names_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_kt_level_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_key_names_value_list_kt_level_names_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_indicator_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_kbd_by_name_replies_key_names_value_list_indicator_names([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_indicator_names_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_indicator_names_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_indicator_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_key_names_value_list_indicator_names_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_virtual_mod_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_kbd_by_name_replies_key_names_value_list_virtual_mod_names([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_virtual_mod_names_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_virtual_mod_names_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_virtual_mod_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_key_names_value_list_virtual_mod_names_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_groups", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_kbd_by_name_replies_key_names_value_list_groups([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_groups_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_groups_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_groups_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_key_names_value_list_groups_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_key_names", ExactSpelling = true)]
    public static extern xcb_xkb_key_name_t* get_kbd_by_name_replies_key_names_value_list_key_names([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_key_names_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_key_names_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_key_names_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_name_iterator_t get_kbd_by_name_replies_key_names_value_list_key_names_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_key_aliases", ExactSpelling = true)]
    public static extern xcb_xkb_key_alias_t* get_kbd_by_name_replies_key_names_value_list_key_aliases([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_key_aliases_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_key_aliases_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_key_aliases_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_key_alias_iterator_t get_kbd_by_name_replies_key_names_value_list_key_aliases_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_radio_group_names", ExactSpelling = true)]
    [return: NativeTypeName("xcb_atom_t *")]
    public static extern uint* get_kbd_by_name_replies_key_names_value_list_radio_group_names([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_radio_group_names_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_radio_group_names_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_radio_group_names_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_kbd_by_name_replies_key_names_value_list_radio_group_names_end([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_serialize", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_serialize(void** _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_key_names_value_list_t *")] xcb_xkb_get_kbd_by_name_replies_key_names_value_list_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_unpack", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which, xcb_xkb_get_kbd_by_name_replies_key_names_value_list_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list_sizeof", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_key_names_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint8_t")] byte nTypes, [NativeTypeName("uint32_t")] uint indicators, [NativeTypeName("uint16_t")] ushort virtualMods, [NativeTypeName("uint8_t")] byte groupNames, [NativeTypeName("uint8_t")] byte nKeys, [NativeTypeName("uint8_t")] byte nKeyAliases, [NativeTypeName("uint8_t")] byte nRadioGroups, [NativeTypeName("uint32_t")] uint which);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_compat_map_si_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_sym_interpret_t* get_kbd_by_name_replies_compat_map_si_rtrn([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_compat_map_si_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_compat_map_si_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_compat_map_si_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_sym_interpret_iterator_t get_kbd_by_name_replies_compat_map_si_rtrn_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_compat_map_group_rtrn", ExactSpelling = true)]
    public static extern xcb_xkb_mod_def_t* get_kbd_by_name_replies_compat_map_group_rtrn([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_compat_map_group_rtrn_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_compat_map_group_rtrn_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_compat_map_group_rtrn_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_mod_def_iterator_t get_kbd_by_name_replies_compat_map_group_rtrn_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_indicator_maps_maps", ExactSpelling = true)]
    public static extern xcb_xkb_indicator_map_t* get_kbd_by_name_replies_indicator_maps_maps([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_indicator_maps_maps_length", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_indicator_maps_maps_length([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_indicator_maps_maps_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_indicator_map_iterator_t get_kbd_by_name_replies_indicator_maps_maps_iterator([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* S);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_key_names_value_list", ExactSpelling = true)]
    public static extern xcb_xkb_get_kbd_by_name_replies_key_names_value_list_t* get_kbd_by_name_replies_key_names_value_list([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_geometry_label_font", ExactSpelling = true)]
    public static extern xcb_xkb_counted_string_16_t* get_kbd_by_name_replies_geometry_label_font([NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_serialize", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_serialize(void** _buffer, [NativeTypeName("uint16_t")] ushort reported, [NativeTypeName("const xcb_xkb_get_kbd_by_name_replies_t *")] xcb_xkb_get_kbd_by_name_replies_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_unpack", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort reported, xcb_xkb_get_kbd_by_name_replies_t* _aux);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies_sizeof", ExactSpelling = true)]
    public static extern int get_kbd_by_name_replies_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort reported);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_sizeof", ExactSpelling = true)]
    public static extern int get_kbd_by_name_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name", ExactSpelling = true)]
    public static extern xcb_xkb_get_kbd_by_name_cookie_t get_kbd_by_name(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort need, [NativeTypeName("uint16_t")] ushort want, [NativeTypeName("uint8_t")] byte load);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_kbd_by_name_cookie_t get_kbd_by_name_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort need, [NativeTypeName("uint16_t")] ushort want, [NativeTypeName("uint8_t")] byte load);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_replies", ExactSpelling = true)]
    public static extern void* get_kbd_by_name_replies([NativeTypeName("const xcb_xkb_get_kbd_by_name_reply_t *")] xcb_xkb_get_kbd_by_name_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_kbd_by_name_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_kbd_by_name_reply_t* get_kbd_by_name_reply(xcb_connection_t* c, xcb_xkb_get_kbd_by_name_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_sizeof", ExactSpelling = true)]
    public static extern int get_device_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info", ExactSpelling = true)]
    public static extern xcb_xkb_get_device_info_cookie_t get_device_info(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort wanted, [NativeTypeName("uint8_t")] byte allButtons, [NativeTypeName("uint8_t")] byte firstButton, [NativeTypeName("uint8_t")] byte nButtons, [NativeTypeName("xcb_xkb_led_class_spec_t")] ushort ledClass, [NativeTypeName("xcb_xkb_id_spec_t")] ushort ledID);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_get_device_info_cookie_t get_device_info_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint16_t")] ushort wanted, [NativeTypeName("uint8_t")] byte allButtons, [NativeTypeName("uint8_t")] byte firstButton, [NativeTypeName("uint8_t")] byte nButtons, [NativeTypeName("xcb_xkb_led_class_spec_t")] ushort ledClass, [NativeTypeName("xcb_xkb_id_spec_t")] ushort ledID);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_name", ExactSpelling = true)]
    [return: NativeTypeName("xcb_xkb_string8_t *")]
    public static extern sbyte* get_device_info_name([NativeTypeName("const xcb_xkb_get_device_info_reply_t *")] xcb_xkb_get_device_info_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_name_length", ExactSpelling = true)]
    public static extern int get_device_info_name_length([NativeTypeName("const xcb_xkb_get_device_info_reply_t *")] xcb_xkb_get_device_info_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_device_info_name_end([NativeTypeName("const xcb_xkb_get_device_info_reply_t *")] xcb_xkb_get_device_info_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_btn_actions", ExactSpelling = true)]
    public static extern xcb_xkb_action_t* get_device_info_btn_actions([NativeTypeName("const xcb_xkb_get_device_info_reply_t *")] xcb_xkb_get_device_info_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_btn_actions_length", ExactSpelling = true)]
    public static extern int get_device_info_btn_actions_length([NativeTypeName("const xcb_xkb_get_device_info_reply_t *")] xcb_xkb_get_device_info_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_btn_actions_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_action_iterator_t get_device_info_btn_actions_iterator([NativeTypeName("const xcb_xkb_get_device_info_reply_t *")] xcb_xkb_get_device_info_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_leds_length", ExactSpelling = true)]
    public static extern int get_device_info_leds_length([NativeTypeName("const xcb_xkb_get_device_info_reply_t *")] xcb_xkb_get_device_info_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_leds_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_device_led_info_iterator_t get_device_info_leds_iterator([NativeTypeName("const xcb_xkb_get_device_info_reply_t *")] xcb_xkb_get_device_info_reply_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_get_device_info_reply", ExactSpelling = true)]
    public static extern xcb_xkb_get_device_info_reply_t* get_device_info_reply(xcb_connection_t* c, xcb_xkb_get_device_info_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_device_info_sizeof", ExactSpelling = true)]
    public static extern int set_device_info_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_device_info_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_device_info_checked(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte firstBtn, [NativeTypeName("uint8_t")] byte nBtns, [NativeTypeName("uint16_t")] ushort change, [NativeTypeName("uint16_t")] ushort nDeviceLedFBs, [NativeTypeName("const xcb_xkb_action_t *")] xcb_xkb_action_t* btnActions, [NativeTypeName("const xcb_xkb_device_led_info_t *")] xcb_xkb_device_led_info_t* leds);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_device_info", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_device_info(xcb_connection_t* c, [NativeTypeName("xcb_xkb_device_spec_t")] ushort deviceSpec, [NativeTypeName("uint8_t")] byte firstBtn, [NativeTypeName("uint8_t")] byte nBtns, [NativeTypeName("uint16_t")] ushort change, [NativeTypeName("uint16_t")] ushort nDeviceLedFBs, [NativeTypeName("const xcb_xkb_action_t *")] xcb_xkb_action_t* btnActions, [NativeTypeName("const xcb_xkb_device_led_info_t *")] xcb_xkb_device_led_info_t* leds);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_device_info_btn_actions", ExactSpelling = true)]
    public static extern xcb_xkb_action_t* set_device_info_btn_actions([NativeTypeName("const xcb_xkb_set_device_info_request_t *")] xcb_xkb_set_device_info_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_device_info_btn_actions_length", ExactSpelling = true)]
    public static extern int set_device_info_btn_actions_length([NativeTypeName("const xcb_xkb_set_device_info_request_t *")] xcb_xkb_set_device_info_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_device_info_btn_actions_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_action_iterator_t set_device_info_btn_actions_iterator([NativeTypeName("const xcb_xkb_set_device_info_request_t *")] xcb_xkb_set_device_info_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_device_info_leds_length", ExactSpelling = true)]
    public static extern int set_device_info_leds_length([NativeTypeName("const xcb_xkb_set_device_info_request_t *")] xcb_xkb_set_device_info_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_device_info_leds_iterator", ExactSpelling = true)]
    public static extern xcb_xkb_device_led_info_iterator_t set_device_info_leds_iterator([NativeTypeName("const xcb_xkb_set_device_info_request_t *")] xcb_xkb_set_device_info_request_t* R);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_debugging_flags_sizeof", ExactSpelling = true)]
    public static extern int set_debugging_flags_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_debugging_flags", ExactSpelling = true)]
    public static extern xcb_xkb_set_debugging_flags_cookie_t set_debugging_flags(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort msgLength, [NativeTypeName("uint32_t")] uint affectFlags, [NativeTypeName("uint32_t")] uint flags, [NativeTypeName("uint32_t")] uint affectCtrls, [NativeTypeName("uint32_t")] uint ctrls, [NativeTypeName("const xcb_xkb_string8_t *")] sbyte* message);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_debugging_flags_unchecked", ExactSpelling = true)]
    public static extern xcb_xkb_set_debugging_flags_cookie_t set_debugging_flags_unchecked(xcb_connection_t* c, [NativeTypeName("uint16_t")] ushort msgLength, [NativeTypeName("uint32_t")] uint affectFlags, [NativeTypeName("uint32_t")] uint flags, [NativeTypeName("uint32_t")] uint affectCtrls, [NativeTypeName("uint32_t")] uint ctrls, [NativeTypeName("const xcb_xkb_string8_t *")] sbyte* message);

    [DllImport("xcb-xkb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xkb_set_debugging_flags_reply", ExactSpelling = true)]
    public static extern xcb_xkb_set_debugging_flags_reply_t* set_debugging_flags_reply(xcb_connection_t* c, xcb_xkb_set_debugging_flags_cookie_t cookie, xcb_generic_error_t** e);

    [NativeTypeName("#define XCB_XKB_MAJOR_VERSION 1")]
    public const int XCB_XKB_MAJOR_VERSION = 1;

    [NativeTypeName("#define XCB_XKB_MINOR_VERSION 0")]
    public const int XCB_XKB_MINOR_VERSION = 0;

    [NativeTypeName("#define XCB_XKB_KEYBOARD 0")]
    public const int XCB_XKB_KEYBOARD = 0;

    [NativeTypeName("#define XCB_XKB_USE_EXTENSION 0")]
    public const int XCB_XKB_USE_EXTENSION = 0;

    [NativeTypeName("#define XCB_XKB_SELECT_EVENTS 1")]
    public const int XCB_XKB_SELECT_EVENTS = 1;

    [NativeTypeName("#define XCB_XKB_BELL 3")]
    public const int XCB_XKB_BELL = 3;

    [NativeTypeName("#define XCB_XKB_GET_STATE 4")]
    public const int XCB_XKB_GET_STATE = 4;

    [NativeTypeName("#define XCB_XKB_LATCH_LOCK_STATE 5")]
    public const int XCB_XKB_LATCH_LOCK_STATE = 5;

    [NativeTypeName("#define XCB_XKB_GET_CONTROLS 6")]
    public const int XCB_XKB_GET_CONTROLS = 6;

    [NativeTypeName("#define XCB_XKB_SET_CONTROLS 7")]
    public const int XCB_XKB_SET_CONTROLS = 7;

    [NativeTypeName("#define XCB_XKB_GET_MAP 8")]
    public const int XCB_XKB_GET_MAP = 8;

    [NativeTypeName("#define XCB_XKB_SET_MAP 9")]
    public const int XCB_XKB_SET_MAP = 9;

    [NativeTypeName("#define XCB_XKB_GET_COMPAT_MAP 10")]
    public const int XCB_XKB_GET_COMPAT_MAP = 10;

    [NativeTypeName("#define XCB_XKB_SET_COMPAT_MAP 11")]
    public const int XCB_XKB_SET_COMPAT_MAP = 11;

    [NativeTypeName("#define XCB_XKB_GET_INDICATOR_STATE 12")]
    public const int XCB_XKB_GET_INDICATOR_STATE = 12;

    [NativeTypeName("#define XCB_XKB_GET_INDICATOR_MAP 13")]
    public const int XCB_XKB_GET_INDICATOR_MAP = 13;

    [NativeTypeName("#define XCB_XKB_SET_INDICATOR_MAP 14")]
    public const int XCB_XKB_SET_INDICATOR_MAP = 14;

    [NativeTypeName("#define XCB_XKB_GET_NAMED_INDICATOR 15")]
    public const int XCB_XKB_GET_NAMED_INDICATOR = 15;

    [NativeTypeName("#define XCB_XKB_SET_NAMED_INDICATOR 16")]
    public const int XCB_XKB_SET_NAMED_INDICATOR = 16;

    [NativeTypeName("#define XCB_XKB_GET_NAMES 17")]
    public const int XCB_XKB_GET_NAMES = 17;

    [NativeTypeName("#define XCB_XKB_SET_NAMES 18")]
    public const int XCB_XKB_SET_NAMES = 18;

    [NativeTypeName("#define XCB_XKB_PER_CLIENT_FLAGS 21")]
    public const int XCB_XKB_PER_CLIENT_FLAGS = 21;

    [NativeTypeName("#define XCB_XKB_LIST_COMPONENTS 22")]
    public const int XCB_XKB_LIST_COMPONENTS = 22;

    [NativeTypeName("#define XCB_XKB_GET_KBD_BY_NAME 23")]
    public const int XCB_XKB_GET_KBD_BY_NAME = 23;

    [NativeTypeName("#define XCB_XKB_GET_DEVICE_INFO 24")]
    public const int XCB_XKB_GET_DEVICE_INFO = 24;

    [NativeTypeName("#define XCB_XKB_SET_DEVICE_INFO 25")]
    public const int XCB_XKB_SET_DEVICE_INFO = 25;

    [NativeTypeName("#define XCB_XKB_SET_DEBUGGING_FLAGS 101")]
    public const int XCB_XKB_SET_DEBUGGING_FLAGS = 101;

    [NativeTypeName("#define XCB_XKB_NEW_KEYBOARD_NOTIFY 0")]
    public const int XCB_XKB_NEW_KEYBOARD_NOTIFY = 0;

    [NativeTypeName("#define XCB_XKB_MAP_NOTIFY 1")]
    public const int XCB_XKB_MAP_NOTIFY = 1;

    [NativeTypeName("#define XCB_XKB_STATE_NOTIFY 2")]
    public const int XCB_XKB_STATE_NOTIFY = 2;

    [NativeTypeName("#define XCB_XKB_CONTROLS_NOTIFY 3")]
    public const int XCB_XKB_CONTROLS_NOTIFY = 3;

    [NativeTypeName("#define XCB_XKB_INDICATOR_STATE_NOTIFY 4")]
    public const int XCB_XKB_INDICATOR_STATE_NOTIFY = 4;

    [NativeTypeName("#define XCB_XKB_INDICATOR_MAP_NOTIFY 5")]
    public const int XCB_XKB_INDICATOR_MAP_NOTIFY = 5;

    [NativeTypeName("#define XCB_XKB_NAMES_NOTIFY 6")]
    public const int XCB_XKB_NAMES_NOTIFY = 6;

    [NativeTypeName("#define XCB_XKB_COMPAT_MAP_NOTIFY 7")]
    public const int XCB_XKB_COMPAT_MAP_NOTIFY = 7;

    [NativeTypeName("#define XCB_XKB_BELL_NOTIFY 8")]
    public const int XCB_XKB_BELL_NOTIFY = 8;

    [NativeTypeName("#define XCB_XKB_ACTION_MESSAGE 9")]
    public const int XCB_XKB_ACTION_MESSAGE = 9;

    [NativeTypeName("#define XCB_XKB_ACCESS_X_NOTIFY 10")]
    public const int XCB_XKB_ACCESS_X_NOTIFY = 10;

    [NativeTypeName("#define XCB_XKB_EXTENSION_DEVICE_NOTIFY 11")]
    public const int XCB_XKB_EXTENSION_DEVICE_NOTIFY = 11;
}

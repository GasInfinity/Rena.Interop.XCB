using System.Runtime.InteropServices;

namespace Rena.Interop.Xcb;

public static unsafe partial class XcbXFixes
{
    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_query_version", ExactSpelling = true)]
    public static extern xcb_xfixes_query_version_cookie_t query_version(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint client_major_version, [NativeTypeName("uint32_t")] uint client_minor_version);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_query_version_unchecked", ExactSpelling = true)]
    public static extern xcb_xfixes_query_version_cookie_t query_version_unchecked(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint client_major_version, [NativeTypeName("uint32_t")] uint client_minor_version);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_query_version_reply", ExactSpelling = true)]
    public static extern xcb_xfixes_query_version_reply_t* query_version_reply(xcb_connection_t* c, xcb_xfixes_query_version_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_save_set_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_save_set_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte target, [NativeTypeName("uint8_t")] byte map, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_save_set", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_save_set(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte target, [NativeTypeName("uint8_t")] byte map, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_select_selection_input_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_selection_input_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint selection, [NativeTypeName("uint32_t")] uint event_mask);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_select_selection_input", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_selection_input(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint selection, [NativeTypeName("uint32_t")] uint event_mask);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_select_cursor_input_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_cursor_input_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint32_t")] uint event_mask);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_select_cursor_input", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_cursor_input(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint32_t")] uint event_mask);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_sizeof", ExactSpelling = true)]
    public static extern int get_cursor_image_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_image_cookie_t get_cursor_image(xcb_connection_t* c);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_unchecked", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_image_cookie_t get_cursor_image_unchecked(xcb_connection_t* c);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_cursor_image", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* get_cursor_image_cursor_image([NativeTypeName("const xcb_xfixes_get_cursor_image_reply_t *")] xcb_xfixes_get_cursor_image_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_cursor_image_length", ExactSpelling = true)]
    public static extern int get_cursor_image_cursor_image_length([NativeTypeName("const xcb_xfixes_get_cursor_image_reply_t *")] xcb_xfixes_get_cursor_image_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_cursor_image_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_cursor_image_cursor_image_end([NativeTypeName("const xcb_xfixes_get_cursor_image_reply_t *")] xcb_xfixes_get_cursor_image_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_reply", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_image_reply_t* get_cursor_image_reply(xcb_connection_t* c, xcb_xfixes_get_cursor_image_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_region_next", ExactSpelling = true)]
    public static extern void region_next(xcb_xfixes_region_iterator_t* i);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_region_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t region_end(xcb_xfixes_region_iterator_t i);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_sizeof", ExactSpelling = true)]
    public static extern int create_region_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint rectangles_len);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_rectangles", ExactSpelling = true)]
    public static extern xcb_rectangle_t* create_region_rectangles([NativeTypeName("const xcb_xfixes_create_region_request_t *")] xcb_xfixes_create_region_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_rectangles_length", ExactSpelling = true)]
    public static extern int create_region_rectangles_length([NativeTypeName("const xcb_xfixes_create_region_request_t *")] xcb_xfixes_create_region_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_rectangles_iterator", ExactSpelling = true)]
    public static extern xcb_rectangle_iterator_t create_region_rectangles_iterator([NativeTypeName("const xcb_xfixes_create_region_request_t *")] xcb_xfixes_create_region_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_from_bitmap_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_from_bitmap_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("xcb_pixmap_t")] uint bitmap);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_from_bitmap", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_from_bitmap(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("xcb_pixmap_t")] uint bitmap);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_from_window_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_from_window_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_shape_kind_t")] byte kind);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_from_window", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_from_window(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_shape_kind_t")] byte kind);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_from_gc_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_from_gc_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("xcb_gcontext_t")] uint gc);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_from_gc", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_from_gc(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("xcb_gcontext_t")] uint gc);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_from_picture_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_from_picture_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("xcb_render_picture_t")] uint picture);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_region_from_picture", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_region_from_picture(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("xcb_render_picture_t")] uint picture);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_destroy_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t destroy_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_destroy_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t destroy_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_region_sizeof", ExactSpelling = true)]
    public static extern int set_region_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint rectangles_len);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_region_rectangles", ExactSpelling = true)]
    public static extern xcb_rectangle_t* set_region_rectangles([NativeTypeName("const xcb_xfixes_set_region_request_t *")] xcb_xfixes_set_region_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_region_rectangles_length", ExactSpelling = true)]
    public static extern int set_region_rectangles_length([NativeTypeName("const xcb_xfixes_set_region_request_t *")] xcb_xfixes_set_region_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_region_rectangles_iterator", ExactSpelling = true)]
    public static extern xcb_rectangle_iterator_t set_region_rectangles_iterator([NativeTypeName("const xcb_xfixes_set_region_request_t *")] xcb_xfixes_set_region_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_copy_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t copy_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_copy_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t copy_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_union_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t union_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source1, [NativeTypeName("xcb_xfixes_region_t")] uint source2, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_union_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t union_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source1, [NativeTypeName("xcb_xfixes_region_t")] uint source2, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_intersect_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t intersect_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source1, [NativeTypeName("xcb_xfixes_region_t")] uint source2, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_intersect_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t intersect_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source1, [NativeTypeName("xcb_xfixes_region_t")] uint source2, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_subtract_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t subtract_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source1, [NativeTypeName("xcb_xfixes_region_t")] uint source2, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_subtract_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t subtract_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source1, [NativeTypeName("xcb_xfixes_region_t")] uint source2, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_invert_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t invert_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source, xcb_rectangle_t bounds, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_invert_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t invert_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source, xcb_rectangle_t bounds, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_translate_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t translate_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("int16_t")] short dx, [NativeTypeName("int16_t")] short dy);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_translate_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t translate_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("int16_t")] short dx, [NativeTypeName("int16_t")] short dy);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_region_extents_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t region_extents_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_region_extents", ExactSpelling = true)]
    public static extern xcb_void_cookie_t region_extents(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source, [NativeTypeName("xcb_xfixes_region_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_fetch_region_sizeof", ExactSpelling = true)]
    public static extern int fetch_region_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_fetch_region", ExactSpelling = true)]
    public static extern xcb_xfixes_fetch_region_cookie_t fetch_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_fetch_region_unchecked", ExactSpelling = true)]
    public static extern xcb_xfixes_fetch_region_cookie_t fetch_region_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint region);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_fetch_region_rectangles", ExactSpelling = true)]
    public static extern xcb_rectangle_t* fetch_region_rectangles([NativeTypeName("const xcb_xfixes_fetch_region_reply_t *")] xcb_xfixes_fetch_region_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_fetch_region_rectangles_length", ExactSpelling = true)]
    public static extern int fetch_region_rectangles_length([NativeTypeName("const xcb_xfixes_fetch_region_reply_t *")] xcb_xfixes_fetch_region_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_fetch_region_rectangles_iterator", ExactSpelling = true)]
    public static extern xcb_rectangle_iterator_t fetch_region_rectangles_iterator([NativeTypeName("const xcb_xfixes_fetch_region_reply_t *")] xcb_xfixes_fetch_region_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_fetch_region_reply", ExactSpelling = true)]
    public static extern xcb_xfixes_fetch_region_reply_t* fetch_region_reply(xcb_connection_t* c, xcb_xfixes_fetch_region_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_gc_clip_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_gc_clip_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("int16_t")] short x_origin, [NativeTypeName("int16_t")] short y_origin);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_gc_clip_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_gc_clip_region(xcb_connection_t* c, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("int16_t")] short x_origin, [NativeTypeName("int16_t")] short y_origin);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_window_shape_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_window_shape_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint dest, [NativeTypeName("xcb_shape_kind_t")] byte dest_kind, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset, [NativeTypeName("xcb_xfixes_region_t")] uint region);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_window_shape_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_window_shape_region(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint dest, [NativeTypeName("xcb_shape_kind_t")] byte dest_kind, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset, [NativeTypeName("xcb_xfixes_region_t")] uint region);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_picture_clip_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_picture_clip_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("int16_t")] short x_origin, [NativeTypeName("int16_t")] short y_origin);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_picture_clip_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_picture_clip_region(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("xcb_xfixes_region_t")] uint region, [NativeTypeName("int16_t")] short x_origin, [NativeTypeName("int16_t")] short y_origin);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_cursor_name_sizeof", ExactSpelling = true)]
    public static extern int set_cursor_name_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_cursor_name_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_cursor_name_checked(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("uint16_t")] ushort nbytes, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_cursor_name", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_cursor_name(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("uint16_t")] ushort nbytes, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_cursor_name_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* set_cursor_name_name([NativeTypeName("const xcb_xfixes_set_cursor_name_request_t *")] xcb_xfixes_set_cursor_name_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_cursor_name_name_length", ExactSpelling = true)]
    public static extern int set_cursor_name_name_length([NativeTypeName("const xcb_xfixes_set_cursor_name_request_t *")] xcb_xfixes_set_cursor_name_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_cursor_name_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_cursor_name_name_end([NativeTypeName("const xcb_xfixes_set_cursor_name_request_t *")] xcb_xfixes_set_cursor_name_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_name_sizeof", ExactSpelling = true)]
    public static extern int get_cursor_name_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_name", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_name_cookie_t get_cursor_name(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint cursor);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_name_unchecked", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_name_cookie_t get_cursor_name_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint cursor);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_name_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* get_cursor_name_name([NativeTypeName("const xcb_xfixes_get_cursor_name_reply_t *")] xcb_xfixes_get_cursor_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_name_name_length", ExactSpelling = true)]
    public static extern int get_cursor_name_name_length([NativeTypeName("const xcb_xfixes_get_cursor_name_reply_t *")] xcb_xfixes_get_cursor_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_name_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_cursor_name_name_end([NativeTypeName("const xcb_xfixes_get_cursor_name_reply_t *")] xcb_xfixes_get_cursor_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_name_reply", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_name_reply_t* get_cursor_name_reply(xcb_connection_t* c, xcb_xfixes_get_cursor_name_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_sizeof", ExactSpelling = true)]
    public static extern int get_cursor_image_and_name_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_image_and_name_cookie_t get_cursor_image_and_name(xcb_connection_t* c);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_unchecked", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_image_and_name_cookie_t get_cursor_image_and_name_unchecked(xcb_connection_t* c);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_cursor_image", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* get_cursor_image_and_name_cursor_image([NativeTypeName("const xcb_xfixes_get_cursor_image_and_name_reply_t *")] xcb_xfixes_get_cursor_image_and_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_cursor_image_length", ExactSpelling = true)]
    public static extern int get_cursor_image_and_name_cursor_image_length([NativeTypeName("const xcb_xfixes_get_cursor_image_and_name_reply_t *")] xcb_xfixes_get_cursor_image_and_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_cursor_image_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_cursor_image_and_name_cursor_image_end([NativeTypeName("const xcb_xfixes_get_cursor_image_and_name_reply_t *")] xcb_xfixes_get_cursor_image_and_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* get_cursor_image_and_name_name([NativeTypeName("const xcb_xfixes_get_cursor_image_and_name_reply_t *")] xcb_xfixes_get_cursor_image_and_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_name_length", ExactSpelling = true)]
    public static extern int get_cursor_image_and_name_name_length([NativeTypeName("const xcb_xfixes_get_cursor_image_and_name_reply_t *")] xcb_xfixes_get_cursor_image_and_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t get_cursor_image_and_name_name_end([NativeTypeName("const xcb_xfixes_get_cursor_image_and_name_reply_t *")] xcb_xfixes_get_cursor_image_and_name_reply_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_cursor_image_and_name_reply", ExactSpelling = true)]
    public static extern xcb_xfixes_get_cursor_image_and_name_reply_t* get_cursor_image_and_name_reply(xcb_connection_t* c, xcb_xfixes_get_cursor_image_and_name_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_cursor_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_cursor_checked(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint source, [NativeTypeName("xcb_cursor_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_cursor", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_cursor(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint source, [NativeTypeName("xcb_cursor_t")] uint destination);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_cursor_by_name_sizeof", ExactSpelling = true)]
    public static extern int change_cursor_by_name_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_cursor_by_name_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_cursor_by_name_checked(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint src, [NativeTypeName("uint16_t")] ushort nbytes, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_cursor_by_name", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_cursor_by_name(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint src, [NativeTypeName("uint16_t")] ushort nbytes, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_cursor_by_name_name", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* change_cursor_by_name_name([NativeTypeName("const xcb_xfixes_change_cursor_by_name_request_t *")] xcb_xfixes_change_cursor_by_name_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_cursor_by_name_name_length", ExactSpelling = true)]
    public static extern int change_cursor_by_name_name_length([NativeTypeName("const xcb_xfixes_change_cursor_by_name_request_t *")] xcb_xfixes_change_cursor_by_name_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_change_cursor_by_name_name_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t change_cursor_by_name_name_end([NativeTypeName("const xcb_xfixes_change_cursor_by_name_request_t *")] xcb_xfixes_change_cursor_by_name_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_expand_region_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t expand_region_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source, [NativeTypeName("xcb_xfixes_region_t")] uint destination, [NativeTypeName("uint16_t")] ushort left, [NativeTypeName("uint16_t")] ushort right, [NativeTypeName("uint16_t")] ushort top, [NativeTypeName("uint16_t")] ushort bottom);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_expand_region", ExactSpelling = true)]
    public static extern xcb_void_cookie_t expand_region(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_region_t")] uint source, [NativeTypeName("xcb_xfixes_region_t")] uint destination, [NativeTypeName("uint16_t")] ushort left, [NativeTypeName("uint16_t")] ushort right, [NativeTypeName("uint16_t")] ushort top, [NativeTypeName("uint16_t")] ushort bottom);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_hide_cursor_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t hide_cursor_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_hide_cursor", ExactSpelling = true)]
    public static extern xcb_void_cookie_t hide_cursor(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_show_cursor_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t show_cursor_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_show_cursor", ExactSpelling = true)]
    public static extern xcb_void_cookie_t show_cursor(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_barrier_next", ExactSpelling = true)]
    public static extern void barrier_next(xcb_xfixes_barrier_iterator_t* i);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_barrier_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t barrier_end(xcb_xfixes_barrier_iterator_t i);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_pointer_barrier_sizeof", ExactSpelling = true)]
    public static extern int create_pointer_barrier_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_pointer_barrier_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_pointer_barrier_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_barrier_t")] uint barrier, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort x1, [NativeTypeName("uint16_t")] ushort y1, [NativeTypeName("uint16_t")] ushort x2, [NativeTypeName("uint16_t")] ushort y2, [NativeTypeName("uint32_t")] uint directions, [NativeTypeName("uint16_t")] ushort num_devices, [NativeTypeName("const uint16_t *")] ushort* devices);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_pointer_barrier", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_pointer_barrier(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_barrier_t")] uint barrier, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort x1, [NativeTypeName("uint16_t")] ushort y1, [NativeTypeName("uint16_t")] ushort x2, [NativeTypeName("uint16_t")] ushort y2, [NativeTypeName("uint32_t")] uint directions, [NativeTypeName("uint16_t")] ushort num_devices, [NativeTypeName("const uint16_t *")] ushort* devices);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_pointer_barrier_devices", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* create_pointer_barrier_devices([NativeTypeName("const xcb_xfixes_create_pointer_barrier_request_t *")] xcb_xfixes_create_pointer_barrier_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_pointer_barrier_devices_length", ExactSpelling = true)]
    public static extern int create_pointer_barrier_devices_length([NativeTypeName("const xcb_xfixes_create_pointer_barrier_request_t *")] xcb_xfixes_create_pointer_barrier_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_create_pointer_barrier_devices_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t create_pointer_barrier_devices_end([NativeTypeName("const xcb_xfixes_create_pointer_barrier_request_t *")] xcb_xfixes_create_pointer_barrier_request_t* R);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_delete_pointer_barrier_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_pointer_barrier_checked(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_barrier_t")] uint barrier);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_delete_pointer_barrier", ExactSpelling = true)]
    public static extern xcb_void_cookie_t delete_pointer_barrier(xcb_connection_t* c, [NativeTypeName("xcb_xfixes_barrier_t")] uint barrier);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_client_disconnect_mode_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_client_disconnect_mode_checked(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint disconnect_mode);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_set_client_disconnect_mode", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_client_disconnect_mode(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint disconnect_mode);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_client_disconnect_mode", ExactSpelling = true)]
    public static extern xcb_xfixes_get_client_disconnect_mode_cookie_t get_client_disconnect_mode(xcb_connection_t* c);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_client_disconnect_mode_unchecked", ExactSpelling = true)]
    public static extern xcb_xfixes_get_client_disconnect_mode_cookie_t get_client_disconnect_mode_unchecked(xcb_connection_t* c);

    [DllImport("xcb-xfixes", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_xfixes_get_client_disconnect_mode_reply", ExactSpelling = true)]
    public static extern xcb_xfixes_get_client_disconnect_mode_reply_t* get_client_disconnect_mode_reply(xcb_connection_t* c, xcb_xfixes_get_client_disconnect_mode_cookie_t cookie, xcb_generic_error_t** e);

    [NativeTypeName("#define XCB_XFIXES_MAJOR_VERSION 6")]
    public const int XCB_XFIXES_MAJOR_VERSION = 6;

    [NativeTypeName("#define XCB_XFIXES_MINOR_VERSION 0")]
    public const int XCB_XFIXES_MINOR_VERSION = 0;

    [NativeTypeName("#define XCB_XFIXES_QUERY_VERSION 0")]
    public const int XCB_XFIXES_QUERY_VERSION = 0;

    [NativeTypeName("#define XCB_XFIXES_CHANGE_SAVE_SET 1")]
    public const int XCB_XFIXES_CHANGE_SAVE_SET = 1;

    [NativeTypeName("#define XCB_XFIXES_SELECTION_NOTIFY 0")]
    public const int XCB_XFIXES_SELECTION_NOTIFY = 0;

    [NativeTypeName("#define XCB_XFIXES_SELECT_SELECTION_INPUT 2")]
    public const int XCB_XFIXES_SELECT_SELECTION_INPUT = 2;

    [NativeTypeName("#define XCB_XFIXES_CURSOR_NOTIFY 1")]
    public const int XCB_XFIXES_CURSOR_NOTIFY = 1;

    [NativeTypeName("#define XCB_XFIXES_SELECT_CURSOR_INPUT 3")]
    public const int XCB_XFIXES_SELECT_CURSOR_INPUT = 3;

    [NativeTypeName("#define XCB_XFIXES_GET_CURSOR_IMAGE 4")]
    public const int XCB_XFIXES_GET_CURSOR_IMAGE = 4;

    [NativeTypeName("#define XCB_XFIXES_BAD_REGION 0")]
    public const int XCB_XFIXES_BAD_REGION = 0;

    [NativeTypeName("#define XCB_XFIXES_CREATE_REGION 5")]
    public const int XCB_XFIXES_CREATE_REGION = 5;

    [NativeTypeName("#define XCB_XFIXES_CREATE_REGION_FROM_BITMAP 6")]
    public const int XCB_XFIXES_CREATE_REGION_FROM_BITMAP = 6;

    [NativeTypeName("#define XCB_XFIXES_CREATE_REGION_FROM_WINDOW 7")]
    public const int XCB_XFIXES_CREATE_REGION_FROM_WINDOW = 7;

    [NativeTypeName("#define XCB_XFIXES_CREATE_REGION_FROM_GC 8")]
    public const int XCB_XFIXES_CREATE_REGION_FROM_GC = 8;

    [NativeTypeName("#define XCB_XFIXES_CREATE_REGION_FROM_PICTURE 9")]
    public const int XCB_XFIXES_CREATE_REGION_FROM_PICTURE = 9;

    [NativeTypeName("#define XCB_XFIXES_DESTROY_REGION 10")]
    public const int XCB_XFIXES_DESTROY_REGION = 10;

    [NativeTypeName("#define XCB_XFIXES_SET_REGION 11")]
    public const int XCB_XFIXES_SET_REGION = 11;

    [NativeTypeName("#define XCB_XFIXES_COPY_REGION 12")]
    public const int XCB_XFIXES_COPY_REGION = 12;

    [NativeTypeName("#define XCB_XFIXES_UNION_REGION 13")]
    public const int XCB_XFIXES_UNION_REGION = 13;

    [NativeTypeName("#define XCB_XFIXES_INTERSECT_REGION 14")]
    public const int XCB_XFIXES_INTERSECT_REGION = 14;

    [NativeTypeName("#define XCB_XFIXES_SUBTRACT_REGION 15")]
    public const int XCB_XFIXES_SUBTRACT_REGION = 15;

    [NativeTypeName("#define XCB_XFIXES_INVERT_REGION 16")]
    public const int XCB_XFIXES_INVERT_REGION = 16;

    [NativeTypeName("#define XCB_XFIXES_TRANSLATE_REGION 17")]
    public const int XCB_XFIXES_TRANSLATE_REGION = 17;

    [NativeTypeName("#define XCB_XFIXES_REGION_EXTENTS 18")]
    public const int XCB_XFIXES_REGION_EXTENTS = 18;

    [NativeTypeName("#define XCB_XFIXES_FETCH_REGION 19")]
    public const int XCB_XFIXES_FETCH_REGION = 19;

    [NativeTypeName("#define XCB_XFIXES_SET_GC_CLIP_REGION 20")]
    public const int XCB_XFIXES_SET_GC_CLIP_REGION = 20;

    [NativeTypeName("#define XCB_XFIXES_SET_WINDOW_SHAPE_REGION 21")]
    public const int XCB_XFIXES_SET_WINDOW_SHAPE_REGION = 21;

    [NativeTypeName("#define XCB_XFIXES_SET_PICTURE_CLIP_REGION 22")]
    public const int XCB_XFIXES_SET_PICTURE_CLIP_REGION = 22;

    [NativeTypeName("#define XCB_XFIXES_SET_CURSOR_NAME 23")]
    public const int XCB_XFIXES_SET_CURSOR_NAME = 23;

    [NativeTypeName("#define XCB_XFIXES_GET_CURSOR_NAME 24")]
    public const int XCB_XFIXES_GET_CURSOR_NAME = 24;

    [NativeTypeName("#define XCB_XFIXES_GET_CURSOR_IMAGE_AND_NAME 25")]
    public const int XCB_XFIXES_GET_CURSOR_IMAGE_AND_NAME = 25;

    [NativeTypeName("#define XCB_XFIXES_CHANGE_CURSOR 26")]
    public const int XCB_XFIXES_CHANGE_CURSOR = 26;

    [NativeTypeName("#define XCB_XFIXES_CHANGE_CURSOR_BY_NAME 27")]
    public const int XCB_XFIXES_CHANGE_CURSOR_BY_NAME = 27;

    [NativeTypeName("#define XCB_XFIXES_EXPAND_REGION 28")]
    public const int XCB_XFIXES_EXPAND_REGION = 28;

    [NativeTypeName("#define XCB_XFIXES_HIDE_CURSOR 29")]
    public const int XCB_XFIXES_HIDE_CURSOR = 29;

    [NativeTypeName("#define XCB_XFIXES_SHOW_CURSOR 30")]
    public const int XCB_XFIXES_SHOW_CURSOR = 30;

    [NativeTypeName("#define XCB_XFIXES_CREATE_POINTER_BARRIER 31")]
    public const int XCB_XFIXES_CREATE_POINTER_BARRIER = 31;

    [NativeTypeName("#define XCB_XFIXES_DELETE_POINTER_BARRIER 32")]
    public const int XCB_XFIXES_DELETE_POINTER_BARRIER = 32;

    [NativeTypeName("#define XCB_XFIXES_SET_CLIENT_DISCONNECT_MODE 33")]
    public const int XCB_XFIXES_SET_CLIENT_DISCONNECT_MODE = 33;

    [NativeTypeName("#define XCB_XFIXES_GET_CLIENT_DISCONNECT_MODE 34")]
    public const int XCB_XFIXES_GET_CLIENT_DISCONNECT_MODE = 34;
}

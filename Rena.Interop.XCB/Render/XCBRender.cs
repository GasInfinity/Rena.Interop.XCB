using System.Runtime.InteropServices;

namespace Rena.Interop.XCB;

public static unsafe partial class XCBRender
{
    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_glyph_next", ExactSpelling = true)]
    public static extern void glyph_next(xcb_render_glyph_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_glyph_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t glyph_end(xcb_render_glyph_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_glyphset_next", ExactSpelling = true)]
    public static extern void glyphset_next(xcb_render_glyphset_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_glyphset_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t glyphset_end(xcb_render_glyphset_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_picture_next", ExactSpelling = true)]
    public static extern void picture_next(xcb_render_picture_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_picture_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t picture_end(xcb_render_picture_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictformat_next", ExactSpelling = true)]
    public static extern void pictformat_next(xcb_render_pictformat_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictformat_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t pictformat_end(xcb_render_pictformat_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_fixed_next", ExactSpelling = true)]
    public static extern void fixed_next(xcb_render_fixed_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_fixed_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t fixed_end(xcb_render_fixed_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_directformat_next", ExactSpelling = true)]
    public static extern void directformat_next(xcb_render_directformat_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_directformat_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t directformat_end(xcb_render_directformat_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictforminfo_next", ExactSpelling = true)]
    public static extern void pictforminfo_next(xcb_render_pictforminfo_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictforminfo_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t pictforminfo_end(xcb_render_pictforminfo_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictvisual_next", ExactSpelling = true)]
    public static extern void pictvisual_next(xcb_render_pictvisual_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictvisual_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t pictvisual_end(xcb_render_pictvisual_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictdepth_sizeof", ExactSpelling = true)]
    public static extern int pictdepth_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictdepth_visuals", ExactSpelling = true)]
    public static extern xcb_render_pictvisual_t* pictdepth_visuals([NativeTypeName("const xcb_render_pictdepth_t *")] xcb_render_pictdepth_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictdepth_visuals_length", ExactSpelling = true)]
    public static extern int pictdepth_visuals_length([NativeTypeName("const xcb_render_pictdepth_t *")] xcb_render_pictdepth_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictdepth_visuals_iterator", ExactSpelling = true)]
    public static extern xcb_render_pictvisual_iterator_t pictdepth_visuals_iterator([NativeTypeName("const xcb_render_pictdepth_t *")] xcb_render_pictdepth_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictdepth_next", ExactSpelling = true)]
    public static extern void pictdepth_next(xcb_render_pictdepth_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictdepth_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t pictdepth_end(xcb_render_pictdepth_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictscreen_sizeof", ExactSpelling = true)]
    public static extern int pictscreen_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictscreen_depths_length", ExactSpelling = true)]
    public static extern int pictscreen_depths_length([NativeTypeName("const xcb_render_pictscreen_t *")] xcb_render_pictscreen_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictscreen_depths_iterator", ExactSpelling = true)]
    public static extern xcb_render_pictdepth_iterator_t pictscreen_depths_iterator([NativeTypeName("const xcb_render_pictscreen_t *")] xcb_render_pictscreen_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictscreen_next", ExactSpelling = true)]
    public static extern void pictscreen_next(xcb_render_pictscreen_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pictscreen_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t pictscreen_end(xcb_render_pictscreen_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_indexvalue_next", ExactSpelling = true)]
    public static extern void indexvalue_next(xcb_render_indexvalue_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_indexvalue_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t indexvalue_end(xcb_render_indexvalue_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_color_next", ExactSpelling = true)]
    public static extern void color_next(xcb_render_color_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_color_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t color_end(xcb_render_color_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pointfix_next", ExactSpelling = true)]
    public static extern void pointfix_next(xcb_render_pointfix_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_pointfix_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t pointfix_end(xcb_render_pointfix_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_linefix_next", ExactSpelling = true)]
    public static extern void linefix_next(xcb_render_linefix_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_linefix_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t linefix_end(xcb_render_linefix_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_triangle_next", ExactSpelling = true)]
    public static extern void triangle_next(xcb_render_triangle_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_triangle_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t triangle_end(xcb_render_triangle_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trapezoid_next", ExactSpelling = true)]
    public static extern void trapezoid_next(xcb_render_trapezoid_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trapezoid_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t trapezoid_end(xcb_render_trapezoid_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_glyphinfo_next", ExactSpelling = true)]
    public static extern void glyphinfo_next(xcb_render_glyphinfo_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_glyphinfo_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t glyphinfo_end(xcb_render_glyphinfo_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_version", ExactSpelling = true)]
    public static extern xcb_render_query_version_cookie_t query_version(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint client_major_version, [NativeTypeName("uint32_t")] uint client_minor_version);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_version_unchecked", ExactSpelling = true)]
    public static extern xcb_render_query_version_cookie_t query_version_unchecked(xcb_connection_t* c, [NativeTypeName("uint32_t")] uint client_major_version, [NativeTypeName("uint32_t")] uint client_minor_version);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_version_reply", ExactSpelling = true)]
    public static extern xcb_render_query_version_reply_t* query_version_reply(xcb_connection_t* c, xcb_render_query_version_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_sizeof", ExactSpelling = true)]
    public static extern int query_pict_formats_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats", ExactSpelling = true)]
    public static extern xcb_render_query_pict_formats_cookie_t query_pict_formats(xcb_connection_t* c);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_unchecked", ExactSpelling = true)]
    public static extern xcb_render_query_pict_formats_cookie_t query_pict_formats_unchecked(xcb_connection_t* c);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_formats", ExactSpelling = true)]
    public static extern xcb_render_pictforminfo_t* query_pict_formats_formats([NativeTypeName("const xcb_render_query_pict_formats_reply_t *")] xcb_render_query_pict_formats_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_formats_length", ExactSpelling = true)]
    public static extern int query_pict_formats_formats_length([NativeTypeName("const xcb_render_query_pict_formats_reply_t *")] xcb_render_query_pict_formats_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_formats_iterator", ExactSpelling = true)]
    public static extern xcb_render_pictforminfo_iterator_t query_pict_formats_formats_iterator([NativeTypeName("const xcb_render_query_pict_formats_reply_t *")] xcb_render_query_pict_formats_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_screens_length", ExactSpelling = true)]
    public static extern int query_pict_formats_screens_length([NativeTypeName("const xcb_render_query_pict_formats_reply_t *")] xcb_render_query_pict_formats_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_screens_iterator", ExactSpelling = true)]
    public static extern xcb_render_pictscreen_iterator_t query_pict_formats_screens_iterator([NativeTypeName("const xcb_render_query_pict_formats_reply_t *")] xcb_render_query_pict_formats_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_subpixels", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* query_pict_formats_subpixels([NativeTypeName("const xcb_render_query_pict_formats_reply_t *")] xcb_render_query_pict_formats_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_subpixels_length", ExactSpelling = true)]
    public static extern int query_pict_formats_subpixels_length([NativeTypeName("const xcb_render_query_pict_formats_reply_t *")] xcb_render_query_pict_formats_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_subpixels_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t query_pict_formats_subpixels_end([NativeTypeName("const xcb_render_query_pict_formats_reply_t *")] xcb_render_query_pict_formats_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_formats_reply", ExactSpelling = true)]
    public static extern xcb_render_query_pict_formats_reply_t* query_pict_formats_reply(xcb_connection_t* c, xcb_render_query_pict_formats_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_index_values_sizeof", ExactSpelling = true)]
    public static extern int query_pict_index_values_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_index_values", ExactSpelling = true)]
    public static extern xcb_render_query_pict_index_values_cookie_t query_pict_index_values(xcb_connection_t* c, [NativeTypeName("xcb_render_pictformat_t")] uint format);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_index_values_unchecked", ExactSpelling = true)]
    public static extern xcb_render_query_pict_index_values_cookie_t query_pict_index_values_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_render_pictformat_t")] uint format);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_index_values_values", ExactSpelling = true)]
    public static extern xcb_render_indexvalue_t* query_pict_index_values_values([NativeTypeName("const xcb_render_query_pict_index_values_reply_t *")] xcb_render_query_pict_index_values_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_index_values_values_length", ExactSpelling = true)]
    public static extern int query_pict_index_values_values_length([NativeTypeName("const xcb_render_query_pict_index_values_reply_t *")] xcb_render_query_pict_index_values_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_index_values_values_iterator", ExactSpelling = true)]
    public static extern xcb_render_indexvalue_iterator_t query_pict_index_values_values_iterator([NativeTypeName("const xcb_render_query_pict_index_values_reply_t *")] xcb_render_query_pict_index_values_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_pict_index_values_reply", ExactSpelling = true)]
    public static extern xcb_render_query_pict_index_values_reply_t* query_pict_index_values_reply(xcb_connection_t* c, xcb_render_query_pict_index_values_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture_value_list_serialize", ExactSpelling = true)]
    public static extern int create_picture_value_list_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_render_create_picture_value_list_t *")] xcb_render_create_picture_value_list_t* _aux);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture_value_list_unpack", ExactSpelling = true)]
    public static extern int create_picture_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask, xcb_render_create_picture_value_list_t* _aux);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture_value_list_sizeof", ExactSpelling = true)]
    public static extern int create_picture_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture_sizeof", ExactSpelling = true)]
    public static extern int create_picture_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_picture_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint pid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_render_pictformat_t")] uint format, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_picture(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint pid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_render_pictformat_t")] uint format, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture_aux_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_picture_aux_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint pid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_render_pictformat_t")] uint format, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_render_create_picture_value_list_t *")] xcb_render_create_picture_value_list_t* value_list);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture_aux", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_picture_aux(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint pid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_render_pictformat_t")] uint format, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_render_create_picture_value_list_t *")] xcb_render_create_picture_value_list_t* value_list);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_picture_value_list", ExactSpelling = true)]
    public static extern void* create_picture_value_list([NativeTypeName("const xcb_render_create_picture_request_t *")] xcb_render_create_picture_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture_value_list_serialize", ExactSpelling = true)]
    public static extern int change_picture_value_list_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_render_change_picture_value_list_t *")] xcb_render_change_picture_value_list_t* _aux);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture_value_list_unpack", ExactSpelling = true)]
    public static extern int change_picture_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask, xcb_render_change_picture_value_list_t* _aux);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture_value_list_sizeof", ExactSpelling = true)]
    public static extern int change_picture_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture_sizeof", ExactSpelling = true)]
    public static extern int change_picture_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_picture_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_picture(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture_aux_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_picture_aux_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_render_change_picture_value_list_t *")] xcb_render_change_picture_value_list_t* value_list);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture_aux", ExactSpelling = true)]
    public static extern xcb_void_cookie_t change_picture_aux(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_render_change_picture_value_list_t *")] xcb_render_change_picture_value_list_t* value_list);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_change_picture_value_list", ExactSpelling = true)]
    public static extern void* change_picture_value_list([NativeTypeName("const xcb_render_change_picture_request_t *")] xcb_render_change_picture_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_clip_rectangles_sizeof", ExactSpelling = true)]
    public static extern int set_picture_clip_rectangles_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint rectangles_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_clip_rectangles_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_picture_clip_rectangles_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("int16_t")] short clip_x_origin, [NativeTypeName("int16_t")] short clip_y_origin, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_clip_rectangles", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_picture_clip_rectangles(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("int16_t")] short clip_x_origin, [NativeTypeName("int16_t")] short clip_y_origin, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_clip_rectangles_rectangles", ExactSpelling = true)]
    public static extern xcb_rectangle_t* set_picture_clip_rectangles_rectangles([NativeTypeName("const xcb_render_set_picture_clip_rectangles_request_t *")] xcb_render_set_picture_clip_rectangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_clip_rectangles_rectangles_length", ExactSpelling = true)]
    public static extern int set_picture_clip_rectangles_rectangles_length([NativeTypeName("const xcb_render_set_picture_clip_rectangles_request_t *")] xcb_render_set_picture_clip_rectangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_clip_rectangles_rectangles_iterator", ExactSpelling = true)]
    public static extern xcb_rectangle_iterator_t set_picture_clip_rectangles_rectangles_iterator([NativeTypeName("const xcb_render_set_picture_clip_rectangles_request_t *")] xcb_render_set_picture_clip_rectangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_picture_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t free_picture_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_picture", ExactSpelling = true)]
    public static extern xcb_void_cookie_t free_picture(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t composite_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint mask, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("int16_t")] short mask_x, [NativeTypeName("int16_t")] short mask_y, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite", ExactSpelling = true)]
    public static extern xcb_void_cookie_t composite(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint mask, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("int16_t")] short mask_x, [NativeTypeName("int16_t")] short mask_y, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trapezoids_sizeof", ExactSpelling = true)]
    public static extern int trapezoids_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint traps_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trapezoids_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t trapezoids_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint traps_len, [NativeTypeName("const xcb_render_trapezoid_t *")] xcb_render_trapezoid_t* traps);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trapezoids", ExactSpelling = true)]
    public static extern xcb_void_cookie_t trapezoids(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint traps_len, [NativeTypeName("const xcb_render_trapezoid_t *")] xcb_render_trapezoid_t* traps);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trapezoids_traps", ExactSpelling = true)]
    public static extern xcb_render_trapezoid_t* trapezoids_traps([NativeTypeName("const xcb_render_trapezoids_request_t *")] xcb_render_trapezoids_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trapezoids_traps_length", ExactSpelling = true)]
    public static extern int trapezoids_traps_length([NativeTypeName("const xcb_render_trapezoids_request_t *")] xcb_render_trapezoids_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trapezoids_traps_iterator", ExactSpelling = true)]
    public static extern xcb_render_trapezoid_iterator_t trapezoids_traps_iterator([NativeTypeName("const xcb_render_trapezoids_request_t *")] xcb_render_trapezoids_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_triangles_sizeof", ExactSpelling = true)]
    public static extern int triangles_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint triangles_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_triangles_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t triangles_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint triangles_len, [NativeTypeName("const xcb_render_triangle_t *")] xcb_render_triangle_t* triangles);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_triangles", ExactSpelling = true)]
    public static extern xcb_void_cookie_t triangles(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint triangles_len, [NativeTypeName("const xcb_render_triangle_t *")] xcb_render_triangle_t* triangles);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_triangles_triangles", ExactSpelling = true)]
    public static extern xcb_render_triangle_t* triangles_triangles([NativeTypeName("const xcb_render_triangles_request_t *")] xcb_render_triangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_triangles_triangles_length", ExactSpelling = true)]
    public static extern int triangles_triangles_length([NativeTypeName("const xcb_render_triangles_request_t *")] xcb_render_triangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_triangles_triangles_iterator", ExactSpelling = true)]
    public static extern xcb_render_triangle_iterator_t triangles_triangles_iterator([NativeTypeName("const xcb_render_triangles_request_t *")] xcb_render_triangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_strip_sizeof", ExactSpelling = true)]
    public static extern int tri_strip_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint points_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_strip_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t tri_strip_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_render_pointfix_t *")] xcb_render_pointfix_t* points);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_strip", ExactSpelling = true)]
    public static extern xcb_void_cookie_t tri_strip(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_render_pointfix_t *")] xcb_render_pointfix_t* points);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_strip_points", ExactSpelling = true)]
    public static extern xcb_render_pointfix_t* tri_strip_points([NativeTypeName("const xcb_render_tri_strip_request_t *")] xcb_render_tri_strip_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_strip_points_length", ExactSpelling = true)]
    public static extern int tri_strip_points_length([NativeTypeName("const xcb_render_tri_strip_request_t *")] xcb_render_tri_strip_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_strip_points_iterator", ExactSpelling = true)]
    public static extern xcb_render_pointfix_iterator_t tri_strip_points_iterator([NativeTypeName("const xcb_render_tri_strip_request_t *")] xcb_render_tri_strip_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_fan_sizeof", ExactSpelling = true)]
    public static extern int tri_fan_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint points_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_fan_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t tri_fan_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_render_pointfix_t *")] xcb_render_pointfix_t* points);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_fan", ExactSpelling = true)]
    public static extern xcb_void_cookie_t tri_fan(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_render_pointfix_t *")] xcb_render_pointfix_t* points);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_fan_points", ExactSpelling = true)]
    public static extern xcb_render_pointfix_t* tri_fan_points([NativeTypeName("const xcb_render_tri_fan_request_t *")] xcb_render_tri_fan_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_fan_points_length", ExactSpelling = true)]
    public static extern int tri_fan_points_length([NativeTypeName("const xcb_render_tri_fan_request_t *")] xcb_render_tri_fan_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_tri_fan_points_iterator", ExactSpelling = true)]
    public static extern xcb_render_pointfix_iterator_t tri_fan_points_iterator([NativeTypeName("const xcb_render_tri_fan_request_t *")] xcb_render_tri_fan_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_glyph_set_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_glyph_set_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint gsid, [NativeTypeName("xcb_render_pictformat_t")] uint format);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_glyph_set", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_glyph_set(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint gsid, [NativeTypeName("xcb_render_pictformat_t")] uint format);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_reference_glyph_set_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t reference_glyph_set_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint gsid, [NativeTypeName("xcb_render_glyphset_t")] uint existing);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_reference_glyph_set", ExactSpelling = true)]
    public static extern xcb_void_cookie_t reference_glyph_set(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint gsid, [NativeTypeName("xcb_render_glyphset_t")] uint existing);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_glyph_set_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t free_glyph_set_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_glyph_set", ExactSpelling = true)]
    public static extern xcb_void_cookie_t free_glyph_set(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_sizeof", ExactSpelling = true)]
    public static extern int add_glyphs_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint data_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t add_glyphs_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("uint32_t")] uint glyphs_len, [NativeTypeName("const uint32_t *")] uint* glyphids, [NativeTypeName("const xcb_render_glyphinfo_t *")] xcb_render_glyphinfo_t* glyphs, [NativeTypeName("uint32_t")] uint data_len, [NativeTypeName("const uint8_t *")] byte* data);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs", ExactSpelling = true)]
    public static extern xcb_void_cookie_t add_glyphs(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("uint32_t")] uint glyphs_len, [NativeTypeName("const uint32_t *")] uint* glyphids, [NativeTypeName("const xcb_render_glyphinfo_t *")] xcb_render_glyphinfo_t* glyphs, [NativeTypeName("uint32_t")] uint data_len, [NativeTypeName("const uint8_t *")] byte* data);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_glyphids", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t *")]
    public static extern uint* add_glyphs_glyphids([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_glyphids_length", ExactSpelling = true)]
    public static extern int add_glyphs_glyphids_length([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_glyphids_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t add_glyphs_glyphids_end([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_glyphs", ExactSpelling = true)]
    public static extern xcb_render_glyphinfo_t* add_glyphs_glyphs([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_glyphs_length", ExactSpelling = true)]
    public static extern int add_glyphs_glyphs_length([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_glyphs_iterator", ExactSpelling = true)]
    public static extern xcb_render_glyphinfo_iterator_t add_glyphs_glyphs_iterator([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_data", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* add_glyphs_data([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_data_length", ExactSpelling = true)]
    public static extern int add_glyphs_data_length([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_glyphs_data_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t add_glyphs_data_end([NativeTypeName("const xcb_render_add_glyphs_request_t *")] xcb_render_add_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_glyphs_sizeof", ExactSpelling = true)]
    public static extern int free_glyphs_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint glyphs_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_glyphs_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t free_glyphs_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("uint32_t")] uint glyphs_len, [NativeTypeName("const xcb_render_glyph_t *")] uint* glyphs);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_glyphs", ExactSpelling = true)]
    public static extern xcb_void_cookie_t free_glyphs(xcb_connection_t* c, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("uint32_t")] uint glyphs_len, [NativeTypeName("const xcb_render_glyph_t *")] uint* glyphs);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_glyphs_glyphs", ExactSpelling = true)]
    [return: NativeTypeName("xcb_render_glyph_t *")]
    public static extern uint* free_glyphs_glyphs([NativeTypeName("const xcb_render_free_glyphs_request_t *")] xcb_render_free_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_glyphs_glyphs_length", ExactSpelling = true)]
    public static extern int free_glyphs_glyphs_length([NativeTypeName("const xcb_render_free_glyphs_request_t *")] xcb_render_free_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_free_glyphs_glyphs_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t free_glyphs_glyphs_end([NativeTypeName("const xcb_render_free_glyphs_request_t *")] xcb_render_free_glyphs_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_8_sizeof", ExactSpelling = true)]
    public static extern int composite_glyphs_8_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint glyphcmds_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_8_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t composite_glyphs_8_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint glyphcmds_len, [NativeTypeName("const uint8_t *")] byte* glyphcmds);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_8", ExactSpelling = true)]
    public static extern xcb_void_cookie_t composite_glyphs_8(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint glyphcmds_len, [NativeTypeName("const uint8_t *")] byte* glyphcmds);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_8_glyphcmds", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* composite_glyphs_8_glyphcmds([NativeTypeName("const xcb_render_composite_glyphs_8_request_t *")] xcb_render_composite_glyphs_8_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_8_glyphcmds_length", ExactSpelling = true)]
    public static extern int composite_glyphs_8_glyphcmds_length([NativeTypeName("const xcb_render_composite_glyphs_8_request_t *")] xcb_render_composite_glyphs_8_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_8_glyphcmds_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t composite_glyphs_8_glyphcmds_end([NativeTypeName("const xcb_render_composite_glyphs_8_request_t *")] xcb_render_composite_glyphs_8_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_16_sizeof", ExactSpelling = true)]
    public static extern int composite_glyphs_16_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint glyphcmds_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_16_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t composite_glyphs_16_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint glyphcmds_len, [NativeTypeName("const uint8_t *")] byte* glyphcmds);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_16", ExactSpelling = true)]
    public static extern xcb_void_cookie_t composite_glyphs_16(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint glyphcmds_len, [NativeTypeName("const uint8_t *")] byte* glyphcmds);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_16_glyphcmds", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* composite_glyphs_16_glyphcmds([NativeTypeName("const xcb_render_composite_glyphs_16_request_t *")] xcb_render_composite_glyphs_16_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_16_glyphcmds_length", ExactSpelling = true)]
    public static extern int composite_glyphs_16_glyphcmds_length([NativeTypeName("const xcb_render_composite_glyphs_16_request_t *")] xcb_render_composite_glyphs_16_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_16_glyphcmds_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t composite_glyphs_16_glyphcmds_end([NativeTypeName("const xcb_render_composite_glyphs_16_request_t *")] xcb_render_composite_glyphs_16_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_32_sizeof", ExactSpelling = true)]
    public static extern int composite_glyphs_32_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint glyphcmds_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_32_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t composite_glyphs_32_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint glyphcmds_len, [NativeTypeName("const uint8_t *")] byte* glyphcmds);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_32", ExactSpelling = true)]
    public static extern xcb_void_cookie_t composite_glyphs_32(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint src, [NativeTypeName("xcb_render_picture_t")] uint dst, [NativeTypeName("xcb_render_pictformat_t")] uint mask_format, [NativeTypeName("xcb_render_glyphset_t")] uint glyphset, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint32_t")] uint glyphcmds_len, [NativeTypeName("const uint8_t *")] byte* glyphcmds);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_32_glyphcmds", ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* composite_glyphs_32_glyphcmds([NativeTypeName("const xcb_render_composite_glyphs_32_request_t *")] xcb_render_composite_glyphs_32_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_32_glyphcmds_length", ExactSpelling = true)]
    public static extern int composite_glyphs_32_glyphcmds_length([NativeTypeName("const xcb_render_composite_glyphs_32_request_t *")] xcb_render_composite_glyphs_32_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_composite_glyphs_32_glyphcmds_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t composite_glyphs_32_glyphcmds_end([NativeTypeName("const xcb_render_composite_glyphs_32_request_t *")] xcb_render_composite_glyphs_32_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_fill_rectangles_sizeof", ExactSpelling = true)]
    public static extern int fill_rectangles_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint rects_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_fill_rectangles_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t fill_rectangles_checked(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint dst, xcb_render_color_t color, [NativeTypeName("uint32_t")] uint rects_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rects);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_fill_rectangles", ExactSpelling = true)]
    public static extern xcb_void_cookie_t fill_rectangles(xcb_connection_t* c, [NativeTypeName("uint8_t")] byte op, [NativeTypeName("xcb_render_picture_t")] uint dst, xcb_render_color_t color, [NativeTypeName("uint32_t")] uint rects_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rects);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_fill_rectangles_rects", ExactSpelling = true)]
    public static extern xcb_rectangle_t* fill_rectangles_rects([NativeTypeName("const xcb_render_fill_rectangles_request_t *")] xcb_render_fill_rectangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_fill_rectangles_rects_length", ExactSpelling = true)]
    public static extern int fill_rectangles_rects_length([NativeTypeName("const xcb_render_fill_rectangles_request_t *")] xcb_render_fill_rectangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_fill_rectangles_rects_iterator", ExactSpelling = true)]
    public static extern xcb_rectangle_iterator_t fill_rectangles_rects_iterator([NativeTypeName("const xcb_render_fill_rectangles_request_t *")] xcb_render_fill_rectangles_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_cursor_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_cursor_checked(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint cid, [NativeTypeName("xcb_render_picture_t")] uint source, [NativeTypeName("uint16_t")] ushort x, [NativeTypeName("uint16_t")] ushort y);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_cursor", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_cursor(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint cid, [NativeTypeName("xcb_render_picture_t")] uint source, [NativeTypeName("uint16_t")] ushort x, [NativeTypeName("uint16_t")] ushort y);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_transform_next", ExactSpelling = true)]
    public static extern void transform_next(xcb_render_transform_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_transform_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t transform_end(xcb_render_transform_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_transform_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_picture_transform_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_transform_t transform);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_transform", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_picture_transform(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_transform_t transform);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters_sizeof", ExactSpelling = true)]
    public static extern int query_filters_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters", ExactSpelling = true)]
    public static extern xcb_render_query_filters_cookie_t query_filters(xcb_connection_t* c, [NativeTypeName("xcb_drawable_t")] uint drawable);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters_unchecked", ExactSpelling = true)]
    public static extern xcb_render_query_filters_cookie_t query_filters_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_drawable_t")] uint drawable);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters_aliases", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t *")]
    public static extern ushort* query_filters_aliases([NativeTypeName("const xcb_render_query_filters_reply_t *")] xcb_render_query_filters_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters_aliases_length", ExactSpelling = true)]
    public static extern int query_filters_aliases_length([NativeTypeName("const xcb_render_query_filters_reply_t *")] xcb_render_query_filters_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters_aliases_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t query_filters_aliases_end([NativeTypeName("const xcb_render_query_filters_reply_t *")] xcb_render_query_filters_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters_filters_length", ExactSpelling = true)]
    public static extern int query_filters_filters_length([NativeTypeName("const xcb_render_query_filters_reply_t *")] xcb_render_query_filters_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters_filters_iterator", ExactSpelling = true)]
    public static extern xcb_str_iterator_t query_filters_filters_iterator([NativeTypeName("const xcb_render_query_filters_reply_t *")] xcb_render_query_filters_reply_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_query_filters_reply", ExactSpelling = true)]
    public static extern xcb_render_query_filters_reply_t* query_filters_reply(xcb_connection_t* c, xcb_render_query_filters_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter_sizeof", ExactSpelling = true)]
    public static extern int set_picture_filter_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint values_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_picture_filter_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("uint16_t")] ushort filter_len, [NativeTypeName("const char *")] sbyte* filter, [NativeTypeName("uint32_t")] uint values_len, [NativeTypeName("const xcb_render_fixed_t *")] int* values);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter", ExactSpelling = true)]
    public static extern xcb_void_cookie_t set_picture_filter(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("uint16_t")] ushort filter_len, [NativeTypeName("const char *")] sbyte* filter, [NativeTypeName("uint32_t")] uint values_len, [NativeTypeName("const xcb_render_fixed_t *")] int* values);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter_filter", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* set_picture_filter_filter([NativeTypeName("const xcb_render_set_picture_filter_request_t *")] xcb_render_set_picture_filter_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter_filter_length", ExactSpelling = true)]
    public static extern int set_picture_filter_filter_length([NativeTypeName("const xcb_render_set_picture_filter_request_t *")] xcb_render_set_picture_filter_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter_filter_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_picture_filter_filter_end([NativeTypeName("const xcb_render_set_picture_filter_request_t *")] xcb_render_set_picture_filter_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter_values", ExactSpelling = true)]
    [return: NativeTypeName("xcb_render_fixed_t *")]
    public static extern int* set_picture_filter_values([NativeTypeName("const xcb_render_set_picture_filter_request_t *")] xcb_render_set_picture_filter_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter_values_length", ExactSpelling = true)]
    public static extern int set_picture_filter_values_length([NativeTypeName("const xcb_render_set_picture_filter_request_t *")] xcb_render_set_picture_filter_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_set_picture_filter_values_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t set_picture_filter_values_end([NativeTypeName("const xcb_render_set_picture_filter_request_t *")] xcb_render_set_picture_filter_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_animcursorelt_next", ExactSpelling = true)]
    public static extern void animcursorelt_next(xcb_render_animcursorelt_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_animcursorelt_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t animcursorelt_end(xcb_render_animcursorelt_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_anim_cursor_sizeof", ExactSpelling = true)]
    public static extern int create_anim_cursor_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint cursors_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_anim_cursor_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_anim_cursor_checked(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint cid, [NativeTypeName("uint32_t")] uint cursors_len, [NativeTypeName("const xcb_render_animcursorelt_t *")] xcb_render_animcursorelt_t* cursors);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_anim_cursor", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_anim_cursor(xcb_connection_t* c, [NativeTypeName("xcb_cursor_t")] uint cid, [NativeTypeName("uint32_t")] uint cursors_len, [NativeTypeName("const xcb_render_animcursorelt_t *")] xcb_render_animcursorelt_t* cursors);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_anim_cursor_cursors", ExactSpelling = true)]
    public static extern xcb_render_animcursorelt_t* create_anim_cursor_cursors([NativeTypeName("const xcb_render_create_anim_cursor_request_t *")] xcb_render_create_anim_cursor_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_anim_cursor_cursors_length", ExactSpelling = true)]
    public static extern int create_anim_cursor_cursors_length([NativeTypeName("const xcb_render_create_anim_cursor_request_t *")] xcb_render_create_anim_cursor_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_anim_cursor_cursors_iterator", ExactSpelling = true)]
    public static extern xcb_render_animcursorelt_iterator_t create_anim_cursor_cursors_iterator([NativeTypeName("const xcb_render_create_anim_cursor_request_t *")] xcb_render_create_anim_cursor_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_spanfix_next", ExactSpelling = true)]
    public static extern void spanfix_next(xcb_render_spanfix_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_spanfix_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t spanfix_end(xcb_render_spanfix_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trap_next", ExactSpelling = true)]
    public static extern void trap_next(xcb_render_trap_iterator_t* i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_trap_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t trap_end(xcb_render_trap_iterator_t i);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_traps_sizeof", ExactSpelling = true)]
    public static extern int add_traps_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint traps_len);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_traps_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t add_traps_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("int16_t")] short x_off, [NativeTypeName("int16_t")] short y_off, [NativeTypeName("uint32_t")] uint traps_len, [NativeTypeName("const xcb_render_trap_t *")] xcb_render_trap_t* traps);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_traps", ExactSpelling = true)]
    public static extern xcb_void_cookie_t add_traps(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, [NativeTypeName("int16_t")] short x_off, [NativeTypeName("int16_t")] short y_off, [NativeTypeName("uint32_t")] uint traps_len, [NativeTypeName("const xcb_render_trap_t *")] xcb_render_trap_t* traps);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_traps_traps", ExactSpelling = true)]
    public static extern xcb_render_trap_t* add_traps_traps([NativeTypeName("const xcb_render_add_traps_request_t *")] xcb_render_add_traps_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_traps_traps_length", ExactSpelling = true)]
    public static extern int add_traps_traps_length([NativeTypeName("const xcb_render_add_traps_request_t *")] xcb_render_add_traps_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_add_traps_traps_iterator", ExactSpelling = true)]
    public static extern xcb_render_trap_iterator_t add_traps_traps_iterator([NativeTypeName("const xcb_render_add_traps_request_t *")] xcb_render_add_traps_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_solid_fill_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_solid_fill_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_color_t color);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_solid_fill", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_solid_fill(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_color_t color);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient_sizeof", ExactSpelling = true)]
    public static extern int create_linear_gradient_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_linear_gradient_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_pointfix_t p1, xcb_render_pointfix_t p2, [NativeTypeName("uint32_t")] uint num_stops, [NativeTypeName("const xcb_render_fixed_t *")] int* stops, [NativeTypeName("const xcb_render_color_t *")] xcb_render_color_t* colors);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_linear_gradient(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_pointfix_t p1, xcb_render_pointfix_t p2, [NativeTypeName("uint32_t")] uint num_stops, [NativeTypeName("const xcb_render_fixed_t *")] int* stops, [NativeTypeName("const xcb_render_color_t *")] xcb_render_color_t* colors);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient_stops", ExactSpelling = true)]
    [return: NativeTypeName("xcb_render_fixed_t *")]
    public static extern int* create_linear_gradient_stops([NativeTypeName("const xcb_render_create_linear_gradient_request_t *")] xcb_render_create_linear_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient_stops_length", ExactSpelling = true)]
    public static extern int create_linear_gradient_stops_length([NativeTypeName("const xcb_render_create_linear_gradient_request_t *")] xcb_render_create_linear_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient_stops_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t create_linear_gradient_stops_end([NativeTypeName("const xcb_render_create_linear_gradient_request_t *")] xcb_render_create_linear_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient_colors", ExactSpelling = true)]
    public static extern xcb_render_color_t* create_linear_gradient_colors([NativeTypeName("const xcb_render_create_linear_gradient_request_t *")] xcb_render_create_linear_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient_colors_length", ExactSpelling = true)]
    public static extern int create_linear_gradient_colors_length([NativeTypeName("const xcb_render_create_linear_gradient_request_t *")] xcb_render_create_linear_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_linear_gradient_colors_iterator", ExactSpelling = true)]
    public static extern xcb_render_color_iterator_t create_linear_gradient_colors_iterator([NativeTypeName("const xcb_render_create_linear_gradient_request_t *")] xcb_render_create_linear_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient_sizeof", ExactSpelling = true)]
    public static extern int create_radial_gradient_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_radial_gradient_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_pointfix_t inner, xcb_render_pointfix_t outer, [NativeTypeName("xcb_render_fixed_t")] int inner_radius, [NativeTypeName("xcb_render_fixed_t")] int outer_radius, [NativeTypeName("uint32_t")] uint num_stops, [NativeTypeName("const xcb_render_fixed_t *")] int* stops, [NativeTypeName("const xcb_render_color_t *")] xcb_render_color_t* colors);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_radial_gradient(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_pointfix_t inner, xcb_render_pointfix_t outer, [NativeTypeName("xcb_render_fixed_t")] int inner_radius, [NativeTypeName("xcb_render_fixed_t")] int outer_radius, [NativeTypeName("uint32_t")] uint num_stops, [NativeTypeName("const xcb_render_fixed_t *")] int* stops, [NativeTypeName("const xcb_render_color_t *")] xcb_render_color_t* colors);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient_stops", ExactSpelling = true)]
    [return: NativeTypeName("xcb_render_fixed_t *")]
    public static extern int* create_radial_gradient_stops([NativeTypeName("const xcb_render_create_radial_gradient_request_t *")] xcb_render_create_radial_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient_stops_length", ExactSpelling = true)]
    public static extern int create_radial_gradient_stops_length([NativeTypeName("const xcb_render_create_radial_gradient_request_t *")] xcb_render_create_radial_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient_stops_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t create_radial_gradient_stops_end([NativeTypeName("const xcb_render_create_radial_gradient_request_t *")] xcb_render_create_radial_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient_colors", ExactSpelling = true)]
    public static extern xcb_render_color_t* create_radial_gradient_colors([NativeTypeName("const xcb_render_create_radial_gradient_request_t *")] xcb_render_create_radial_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient_colors_length", ExactSpelling = true)]
    public static extern int create_radial_gradient_colors_length([NativeTypeName("const xcb_render_create_radial_gradient_request_t *")] xcb_render_create_radial_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_radial_gradient_colors_iterator", ExactSpelling = true)]
    public static extern xcb_render_color_iterator_t create_radial_gradient_colors_iterator([NativeTypeName("const xcb_render_create_radial_gradient_request_t *")] xcb_render_create_radial_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient_sizeof", ExactSpelling = true)]
    public static extern int create_conical_gradient_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_conical_gradient_checked(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_pointfix_t center, [NativeTypeName("xcb_render_fixed_t")] int angle, [NativeTypeName("uint32_t")] uint num_stops, [NativeTypeName("const xcb_render_fixed_t *")] int* stops, [NativeTypeName("const xcb_render_color_t *")] xcb_render_color_t* colors);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient", ExactSpelling = true)]
    public static extern xcb_void_cookie_t create_conical_gradient(xcb_connection_t* c, [NativeTypeName("xcb_render_picture_t")] uint picture, xcb_render_pointfix_t center, [NativeTypeName("xcb_render_fixed_t")] int angle, [NativeTypeName("uint32_t")] uint num_stops, [NativeTypeName("const xcb_render_fixed_t *")] int* stops, [NativeTypeName("const xcb_render_color_t *")] xcb_render_color_t* colors);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient_stops", ExactSpelling = true)]
    [return: NativeTypeName("xcb_render_fixed_t *")]
    public static extern int* create_conical_gradient_stops([NativeTypeName("const xcb_render_create_conical_gradient_request_t *")] xcb_render_create_conical_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient_stops_length", ExactSpelling = true)]
    public static extern int create_conical_gradient_stops_length([NativeTypeName("const xcb_render_create_conical_gradient_request_t *")] xcb_render_create_conical_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient_stops_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t create_conical_gradient_stops_end([NativeTypeName("const xcb_render_create_conical_gradient_request_t *")] xcb_render_create_conical_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient_colors", ExactSpelling = true)]
    public static extern xcb_render_color_t* create_conical_gradient_colors([NativeTypeName("const xcb_render_create_conical_gradient_request_t *")] xcb_render_create_conical_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient_colors_length", ExactSpelling = true)]
    public static extern int create_conical_gradient_colors_length([NativeTypeName("const xcb_render_create_conical_gradient_request_t *")] xcb_render_create_conical_gradient_request_t* R);

    [DllImport("xcb-render", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_render_create_conical_gradient_colors_iterator", ExactSpelling = true)]
    public static extern xcb_render_color_iterator_t create_conical_gradient_colors_iterator([NativeTypeName("const xcb_render_create_conical_gradient_request_t *")] xcb_render_create_conical_gradient_request_t* R);

    [NativeTypeName("#define XCB_RENDER_MAJOR_VERSION 0")]
    public const int XCB_RENDER_MAJOR_VERSION = 0;

    [NativeTypeName("#define XCB_RENDER_MINOR_VERSION 11")]
    public const int XCB_RENDER_MINOR_VERSION = 11;

    [NativeTypeName("#define XCB_RENDER_PICT_FORMAT 0")]
    public const int XCB_RENDER_PICT_FORMAT = 0;

    [NativeTypeName("#define XCB_RENDER_PICTURE 1")]
    public const int XCB_RENDER_PICTURE = 1;

    [NativeTypeName("#define XCB_RENDER_PICT_OP 2")]
    public const int XCB_RENDER_PICT_OP = 2;

    [NativeTypeName("#define XCB_RENDER_GLYPH_SET 3")]
    public const int XCB_RENDER_GLYPH_SET = 3;

    [NativeTypeName("#define XCB_RENDER_GLYPH 4")]
    public const int XCB_RENDER_GLYPH = 4;

    [NativeTypeName("#define XCB_RENDER_QUERY_VERSION 0")]
    public const int XCB_RENDER_QUERY_VERSION = 0;

    [NativeTypeName("#define XCB_RENDER_QUERY_PICT_FORMATS 1")]
    public const int XCB_RENDER_QUERY_PICT_FORMATS = 1;

    [NativeTypeName("#define XCB_RENDER_QUERY_PICT_INDEX_VALUES 2")]
    public const int XCB_RENDER_QUERY_PICT_INDEX_VALUES = 2;

    [NativeTypeName("#define XCB_RENDER_CREATE_PICTURE 4")]
    public const int XCB_RENDER_CREATE_PICTURE = 4;

    [NativeTypeName("#define XCB_RENDER_CHANGE_PICTURE 5")]
    public const int XCB_RENDER_CHANGE_PICTURE = 5;

    [NativeTypeName("#define XCB_RENDER_SET_PICTURE_CLIP_RECTANGLES 6")]
    public const int XCB_RENDER_SET_PICTURE_CLIP_RECTANGLES = 6;

    [NativeTypeName("#define XCB_RENDER_FREE_PICTURE 7")]
    public const int XCB_RENDER_FREE_PICTURE = 7;

    [NativeTypeName("#define XCB_RENDER_COMPOSITE 8")]
    public const int XCB_RENDER_COMPOSITE = 8;

    [NativeTypeName("#define XCB_RENDER_TRAPEZOIDS 10")]
    public const int XCB_RENDER_TRAPEZOIDS = 10;

    [NativeTypeName("#define XCB_RENDER_TRIANGLES 11")]
    public const int XCB_RENDER_TRIANGLES = 11;

    [NativeTypeName("#define XCB_RENDER_TRI_STRIP 12")]
    public const int XCB_RENDER_TRI_STRIP = 12;

    [NativeTypeName("#define XCB_RENDER_TRI_FAN 13")]
    public const int XCB_RENDER_TRI_FAN = 13;

    [NativeTypeName("#define XCB_RENDER_CREATE_GLYPH_SET 17")]
    public const int XCB_RENDER_CREATE_GLYPH_SET = 17;

    [NativeTypeName("#define XCB_RENDER_REFERENCE_GLYPH_SET 18")]
    public const int XCB_RENDER_REFERENCE_GLYPH_SET = 18;

    [NativeTypeName("#define XCB_RENDER_FREE_GLYPH_SET 19")]
    public const int XCB_RENDER_FREE_GLYPH_SET = 19;

    [NativeTypeName("#define XCB_RENDER_ADD_GLYPHS 20")]
    public const int XCB_RENDER_ADD_GLYPHS = 20;

    [NativeTypeName("#define XCB_RENDER_FREE_GLYPHS 22")]
    public const int XCB_RENDER_FREE_GLYPHS = 22;

    [NativeTypeName("#define XCB_RENDER_COMPOSITE_GLYPHS_8 23")]
    public const int XCB_RENDER_COMPOSITE_GLYPHS_8 = 23;

    [NativeTypeName("#define XCB_RENDER_COMPOSITE_GLYPHS_16 24")]
    public const int XCB_RENDER_COMPOSITE_GLYPHS_16 = 24;

    [NativeTypeName("#define XCB_RENDER_COMPOSITE_GLYPHS_32 25")]
    public const int XCB_RENDER_COMPOSITE_GLYPHS_32 = 25;

    [NativeTypeName("#define XCB_RENDER_FILL_RECTANGLES 26")]
    public const int XCB_RENDER_FILL_RECTANGLES = 26;

    [NativeTypeName("#define XCB_RENDER_CREATE_CURSOR 27")]
    public const int XCB_RENDER_CREATE_CURSOR = 27;

    [NativeTypeName("#define XCB_RENDER_SET_PICTURE_TRANSFORM 28")]
    public const int XCB_RENDER_SET_PICTURE_TRANSFORM = 28;

    [NativeTypeName("#define XCB_RENDER_QUERY_FILTERS 29")]
    public const int XCB_RENDER_QUERY_FILTERS = 29;

    [NativeTypeName("#define XCB_RENDER_SET_PICTURE_FILTER 30")]
    public const int XCB_RENDER_SET_PICTURE_FILTER = 30;

    [NativeTypeName("#define XCB_RENDER_CREATE_ANIM_CURSOR 31")]
    public const int XCB_RENDER_CREATE_ANIM_CURSOR = 31;

    [NativeTypeName("#define XCB_RENDER_ADD_TRAPS 32")]
    public const int XCB_RENDER_ADD_TRAPS = 32;

    [NativeTypeName("#define XCB_RENDER_CREATE_SOLID_FILL 33")]
    public const int XCB_RENDER_CREATE_SOLID_FILL = 33;

    [NativeTypeName("#define XCB_RENDER_CREATE_LINEAR_GRADIENT 34")]
    public const int XCB_RENDER_CREATE_LINEAR_GRADIENT = 34;

    [NativeTypeName("#define XCB_RENDER_CREATE_RADIAL_GRADIENT 35")]
    public const int XCB_RENDER_CREATE_RADIAL_GRADIENT = 35;

    [NativeTypeName("#define XCB_RENDER_CREATE_CONICAL_GRADIENT 36")]
    public const int XCB_RENDER_CREATE_CONICAL_GRADIENT = 36;
}

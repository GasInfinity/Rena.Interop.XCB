using System.Runtime.InteropServices;

namespace Rena.Interop.Xcb;

public static unsafe partial class XcbShape
{
    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_op_next", ExactSpelling = true)]
    public static extern void op_next(xcb_shape_op_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_op_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t op_end(xcb_shape_op_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_kind_next", ExactSpelling = true)]
    public static extern void kind_next(xcb_shape_kind_iterator_t* i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_kind_end", ExactSpelling = true)]
    public static extern xcb_generic_iterator_t kind_end(xcb_shape_kind_iterator_t i);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_query_version", ExactSpelling = true)]
    public static extern xcb_shape_query_version_cookie_t query_version(xcb_connection_t* c);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_query_version_unchecked", ExactSpelling = true)]
    public static extern xcb_shape_query_version_cookie_t query_version_unchecked(xcb_connection_t* c);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_query_version_reply", ExactSpelling = true)]
    public static extern xcb_shape_query_version_reply_t* query_version_reply(xcb_connection_t* c, xcb_shape_query_version_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_rectangles_sizeof", ExactSpelling = true)]
    public static extern int rectangles_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint rectangles_len);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_rectangles_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t rectangles_checked(xcb_connection_t* c, [NativeTypeName("xcb_shape_op_t")] byte operation, [NativeTypeName("xcb_shape_kind_t")] byte destination_kind, [NativeTypeName("uint8_t")] byte ordering, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_rectangles", ExactSpelling = true)]
    public static extern xcb_void_cookie_t rectangles(xcb_connection_t* c, [NativeTypeName("xcb_shape_op_t")] byte operation, [NativeTypeName("xcb_shape_kind_t")] byte destination_kind, [NativeTypeName("uint8_t")] byte ordering, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_rectangles_rectangles", ExactSpelling = true)]
    public static extern xcb_rectangle_t* rectangles_rectangles([NativeTypeName("const xcb_shape_rectangles_request_t *")] xcb_shape_rectangles_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_rectangles_rectangles_length", ExactSpelling = true)]
    public static extern int rectangles_rectangles_length([NativeTypeName("const xcb_shape_rectangles_request_t *")] xcb_shape_rectangles_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_rectangles_rectangles_iterator", ExactSpelling = true)]
    public static extern xcb_rectangle_iterator_t rectangles_rectangles_iterator([NativeTypeName("const xcb_shape_rectangles_request_t *")] xcb_shape_rectangles_request_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_mask_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t mask_checked(xcb_connection_t* c, [NativeTypeName("xcb_shape_op_t")] byte operation, [NativeTypeName("xcb_shape_kind_t")] byte destination_kind, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset, [NativeTypeName("xcb_pixmap_t")] uint source_bitmap);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_mask", ExactSpelling = true)]
    public static extern xcb_void_cookie_t mask(xcb_connection_t* c, [NativeTypeName("xcb_shape_op_t")] byte operation, [NativeTypeName("xcb_shape_kind_t")] byte destination_kind, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset, [NativeTypeName("xcb_pixmap_t")] uint source_bitmap);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_combine_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t combine_checked(xcb_connection_t* c, [NativeTypeName("xcb_shape_op_t")] byte operation, [NativeTypeName("xcb_shape_kind_t")] byte destination_kind, [NativeTypeName("xcb_shape_kind_t")] byte source_kind, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset, [NativeTypeName("xcb_window_t")] uint source_window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_combine", ExactSpelling = true)]
    public static extern xcb_void_cookie_t combine(xcb_connection_t* c, [NativeTypeName("xcb_shape_op_t")] byte operation, [NativeTypeName("xcb_shape_kind_t")] byte destination_kind, [NativeTypeName("xcb_shape_kind_t")] byte source_kind, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset, [NativeTypeName("xcb_window_t")] uint source_window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_offset_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t offset_checked(xcb_connection_t* c, [NativeTypeName("xcb_shape_kind_t")] byte destination_kind, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_offset", ExactSpelling = true)]
    public static extern xcb_void_cookie_t offset(xcb_connection_t* c, [NativeTypeName("xcb_shape_kind_t")] byte destination_kind, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("int16_t")] short x_offset, [NativeTypeName("int16_t")] short y_offset);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_query_extents", ExactSpelling = true)]
    public static extern xcb_shape_query_extents_cookie_t query_extents(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint destination_window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_query_extents_unchecked", ExactSpelling = true)]
    public static extern xcb_shape_query_extents_cookie_t query_extents_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint destination_window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_query_extents_reply", ExactSpelling = true)]
    public static extern xcb_shape_query_extents_reply_t* query_extents_reply(xcb_connection_t* c, xcb_shape_query_extents_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_select_input_checked", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_input_checked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("uint8_t")] byte enable);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_select_input", ExactSpelling = true)]
    public static extern xcb_void_cookie_t select_input(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint destination_window, [NativeTypeName("uint8_t")] byte enable);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_input_selected", ExactSpelling = true)]
    public static extern xcb_shape_input_selected_cookie_t input_selected(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint destination_window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_input_selected_unchecked", ExactSpelling = true)]
    public static extern xcb_shape_input_selected_cookie_t input_selected_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint destination_window);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_input_selected_reply", ExactSpelling = true)]
    public static extern xcb_shape_input_selected_reply_t* input_selected_reply(xcb_connection_t* c, xcb_shape_input_selected_cookie_t cookie, xcb_generic_error_t** e);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_get_rectangles_sizeof", ExactSpelling = true)]
    public static extern int get_rectangles_sizeof([NativeTypeName("const void *")] void* _buffer);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_get_rectangles", ExactSpelling = true)]
    public static extern xcb_shape_get_rectangles_cookie_t get_rectangles(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_shape_kind_t")] byte source_kind);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_get_rectangles_unchecked", ExactSpelling = true)]
    public static extern xcb_shape_get_rectangles_cookie_t get_rectangles_unchecked(xcb_connection_t* c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_shape_kind_t")] byte source_kind);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_get_rectangles_rectangles", ExactSpelling = true)]
    public static extern xcb_rectangle_t* get_rectangles_rectangles([NativeTypeName("const xcb_shape_get_rectangles_reply_t *")] xcb_shape_get_rectangles_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_get_rectangles_rectangles_length", ExactSpelling = true)]
    public static extern int get_rectangles_rectangles_length([NativeTypeName("const xcb_shape_get_rectangles_reply_t *")] xcb_shape_get_rectangles_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_get_rectangles_rectangles_iterator", ExactSpelling = true)]
    public static extern xcb_rectangle_iterator_t get_rectangles_rectangles_iterator([NativeTypeName("const xcb_shape_get_rectangles_reply_t *")] xcb_shape_get_rectangles_reply_t* R);

    [DllImport("xcb", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xcb_shape_get_rectangles_reply", ExactSpelling = true)]
    public static extern xcb_shape_get_rectangles_reply_t* get_rectangles_reply(xcb_connection_t* c, xcb_shape_get_rectangles_cookie_t cookie, xcb_generic_error_t** e);

    [NativeTypeName("#define XCB_SHAPE_MAJOR_VERSION 1")]
    public const int XCB_SHAPE_MAJOR_VERSION = 1;

    [NativeTypeName("#define XCB_SHAPE_MINOR_VERSION 1")]
    public const int XCB_SHAPE_MINOR_VERSION = 1;

    [NativeTypeName("#define XCB_SHAPE_NOTIFY 0")]
    public const int XCB_SHAPE_NOTIFY = 0;

    [NativeTypeName("#define XCB_SHAPE_QUERY_VERSION 0")]
    public const int XCB_SHAPE_QUERY_VERSION = 0;

    [NativeTypeName("#define XCB_SHAPE_RECTANGLES 1")]
    public const int XCB_SHAPE_RECTANGLES = 1;

    [NativeTypeName("#define XCB_SHAPE_MASK 2")]
    public const int XCB_SHAPE_MASK = 2;

    [NativeTypeName("#define XCB_SHAPE_COMBINE 3")]
    public const int XCB_SHAPE_COMBINE = 3;

    [NativeTypeName("#define XCB_SHAPE_OFFSET 4")]
    public const int XCB_SHAPE_OFFSET = 4;

    [NativeTypeName("#define XCB_SHAPE_QUERY_EXTENTS 5")]
    public const int XCB_SHAPE_QUERY_EXTENTS = 5;

    [NativeTypeName("#define XCB_SHAPE_SELECT_INPUT 6")]
    public const int XCB_SHAPE_SELECT_INPUT = 6;

    [NativeTypeName("#define XCB_SHAPE_INPUT_SELECTED 7")]
    public const int XCB_SHAPE_INPUT_SELECTED = 7;

    [NativeTypeName("#define XCB_SHAPE_GET_RECTANGLES 8")]
    public const int XCB_SHAPE_GET_RECTANGLES = 8;
}

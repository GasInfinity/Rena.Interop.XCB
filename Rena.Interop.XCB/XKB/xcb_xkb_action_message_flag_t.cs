namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_action_message_flag_t : uint
{
    XCB_XKB_ACTION_MESSAGE_FLAG_ON_PRESS = 1,
    XCB_XKB_ACTION_MESSAGE_FLAG_ON_RELEASE = 2,
    XCB_XKB_ACTION_MESSAGE_FLAG_GEN_KEY_EVENT = 4,
}

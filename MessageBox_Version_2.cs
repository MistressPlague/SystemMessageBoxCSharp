using System;
using System.Runtime.InteropServices;

namespace User32
{
    /// <summary>
    /// The Main MessageBox Class
    /// </summary>
    public static class MessageBox
    {
        /// <summary>
        /// Internal MessageBox Call.
        /// </summary>
        /// <param name="hWnd">Window Handle.</param>
        /// <param name="lpText">Main Text.</param>
        /// <param name="lpCaption">Title Text.</param>
        /// <param name="uType">Parameters.</param>
        /// <returns>Result As Int, Later Casted To MessageBoxResult.</returns>
        [DllImport("user32.dll")]
        private static extern int MessageBoxA(IntPtr hWnd,
            string lpText,
            string lpCaption,
            uint uType);

        /// <summary>
        /// Indicates This Is A Top Most MessageBox.
        /// </summary>
        private const uint MB_TOPMOST = 0x40000;

        /// <summary>
        /// Sets This MessageBox As Foreground On Creation.
        /// </summary>
        private const uint MB_SETFOREGROUND = 0x10000;

        /// <summary>
        /// Shows A Simple MessageBox.
        /// </summary>
        /// <param name="text">The Main Text In The MessageBox.</param>
        /// <param name="TopMost">Whether To Force This MessageBox On Top Of Anything It Can.</param>
        /// <returns>The Result Indicating What Button Was Pressed</returns>
        public static MessageBoxResult Show(string text, bool TopMost = false)
        {
            var type = (uint)MessageBoxButtons.Ok;

            if (TopMost)
            {
                type |= MB_TOPMOST;
                type |= MB_SETFOREGROUND;
            }

            return (MessageBoxResult)MessageBoxA(IntPtr.Zero, text, "\0", type);
        }

        /// <summary>
        /// Shows A Simple MessageBox.
        /// </summary>
        /// <param name="text">The Main Text In The MessageBox.</param>
        /// <param name="caption">The Title Text In The MessageBox.</param>
        /// <param name="TopMost">Whether To Force This MessageBox On Top Of Anything It Can.</param>
        /// <returns>The Result Indicating What Button Was Pressed</returns>
        public static MessageBoxResult Show(string text, string caption, bool TopMost = false)
        {
            var type = (uint)MessageBoxButtons.Ok;

            if (TopMost)
            {
                type |= MB_TOPMOST;
                type |= MB_SETFOREGROUND;
            }

            return (MessageBoxResult)MessageBoxA(IntPtr.Zero, text, caption, type);
        }

        /// <summary>
        /// Shows A Simple MessageBox.
        /// </summary>
        /// <param name="text">The Main Text In The MessageBox.</param>
        /// <param name="caption">The Title Text In The MessageBox.</param>
        /// <param name="buttons">The Buttons To Show In The MessageBox.</param>
        /// <param name="TopMost">Whether To Force This MessageBox On Top Of Anything It Can.</param>
        /// <returns>The Result Indicating What Button Was Pressed</returns>
        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.Ok, bool TopMost = false)
        {
            var Buttons = (uint)buttons;

            if (TopMost)
            {
                Buttons |= MB_TOPMOST;
                Buttons |= MB_SETFOREGROUND;
            }

            return (MessageBoxResult)MessageBoxA(IntPtr.Zero, text, caption, Buttons);
        }

        /// <summary>
        /// Shows A Simple MessageBox.
        /// </summary>
        /// <param name="text">The Main Text In The MessageBox.</param>
        /// <param name="caption">The Title Text In The MessageBox.</param>
        /// <param name="buttons">The Buttons To Show In The MessageBox.</param>
        /// <param name="icon">The Icon To Show In The MessageBox.</param>
        /// <param name="TopMost">Whether To Force This MessageBox On Top Of Anything It Can.</param>
        /// <returns>The Result Indicating What Button Was Pressed</returns>
        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool TopMost = false)
        {
            var Buttons = (uint)buttons;

            if (TopMost)
            {
                Buttons |= MB_TOPMOST;
                Buttons |= MB_SETFOREGROUND;
            }

            return (MessageBoxResult)MessageBoxA(IntPtr.Zero, text, caption, (Buttons) | ((uint)icon));
        }

        /// <summary>
        /// Shows A Simple MessageBox.
        /// </summary>
        /// <param name="text">The Main Text In The MessageBox.</param>
        /// <param name="caption">The Title Text In The MessageBox.</param>
        /// <param name="buttons">The Buttons To Show In The MessageBox.</param>
        /// <param name="icon">The Icon To Show In The MessageBox.</param>
        /// <param name="button">The Button Pre-Selected By Default Upon The MessageBox Showing (Left To Right).</param>
        /// <param name="TopMost">Whether To Force This MessageBox On Top Of Anything It Can.</param>
        /// <returns>The Result Indicating What Button Was Pressed</returns>
        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton button, bool TopMost = false)
        {
            var Buttons = (uint)buttons;

            if (TopMost)
            {
                Buttons |= MB_TOPMOST;
                Buttons |= MB_SETFOREGROUND;
            }

            return (MessageBoxResult)MessageBoxA(IntPtr.Zero, text, caption, (Buttons) | ((uint)icon) | ((uint)button));
        }

        /// <summary>
        /// Shows A Simple MessageBox.
        /// </summary>
        /// <param name="text">The Main Text In The MessageBox.</param>
        /// <param name="caption">The Title Text In The MessageBox.</param>
        /// <param name="buttons">The Buttons To Show In The MessageBox.</param>
        /// <param name="icon">The Icon To Show In The MessageBox.</param>
        /// <param name="button">The Button Pre-Selected By Default Upon The MessageBox Showing (Left To Right).</param>
        /// <param name="modal">The modality of the MessageBox.</param>
        /// <param name="TopMost">Whether To Force This MessageBox On Top Of Anything It Can.</param>
        /// <returns>The Result Indicating What Button Was Pressed</returns>
        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton button, MessageBoxModal modal, bool TopMost = false)
        {
            var Buttons = (uint)buttons;

            if (TopMost)
            {
                Buttons |= MB_TOPMOST;
                Buttons |= MB_SETFOREGROUND;
            }

            return (MessageBoxResult)MessageBoxA(IntPtr.Zero, text, caption, (Buttons) | ((uint)icon) | ((uint)button) | ((uint)modal));
        }
    }

    /// <summary>
    /// The buttons to offer to the user on the message box.
    /// </summary>
    public enum MessageBoxButtons
    {
        /// <summary>
        /// The message box contains three push buttons: Abort, Retry, and Ignore.
        /// </summary>
        AbortRetryIgnore = 0x2,

        /// <summary>
        /// The message box contains three push buttons: Cancel, Try Again, Continue.
        /// </summary>
        CancelTryIgnore = 0x6,

        /// <summary>
        /// Adds a Help button to the message box.
        /// </summary>
        Help = 0x4000,

        /// <summary>
        /// The message box contains one push button: OK. This is the default.
        /// </summary>
        Ok = 0,

        /// <summary>
        /// The message box contains two push buttons: OK and Cancel.
        /// </summary>
        OkCancel = 0x1,

        /// <summary>
        /// The message box contains two push buttons: Retry and Cancel.
        /// </summary>
        RetryCancel = 0x5,

        /// <summary>
        /// The message box contains two push buttons: Yes and No.
        /// </summary>
        YesNo = 0x4,

        /// <summary>
        /// The message box contains three push buttons: Yes, No, and Cancel.
        /// </summary>
        YesNoCancel = 0x3
    }

    /// <summary>
    /// To display an icon in the message box, specify one of the following values.
    /// </summary>
    public enum MessageBoxIcon : uint
    {
        /// <summary>
        /// An exclamation-point icon appears in the message box.
        /// </summary>
        Warning = 0x30,

        /// <summary>
        /// An icon consisting of a lowercase letter `i` in a circle appears in the message box.
        /// </summary>
        Information = 0x40,

        /// <summary>
        /// A question-mark icon appears in the message box.
        /// </summary>
        /// <remarks>
        /// The question-mark message icon is no longer recommended because it does not clearly represent a specific type of message and because the phrasing of a message as a question could apply to any message type. In addition, users can confuse the message symbol question mark with Help information. Therefore, do not use this question mark message symbol in your message boxes. The system continues to support its inclusion only for backward compatibility.
        /// </remarks>
        Question = 0x20,

        /// <summary>
        /// A stop-sign icon appears in the message box.
        /// </summary>
        Error = 0x10
    }

    /// <summary>
    /// To indicate the default button, specify one of the following values.
    /// </summary>
    public enum MessageBoxDefaultButton : uint
    {
        /// <summary>
        /// The first button is the default button.
        /// </summary>
        Button1 = 0,

        /// <summary>
        /// The second button is the default button.
        /// </summary>
        Button2 = 0x100,

        /// <summary>
        /// The third button is the default button.
        /// </summary>
        Button3 = 0x200,

        /// <summary>
        /// The fourth button is the default button.
        /// </summary>
        Button4 = 0x300,
    }

    /// <summary>
    /// To indicate the modality of the dialog box, specify one of the following values.
    /// </summary>
    public enum MessageBoxModal : uint
    {
        /// <summary>
        /// The user must respond to the message box before continuing work in the window identified by the hWnd parameter. However, the user can move to the windows of other threads and work in those windows. Depending on the hierarchy of windows in the application, the user may be able to move to other windows within the thread. All child windows of the parent of the message box are automatically disabled, but pop-up windows are not.
        /// </summary>
        Application = 0,

        /// <summary>
        /// Same as <see cref="Application"/> except that the message box has the Top Most style. Use system-modal message boxes to notify the user of serious, potentially damaging errors that require immediate attention (for example, running out of memory).
        /// </summary>
        System = 0x1000,

        /// <summary>
        /// Same as <see cref="Application"/> except that all the top-level windows belonging to the current thread are disabled if the hWnd parameter is NULL. Use this flag when the calling application or library does not have a window handle available but still needs to prevent input to other windows in the calling thread without suspending other threads.
        /// </summary>
        Task = 0x2000
    }

    /// <summary>
    /// The message box returns an integer value that indicates which button the user clicked.
    /// </summary>
    public enum MessageBoxResult
    {
        /// <summary>
        /// The 'Abort' button was selected.
        /// </summary>
        Abort = 3,

        /// <summary>
        /// The 'Cancel' button was selected.
        /// </summary>
        Cancel = 2,

        /// <summary>
        /// The 'Continue' button was selected.
        /// </summary>
        Continue = 11,

        /// <summary>
        /// The 'Ignore' button was selected.
        /// </summary>
        Ignore = 5,

        /// <summary>
        /// The 'No' button was selected.
        /// </summary>
        No = 7,

        /// <summary>
        /// The 'OK' button was selected.
        /// </summary>
        Ok = 1,

        /// <summary>
        /// The 'Retry' button was selected.
        /// </summary>
        Retry = 10,

        /// <summary>
        /// The 'Yes' button was selected.
        /// </summary>
        Yes = 6
    }
}

using System;
using System.Runtime.InteropServices;

namespace SystemMessageBoxCSharp
{
    public class MessageBoxUtils
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBox(IntPtr nWnd, string text, string title, uint type);

        public static MessageBoxResult Show(string text, string title, uint type)
        {
            return (MessageBoxResult)MessageBox(IntPtr.Zero, text, title, type);
        }

        public enum MessageBoxButtons
        {
            MB_OK = 0,
            MB_OKCANCEL = 0x01,
            MB_ABORTRETRYIGNORE = 0x02,
            MB_YESNOCANCEL = 0x03,
            MB_YESNO = 0x04,
            MB_RETRYCANCEL = 0x05,
            MB_CANCELTRYCONTINUE = 0x06,
            MB_HELP = 0x4000,
        }

        public enum MessageBoxIcon
        {
            MB_ICONERROR = 0x10,
            MB_ICONQUESTION = 0x20,
            MB_ICONEXCLAMATION = 0x30,
            MB_ICONINFORMATION = 0x40
        }

        public enum MessageBoxDefaultButton
        {
            FirstButton = 0,
            SecondButton = 0x100,
            ThirdButton = 0x200,
            FourthButton = 0x300
        }

        public enum MessageBoxBehaviour
        {
            LockOnlyMainThread = 0,
            LockOnlyMainThreadTopMost = 0x1000,
            LockAllThreadsIfNULL = 0x2000
        }

        public enum MessageBoxDisplaySettings
        {
            SetForeground = 0x10000,
            OnlyReturnIfOnDesktop = 0x20000,
            TopMost = 0x40000,
            RightJustifiedText = 0x80000,
            RightToLeftHebrewArabicText = 0x100000,
            ServiceNotification = 0x200000, //The caller is a service notifying the user of an event. The function displays a message box on the current active desktop, even if there is no user logged on to the computer.
        }

        public enum MessageBoxResult
        {
            OK = 1,
            Cancel = 2,
            Abort = 3,
            Retry = 4,
            Ignore = 5,
            Yes = 6,
            No = 7,
            TryAgain = 10,
            Continue = 11
        }
    }
}

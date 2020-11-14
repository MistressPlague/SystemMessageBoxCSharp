# SystemMessageBoxCSharp
A Simple Library For Using User32.dll's MessageBox In C#
# Example Usage
```csharp
MessageBoxUtils.MessageBoxResult result = (MessageBoxUtils.MessageBoxResult)MessageBoxUtils.MessageBox(IntPtr.Zero, "Main Text", "Title", (int)MessageBoxUtils.MessageBoxButtons.MB_YESNO | (int)MessageBoxUtils.MessageBoxIcon.MB_ICONQUESTION | (int)MessageBoxUtils.MessageBoxDefaultButton.FirstButton | (int)MessageBoxUtils.MessageBoxDisplaySettings.SetForeground | (int)MessageBoxUtils.MessageBoxDisplaySettings.TopMost);

if (result == MessageBoxUtils.MessageBoxResult.Yes)
{
    //User Clicked Yes
}
else if (result == MessageBoxUtils.MessageBoxResult.No)
{
    //User Clicked No
}

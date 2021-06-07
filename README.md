# SystemMessageBoxCSharp
A Simple Library For Using User32.dll's MessageBox In C#. - As Long As The Computer Is Running Windows, The MessageBox __**WILL**__ Show.
# Example Usage
```csharp
MessageBoxUtils.MessageBoxResult result = MessageBoxUtils.Show("Main Text", "Title", (int)MessageBoxUtils.MessageBoxButtons.MB_YESNO | (int)MessageBoxUtils.MessageBoxIcon.MB_ICONQUESTION | (int)MessageBoxUtils.MessageBoxDefaultButton.FirstButton | (int)MessageBoxUtils.MessageBoxDisplaySettings.SetForeground | (int)MessageBoxUtils.MessageBoxDisplaySettings.TopMost);

if (result == MessageBoxUtils.MessageBoxResult.Yes)
{
    //User Clicked Yes
}
else if (result == MessageBoxUtils.MessageBoxResult.No)
{
    //User Clicked No
}
```
# Version 2 Usage Is Near-Stock MessageBox Usage For WinForms. Enjoy!

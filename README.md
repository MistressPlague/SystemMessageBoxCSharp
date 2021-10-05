# SystemMessageBoxCSharp
A Simple Library For Using User32.dll's MessageBox In C#. - As Long As The Computer Is Running Windows, The MessageBox __**WILL**__ Show.
# Example Usage (v1)
```csharp
var result = MessageBoxUtils.Show("Main Text", "Title", (int)MessageBoxUtils.MessageBoxButtons.MB_YESNO | (int)MessageBoxUtils.MessageBoxIcon.MB_ICONQUESTION | (int)MessageBoxUtils.MessageBoxDefaultButton.FirstButton | (int)MessageBoxUtils.MessageBoxDisplaySettings.SetForeground | (int)MessageBoxUtils.MessageBoxDisplaySettings.TopMost);

if (result == MessageBoxUtils.MessageBoxResult.Yes)
{
    //User Clicked Yes
}
else if (result == MessageBoxUtils.MessageBoxResult.No)
{
    //User Clicked No
}
```
# Version 2 Usage Is Near-Stock MessageBox Usage Like In WinForms. Enjoy!
You May Want To Add This To Your Usings:
```csharp
using MessageBox = User32.MessageBox;
using MessageBoxButtons = User32.MessageBoxButtons;
using MessageBoxDefaultButton = User32.MessageBoxDefaultButton;
using MessageBoxIcon = User32.MessageBoxIcon;
using MessageBoxModal = User32.MessageBoxModal;
using MessageBoxResult = User32.MessageBoxResult;
```

# Example Usage (v2)
```csharp
var result = MessageBox.Show("Main Text", "Title", MessageBoxButtons.YesNo, true);

if (result == MessageBoxResult.Yes)
{
    //User Clicked Yes
}
else if (result == MessageBoxResult.No)
{
    //User Clicked No
}
```

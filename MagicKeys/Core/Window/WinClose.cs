using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static bool WinClose(string HWNDTitle, string HWNDClass)
{
SetWindowPos(GetForegroundWindow(), 0, 50, 50, 0, 0, MKC.SWP_NOSIZE|MKC.SWP_NOACTIVATE|MKC.SWP_NOZORDER);
while(true)
{
Thread.Sleep(20);
P = GetPluginCoord();
if (Array.TrueForAll(P[0..4], V => V == 0))
{
return true;
}
Application.DoEvents();
if (KeySwitch == 1)
{
return true;
}
WinWaitClose("#32768");
<<<<<<< HEAD
IntPtr Handle = GetForegroundWindow();
=======
                IntPtr Handle = GetForegroundWindow();
>>>>>>> ad7614f8545dd53a9aef0ffa14b58720fb40e01a
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle) == true && Class.ToString().Contains(HWNDClass) == true)
{
continue;
}
return true;
}

}
}
}
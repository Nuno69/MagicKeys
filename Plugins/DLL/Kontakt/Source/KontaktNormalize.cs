using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
{

public static void KontaktNormalize()
{
while (ImgSearch("KontaktLogo", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
RegisterHotKey(KeyNavigatorHandle.Handle, 21, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F4);
try
{
while (ImgSearch("KontaktBrowserOff", true)[0] == 0)
{
LoopException();
Application.DoEvents();
CreateOneBitmap(P[1], P[2], P[3], P[4]);
MouseClick("Left", P[1]+730, P[2]+17, 1, 0, 0, 10);
MouseClick("Left", P[1]+730, P[2]+40, 1, 0, 0, 10);
DisplayTraffic(P[1], P[2], P[3], P[4], 1, 1, 20);
}
while (ImgSearch("KontaktInfoShow", true)[0] == 1)
{
LoopException();
Application.DoEvents();
CreateOneBitmap(P[1], P[2], P[3], P[4]);
MouseClick("Left", P[1]+405, P[2]+17, 1, 0, 0, 10);
MouseClick("Left", P[1]+405, P[2]+85, 1, 0, 0, 10);
DisplayTraffic(P[1], P[2], P[3], P[4], 1, 1, 20);
}
}
catch(Exception)
{
UnregisterHotKey(KeyNavigatorHandle.Handle, 21);
KeySwitch = 1;
LoopError = false;
return;
}
UnregisterHotKey(KeyNavigatorHandle.Handle, 21);
return;
}

}
}
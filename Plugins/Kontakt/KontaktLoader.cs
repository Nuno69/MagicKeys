using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void PluginLoad()
{
if (API.GetVUIName() == "Kontakt")
{
KontaktNormalize();
LibLoaded();
}
KeyReg();
MagicKeys.KeyLoader();
MagicKeys.KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
MagicKeys.KeyUnReg();
}

}
}
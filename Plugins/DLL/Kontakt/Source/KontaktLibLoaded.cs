using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
{

public static void LibLoaded()
{
if(ImgSearch("KontaktLibLoaded", true)[0] == 1)
{
VUIObjectSwitcher(true, "false", 4, 6);
}
}

}
}